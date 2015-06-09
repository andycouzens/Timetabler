using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Timetabler.Entitities
{
    public class Attendee
    {
        public long Id { get; set; }

        public AttendeeType Type { get; set; }

        [Required]
        [MaxLength(255)]
        public string Name { get; set; }
    }
}
