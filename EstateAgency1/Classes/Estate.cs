using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstateAgency1.Classes
{
    public class Estate
    {
        public int ID { get; set; }
        public string Address { get; set; }
        public string Type { get; set; }
        public uint Bedrooms { get; set; }
        public double Price { get; set; }
        public Features Features { get; set; }
    }
}
