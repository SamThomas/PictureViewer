using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tortank
{
    public class Serialize
    {

        public static void saveXML(List<Album> alb,string nameFile){
            FileStream file = File.Open(nameFile, FileMode.Create);
            XmlSerializer serializer = new XmlSerializer(typeof(List<Album>));
            serializer.Serialize(file, alb);
            file.Close();
        }

        public static List<Album> loadXML(string nameFile)
        {
            List<Album> cAlbum = new List<Album>();
            FileStream file = File.Open(nameFile, FileMode.Open);
            XmlSerializer serializer = new XmlSerializer(typeof(List<Album>));
            try
            {
                cAlbum = (List<Album>)serializer.Deserialize(file);
                Console.WriteLine("Collecction Album correctement alloué");
            }
            catch(InvalidOperationException e)
            {
                cAlbum = new List<Album>();
                Console.WriteLine("Raté hélas ......");
            }
            finally
            {
                file.Close();
            }
            file.Close();
            return cAlbum;
        }
        
    }
}
