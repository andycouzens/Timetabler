using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Timetabler.Entitities
{
    public class Address
    {
        public long Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Line1 { get; set; }

        [MaxLength(50)]
        public string Line2 { get; set; }

        [MaxLength(50)]
        public string Line3 { get; set; }

        [MaxLength(50)]
        public string Town { get; set; }

        [MaxLength(50)]
        public string County { get; set; }

        [Required]
        [MaxLength(10)]
        public string Postcode { get; set; }
    }
}
