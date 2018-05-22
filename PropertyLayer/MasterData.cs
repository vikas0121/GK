using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace PropertyLayer
{
    [Serializable]
    [DataContract]
    public class MasterData
    {
        [DataMember]
        public List<JobDetails> JobData { get; set; }
    }
}
