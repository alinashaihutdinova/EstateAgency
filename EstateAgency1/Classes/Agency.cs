using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.AxHost;

namespace EstateAgency1.Classes
{
    [System.Xml.Serialization.XmlRoot("EstateAgency")]
    public class Agency
    {
        public string Name { get; set; }
        public Address Address { get; set; }
        public string Website { get; set; }
        public List<Agent> Agents { get; set; } = new List<Agent>();
        public List<Estate> Estates { get; set; } = new List<Estate>();
    }
}
