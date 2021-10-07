from PyQt5 import QtWidgets, uic
from PyQt5.QtWidgets import QMessageBox
from LiveWave import *
from threading import Thread
from datetime import datetime
from io import StringIO
import serial.tools.list_ports
import sys
import serial
import hashlib
import json
import zipfile

HEADER_TEMPLATE = open("header.template", "r").read()
FOOTER_TEMPLATE = open("footer.template", "r").read()


class Ui(QtWidgets.QMainWindow):
    def __init__(self):
        super(Ui, self).__init__()
        uic.loadUi('qtWindows/recSettings.ui', self)
        self.show()
        self.inRec = False
        self.tempFile = None
        self.recStartTimestamp = None
        self.recStartTimestampHash = None
        self.subject = None
        self.location = None
        self.updateThread = None
        self.streamRecorderThread = None
        self.mw = None
        self.streamRecorderRunningFlag = False
        self.firstPacketFlag = True
        # Serial port loading
        if len(list(serial.tools.list_ports.comports())) == 0:
            QMessageBox.critical(
                self,
                'LessonBuddy - Errore',
                "Nessuna porta seriale rilevata. L'applicazione verrà chiusa.",
                QMessageBox.Ok
            )
            exit(-1)
        for p in serial.tools.list_ports.comports():
            self.serialPortsComboBox.addItem(
                p.name
            )
        # Load all the required components
        self.attemptConnection = self.findChild(QtWidgets.QPushButton, 'attemptConnection')
        self.connStatusTextBox = self.findChild(QtWidgets.QLineEdit, 'connStatusTextBox')
        self.subjectTextBox = self.findChild(QtWidgets.QLineEdit, 'subjectTextBox')
        self.locationTextBox = self.findChild(QtWidgets.QLineEdit, 'locationTextBox')
        self.recControlButton = self.findChild(QtWidgets.QPushButton, 'recControlButton')
        self.signalQualityBar = self.findChild(QtWidgets.QProgressBar, 'signalQualityBar')
        self.actionLabel = self.findChild(QtWidgets.QLabel, 'actionLabel')
        # Set callbacks
        self.attemptConnection.clicked.connect(
            self.attemptSerialConnection
        )  # Remember to pass the definition/method, not the return value!
        self.recControlButton.clicked.connect(
            self.manageRecStart
        )

    def attemptSerialConnection(self):
        self.mw = None
        self.mw = LiveWave(
            str(
                self.serialPortsComboBox.currentText()
            )
        )
        self.mw.start()
        self.updateThread = GuiUpdateThread(self, self.mw)
        self.updateThread.start()

    def manageRecStart(self):
        if self.inRec:
            self.streamRecorderRunningFlag = False
            self.firstPacketFlag = True
            self.streamRecorderThread.join()
            self.tempFile.write("\n")
            self.tempFile.write(FOOTER_TEMPLATE)
            self.tempFile.seek(0)
            self.inRec = False
            self.actionLabel.setText("Generazione file tracciato")
            zip_path = os.path.join(
                QtWidgets.QFileDialog.getExistingDirectory(self, 'Seleziona cartella di salvataggio.'),
                f"LB-{self.recStartTimestamp}.lbd"
            )
            jsonFileName = f"LB-{self.recStartTimestamp}.json"
            f = open(jsonFileName, "a")
            f.write(self.tempFile.read())
            f.close()
            self.tempFile.close()
            zipObj = zipfile.ZipFile(zip_path, 'w')
            zipObj.write(jsonFileName)
            zipObj.close()
            os.remove(jsonFileName)
            # Cambia testo dei controlli e attiva controlli bloccati
            self.subjectTextBox.setEnabled(True)
            self.locationTextBox.setEnabled(True)
            self.recControlButton.setText("AVVIA\nREGISTRAZIONE")
            self.actionLabel.setText("Nessuna azione in corso")
        else:
            self.subject = self.subjectTextBox.text()
            self.location = self.locationTextBox.text()
            if self.subject == "" or self.location == "":
                QMessageBox.critical(
                    self,
                    'LessonBuddy - Errore',
                    "Compilare tutti i campi necessari per avviare la registrazione.",
                    QMessageBox.Ok
                )
                return
            self.inRec = True
            self.recStartTimestamp = datetime.now().strftime("%Y%m%d%H%M%S")
            self.recStartTimestampHash = hashlib.md5(
                self.recStartTimestamp.encode()
            ).hexdigest().upper()
            header = HEADER_TEMPLATE.replace(
                "{checksum}",
                self.recStartTimestampHash
            )
            header = header.replace(
                "{subject}",
                self.subject
            )
            header = header.replace(
                "{location}",
                self.location
            )
            self.tempFile = StringIO()
            self.tempFile.write(header)
            self.streamRecorderThread = StreamRecorderThread(self, self.tempFile, self.mw)
            self.streamRecorderRunningFlag = True
            self.streamRecorderThread.start()
            # Cambia testo dei controlli e blocca controlli attivi
            self.subjectTextBox.setEnabled(False)
            self.locationTextBox.setEnabled(False)
            self.recControlButton.setText("FERMA\nREGISTRAZIONE")


class GuiUpdateThread(Thread):
    def __init__(self, widget, headsetc):
        Thread.__init__(self)
        self.widget = widget
        self.headsetc = headsetc

    def run(self):
        minuti = secondi = 0
        while True:
            if self.headsetc.attention == 0 and self.headsetc.meditation == 0 and self.headsetc.poor_signal == 0:
                self.widget.connStatusTextBox.setText("Aspettando pacchetti validi...")
                if not self.widget.inRec:
                    self.widget.recControlButton.setEnabled(False)
                self.widget.signalQualityBar.setValue(0)
            else:
                self.widget.attemptConnection.setEnabled(False)
                self.widget.connStatusTextBox.setText("SIGNAL LOCKED!")
                self.widget.recControlButton.setEnabled(True)
                if self.headsetc.poor_signal <= 200:
                    sig_qual = 200 - self.headsetc.poor_signal
                    self.widget.signalQualityBar.setValue(sig_qual)
            if self.widget.inRec:
                if secondi == 59:
                    secondi = 0
                    minuti += 1
                else:
                    secondi += 1
                if minuti < 10:
                    timerstring = "0" + str(minuti)
                else:
                    timerstring = str(minuti)
                timerstring += ":"
                if secondi < 10:
                    timerstring += "0" + str(secondi)
                else:
                    timerstring += str(secondi)
                self.widget.actionLabel.setText(f"In registrazione da: {timerstring}")
                time.sleep(1)
            else:
                minuti = secondi = 0
                time.sleep(0.5)


class StreamRecorderThread(Thread):
    def __init__(self, widget, filehandle, headsetc):
        Thread.__init__(self)
        self.filehandle = filehandle
        self.headsetc = headsetc
        self.widget = widget

    def run(self):
        while self.widget.streamRecorderRunningFlag:
            self.filehandle.write("\n")
            if not self.widget.firstPacketFlag:
                self.filehandle.write(",")
            sig_qual = 0
            if self.headsetc.poor_signal <= 200:
                sig_qual = 200 - self.headsetc.poor_signal
            timestamp = datetime.now().strftime("%Y-%m-%dT%H:%M:%S:%f)")[:-4]
            objectToSerialize = {
                "EventTime": timestamp,
                "ConnectionStrength": sig_qual,
                "AttentionLevel": self.headsetc.attention,
                "MeditationLevel": self.headsetc.meditation
            }
            json.dump(objectToSerialize, self.filehandle)
            self.widget.firstPacketFlag = False
            time.sleep(0.5)


def exitHandler():
    exit(0)


# START POINT
if __name__ == '__main__':
    app = QtWidgets.QApplication(sys.argv)
    window = Ui()
    app.exec_()
    app.aboutToQuit.connect(exitHandler)
