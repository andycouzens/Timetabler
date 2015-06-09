using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Timetabler.Entitities
{
    public class Location
    {
        public long Id { get; set; }

        public string Name { get;  set; }

        public Address Address { get; set; }
    }
}
