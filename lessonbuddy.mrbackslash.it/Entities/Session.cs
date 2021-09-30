using System;
using System.Collections.Generic;

namespace lessonbuddy.mrbackslash.it.Entities
{
    public class Session
    {
        public int Idsession { get; set; }
        public Guid Guidsession { get; set; }
        public string Username { get; set; }
        public string Subject { get; set; }
        public string Location { get; set; }
        public DateTime? UploadDateTime { get; set; }
        public List<Payload> Payloads { get; set; }
    }
}
