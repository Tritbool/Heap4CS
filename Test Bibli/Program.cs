using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;
using System.Xml.Linq;

namespace Test_Bibli
{
    class Program
    {

        static void Main(string[] args){
            
            XmlSchemaSet schemas = new XmlSchemaSet();
            String Path = Directory.GetParent(Directory.GetParent(Directory.GetCurrentDirectory()).ToString()).ToString();
            Console.WriteLine(Path+"\n");
            String [] xsds = Directory.GetFiles(Path+"\\XSD\\");

            char[] delimiter = { '\\', '.' };


            String ns = "http://liktek.fr/likacoustik/";


            for (int i = 0; i < xsds.Length; i++)
            {
                string[] folders = xsds[i].Split(delimiter);
                schemas.Add(ns+folders[folders.Length-2], xsds[i]);
                Console.WriteLine(folders[folders.Length-2]);
            }


        

            XDocument xmlTest = XDocument.Load(Path+"\\XML\\testClient.xml");



            bool errors = false;
            xmlTest.Validate(schemas, (o, e) =>
            {
                Console.WriteLine("{0}", e.Message);
                errors = true;
            });
            Console.WriteLine("xmlTest {0}", errors ? "did not validate" : "validated");


            Console.ReadKey();
           







        }
    }
}
