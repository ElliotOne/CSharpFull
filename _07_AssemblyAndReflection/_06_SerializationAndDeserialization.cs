using System;
using System.Collections.Generic;
using System.IO;
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
                new Employees { Id = 1, FirstName = "Elliot",   LastName = "One",     PhoneNumber = "123456789" },
                new Employees { Id = 2, FirstName = "James",    LastName = "Smith",   PhoneNumber = "123456789" },
                new Employees { Id = 3, FirstName = "John",     LastName = "Taylor",  PhoneNumber = "123456789" },
                new Employees { Id = 4, FirstName = "Michael",  LastName = "Brown",   PhoneNumber = "123456789" },
                new Employees { Id = 5, FirstName = "David",    LastName = "Johnson", PhoneNumber = "123456789" },
                new Employees { Id = 6, FirstName = "Daniel",   LastName = "Clark",   PhoneNumber = "123456789" },
                new Employees { Id = 7, FirstName = "William",  LastName = "Evans",   PhoneNumber = "123456789" },
                new Employees { Id = 8, FirstName = "Thomas",   LastName = "Green",   PhoneNumber = "123456789" }
            };

            //Convert to XML format (Serialize)
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Employees>));
            using (StringWriter sw = new StringWriter())
            {
                xmlSerializer.Serialize(sw, employees);
                Console.WriteLine(sw.ToString());
                xmlText = sw.ToString();
            }

            //Convert from XML format to objects (Deserialize)
            XmlSerializer xmlReader = new XmlSerializer(typeof(List<Employees>));
            using (StringReader sr = new StringReader(xmlText))
            {
                List<Employees> temp = (List<Employees>)xmlReader.Deserialize(sr);
                foreach (var employee in temp)
                {
                    Console.WriteLine(employee.Id);
                    Console.WriteLine(employee.FirstName);
                }
            }
        }
    }

    [Serializable()]
    class Employees
    {
        [XmlElement("EmployeeID")]
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        [XmlIgnore]
        public string PhoneNumber { get; set; }
    }
}
