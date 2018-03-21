using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace AceCards.Domain.Models
{
    [Serializable]
    [DataContract]
    public class TestModel
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public bool isActive { get; set; }
    }
}
