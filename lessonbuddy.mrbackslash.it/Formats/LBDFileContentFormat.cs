using System;
using System.Collections.Generic;

namespace lessonbuddy.mrbackslash.it.Formats
{
    public class Payload
    {
        public DateTime EventTime { get; set; }
        public int ConnectionStrength { get; set; }
        public int AttentionLevel { get; set; }
        public int MeditationLevel { get; set; }
    }

    public class Session
    {
        public string Subject { get; set; }
        public string Location { get; set; }
        public List<Payload> Payloads { get; set; }
    }


    public class LBDFileContentFormat
    {
        public string Checksum { get; set; }
        public Session Session { get; set; }
    }
}
