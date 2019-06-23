using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace _07_AssemblyAndReflection
{
    class _06_SerializationAndDeserialization
    {
        void ThisIsMain()
        {
            string xmlText = string.Empty;
            List<Employees> employees = new List<Employees>
            {
                new Employees {Id = 1,firstName = "Ali",lastName ="One",phoneNumber="123456789" },
                new Employees {Id = 2,firstName = "Hasan",lastName ="Two",phoneNumber="123456789" },
                new Employees {Id = 3,firstName = "Hosein",lastName ="Three",phoneNumber="123456789" },
                new Employees {Id = 4,firstName = "Mohammad",lastName ="Four",phoneNumber="123456789" },
                new Employees {Id = 5,firstName = "Mahdi",lastName ="Five",phoneNumber="123456789" },
                new Employees {Id = 6,firstName = "Abbas",lastName ="Six",phoneNumber="123456789" },
                new Employees {Id = 7,firstName = "Iman",lastName ="Seven",phoneNumber="123456789" },
                new Employees {Id = 8,firstName = "Hadi",lastName ="Eight",phoneNumber="123456789" }
            };

            //Conevert to XML format (Serialize)
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Employees>));
            using (StringWriter sw = new StringWriter())
            {
                xmlSerializer.Serialize(sw, employees);
                Console.WriteLine(sw.ToString());
                xmlText = sw.ToString();
            }

            //Convert from XML format to objects (Deserilize)
            XmlSerializer xmlReader = new XmlSerializer(typeof(List<Employees>));
            using (StringReader sr = new StringReader(xmlText))
            {
                List<Employees> temp =(List<Employees>)xmlReader.Deserialize(sr);
                foreach (var employee in temp)
                {
                    Console.WriteLine(employee.Id);
                    Console.WriteLine(employee.firstName);
                }
            }
        }
    }

    [Serializable()]
    class Employees
    {
        [XmlElement("EmployeeID")]
        public int Id { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        [XmlIgnore]
        public string phoneNumber { get; set; }
    }
}
