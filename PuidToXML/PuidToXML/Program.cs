using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace PuidToXML
{
    public class PuidData
    {
        public string PUID { get; set; }
        public string Email { get; set; }
        public string PuidType { get; set; }

    }
    public class Program
    {
        static void Main(string[] args)
        {
            string[] lines = File.ReadAllLines(@"E:\SourceCode\Personal\PuidstoXML\Puids.txt");
            List<PuidData> list = new List<PuidData>();

            foreach (string line in lines)
            {
                string[] contents = line.Split(new char[] { ',' });
                var puid = new PuidData { PUID = contents[1].Trim(), Email = contents[0].Trim(), PuidType = "MSABulkGenerated" };
                list.Add(puid);
            }

            using (FileStream fs = new FileStream(@"E:\SourceCode\Personal\PuidstoXML\Prodxml.xml", FileMode.Create))
            {
                new XmlSerializer(typeof(List<PuidData>)).Serialize(fs, list);
            }

        }
    }
}
