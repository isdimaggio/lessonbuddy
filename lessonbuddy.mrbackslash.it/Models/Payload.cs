using System;
using System.Collections.Generic;

#nullable disable

namespace lessonbuddy.mrbackslash.it.Models
{
    public partial class Payload
    {
        public int Idsession { get; set; }
        public DateTime EventTime { get; set; }
        public int ConnectionStrength { get; set; }
        public int AttentionLevel { get; set; }
        public int MeditationLevel { get; set; }

        public virtual Session IdsessionNavigation { get; set; }
    }
}
