using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using EstateAgency1.Classes;
using Newtonsoft.Json;

namespace EstateAgency1.Classes
{
    internal class LoadData
    {
        private const string XmlFilePath = "estateAgency.xml";
        private const string JsonFilePath = "EstateAgency_.json";

        public static Agency LoadData_(bool loadFromXml) 
        {
            if (loadFromXml)
            {
                return LoadDataFromXml();
            }
            else
            {
                return LoadDataFromJson();
            }
        }

        public static Agency LoadDataFromXml()
        {
            XmlSerializer serializer = new XmlSerializer(typeof(Agency));
            try
            {
                using (StreamReader reader = new StreamReader(XmlFilePath))
                {
                    return (Agency)serializer.Deserialize(reader);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка загрузки данных из XML: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
        public static Agency LoadDataFromJson()
        {
            try
            {
                string jsonData = File.ReadAllText(JsonFilePath);
                return JsonConvert.DeserializeObject<Agency>(jsonData);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка загрузки данных из JSON: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
    }
}
