using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BlacksmithSimulator
{

    public static class XmlManager
    {
        public static void XmlDataWriter(object obj, string filename)
        {
            XmlSerializer sr = new XmlSerializer(obj.GetType());
            TextWriter writer = new StreamWriter(filename);
            sr.Serialize(writer, obj);
            writer.Close();
        }

        public static Player XmlDataReaderPlayer(string filename)
        {
            Player obj = new Player();
            XmlSerializer sr = new XmlSerializer(typeof(Config));
            FileStream reader = new FileStream(filename, FileMode.Open, FileAccess.Read, FileShare.Read);
            obj = (Player)sr.Deserialize(reader);
            reader.Close();
            return obj;
        }
        public static Player XmlDataReaderConfig(string filename)
        {
            Player obj = new Player();
            XmlSerializer sr = new XmlSerializer(typeof(Config));
            FileStream reader = new FileStream(filename, FileMode.Open, FileAccess.Read, FileShare.Read);
            obj = (Player)sr.Deserialize(reader);
            reader.Close();
            return obj;
        }
    }
}
