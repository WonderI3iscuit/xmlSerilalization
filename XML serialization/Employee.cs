using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Xml;

namespace XML_serialization
{

    //serialize that hoe

    [XmlRoot("New Employees", Namespace ="www.nerdinc.ninja")]
    public class Employee //you cannot serialize private classes btw
    {
        public int ID { get; set; }
        public string name { get; set; }
        public double ssnumber { get; set; }
        public DateTime EntryDate { get; set; } // using datetime method. predefined method in the .net framework
        public string JobRole { get; set; }
    }
}
