using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstateAgency1.Classes
{
    public class Features
    {
        public bool HasBalcony { get; set; }
        public bool HasParking { get; set; }
        public string Description { get; set; }
        public override string ToString()
        {
            List<string> featureStrings = new List<string>();
 
            if (!string.IsNullOrEmpty(Description)) 
            {
                featureStrings.Add(Description); 
            }
            if (HasBalcony)
            {
                featureStrings.Add("Балкон");
            }
            if (HasParking)
            {
                featureStrings.Add("Парковка");
            }
            return string.Join(", ", featureStrings);
        }
    }
}
