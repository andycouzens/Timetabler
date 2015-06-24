using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Timetabler.Entitities
{
    [DataContract]
    public class Event
    {
        [DataMember]
        public long Id { get; set; }

        [Required]
        [MaxLength(50)]
        [DataMember]
        public string Title { get; set; }

        [Required]
        [MaxLength(255)]
        [DataMember]
        public string Description { get; set; }

        [Required]
        [DataMember]
        public EventType Type { get; set; }
    }
}
