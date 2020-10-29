using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Xml;
using System.IO;

namespace XML_serialization
{
    class Program
    {
        static void Main(string[] args)
        {
         Employee emp = new Employee();
     //     emp.ID = 123;
     //     emp.name = "Ben";
     //     emp.ssnumber = 123456789;
     //     emp.EntryDate = DateTime.Now;
     //     emp.JobRole = "ninja";


            Console.WriteLine($"employee id: {emp.ID} \n employee name: {emp.name} \nEmployee ss#: {emp.ssnumber} \n date created {emp.EntryDate}");
            Console.ReadKey();

            //create a location to store the xml file
            string FilePath = "C:/Temp/";
            string FileName = "Samurai.xml";

            //  //saves and creates the file path and combines the above tow variables
            //  TextWriter writer = new StreamWriter(FilePath + FileName);
            //
            //  //actual part of the serialization
            //  XmlSerializer ser = new XmlSerializer(typeof(Employee));
            //
            //  //get the writer stream and the instance of the class we have 
            //  ser.Serialize(writer, emp);
            //  writer.Close();
            //
            //  Console.ReadLine();
            //

            XmlSerializer des = new XmlSerializer(typeof(Employee));
            using (XmlReader reader = XmlReader.Create(FilePath + FileName))
            {
                emp = (Employee)des.Deserialize(reader);
                Console.WriteLine(($"employee id: {emp.ID} \n employee name: {emp.name} \nEmployee ss#: {emp.ssnumber} \n date created {emp.EntryDate}"));
            }
        }
    }
}
