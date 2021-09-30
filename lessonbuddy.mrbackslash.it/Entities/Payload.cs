using System;

namespace lessonbuddy.mrbackslash.it.Entities
{
    public class Payload
    {
        public int Idsession { get; set; }
        public DateTime EventTime { get; set; }
        public int ConnectionStrength { get; set; }
        public int AttentionLevel { get; set; }
        public int MeditationLevel { get; set; }        
    }
}
