using System;
using System.Collections.Generic;

#nullable disable

namespace lessonbuddy.mrbackslash.it.Models
{
    public partial class Session
    {
        public Session()
        {
            Payloads = new HashSet<Payload>();
        }

        public int Idsession { get; set; }
        public Guid Guidsession { get; set; }
        public string Username { get; set; }
        public string Subject { get; set; }
        public string Location { get; set; }
        public DateTime UploadDateTime { get; set; }

        public virtual ICollection<Payload> Payloads { get; set; }
    }
}
