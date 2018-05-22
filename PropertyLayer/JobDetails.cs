using System;
using System.Runtime.Serialization;

namespace PropertyLayer
{
    [Serializable]
    [DataContract]
    public class JobDetails
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string Title { get; set; }
        [DataMember]
        public string Type { get; set; }
        [DataMember]
        public string CompnayName { get; set; }
        [DataMember]
        public string Description { get; set; }
        [DataMember]
        public string Location { get; set; }
        [DataMember]
        public string Subject { get; set; }
        [DataMember]
        public string Ctc { get; set; }
        [DataMember]
        public string RecepientEmail { get; set; }
        [DataMember]
        public string CreatedOn { get; set; }
    }
}
