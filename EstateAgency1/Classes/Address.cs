using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace EstateAgency1.Classes
{
    public class Address
    {
        public string City { get; set; }
        public string Street { get; set; }
        public int HouseNumber { get; set; }
        public override string ToString()
        {
            return $"{City}, {Street}, {HouseNumber}"; 
        }
    }
}
