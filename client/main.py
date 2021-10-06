from PyQt5 import QtWidgets, uic
from LiveWave import *
import serial.tools.list_ports
import sys
import serial
from threading import Thread
import time


class Ui(QtWidgets.QMainWindow):
    def __init__(self):
        super(Ui, self).__init__()
        uic.loadUi('qtWindows/recSettings.ui', self)
        self.show()
        # Serial port loading
        for p in serial.tools.list_ports.comports():
            self.serialPortsComboBox.addItem(
                p.name
            )
        # Set callbacks
        self.attemptConnection = self.findChild(QtWidgets.QPushButton, 'attemptConnection')  # Find the button
        self.connStatusTextBox = self.findChild(QtWidgets.QLineEdit, 'connStatusTextBox')  # Find the textbox
        self.recStartButton = self.findChild(QtWidgets.QPushButton, 'recStartButton')  # Find the button
        self.signalQualityBar = self.findChild(QtWidgets.QProgressBar, 'signalQualityBar')  # Find the bar
        self.attemptConnection.clicked.connect(
            self.attemptSerialConnection
        )  # Remember to pass the definition/method, not the return value!

    def attemptSerialConnection(self):
        self.mw = None
        self.mw = LiveWave(
            str(
                self.serialPortsComboBox.currentText()
            )
        )
        self.mw.start()
        #while True:
        #    print("Attention: " + str(self.mw.attention))
        #    print("Meditation: " + str(self.mw.meditation))
        #    print("PoorSignal: " + str(self.mw.poor_signal))
        #    time.sleep(1)
        self.updateThread = SignalBarUpdateThread(self, self.mw)
        self.updateThread.start()


class SignalBarUpdateThread (Thread):
   def __init__(self, widget, headsetc):
      Thread.__init__(self)
      self.widget = widget
      self.headsetc = headsetc
   def run(self):
        while True:
            if self.headsetc.attention == 0 and self.headsetc.meditation == 0 and self.headsetc.poor_signal == 0:
                self.widget.connStatusTextBox.setText("Aspettando pacchetti validi...")
            else:
                self.widget.connStatusTextBox.setText("SIGNAL LOCKED!")
                self.widget.recStartButton.setEnabled(True)
                sigQual = 0
                if self.headsetc.poor_signal > 200:
                    sigQual = 0
                else:
                    sigQual = 200 - self.headsetc.poor_signal
                    self.widget.signalQualityBar.setValue(sigQual)
            time.sleep(0.5)


# START POINT
if __name__ == '__main__':
    app = QtWidgets.QApplication(sys.argv)
    window = Ui()
    app.exec_()
