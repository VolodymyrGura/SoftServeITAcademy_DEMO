using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Json;
using System.Xml.Serialization;

namespace SoftServeITAcademy_DEMO
{
  public class Demo
    {
        static void Main(string[] args)
        {
            JewelryStore jewelryStore = new JewelryStore();
            jewelryStore.GetStores(10);
            jewelryStore.PrintStore();

            XmlSerializer xmlser = new XmlSerializer(typeof(JewelryStore));
            Stream serialStream = new FileStream("store.xml", FileMode.Create);
            xmlser.Serialize(serialStream, jewelryStore);

            Stream file = new FileStream("store.json", FileMode.Create);
            DataContractJsonSerializer ser = new DataContractJsonSerializer(typeof(JewelryStore));
            ser.WriteObject(file, jewelryStore);

            JewelryDecoration jewelryDecoration = new JewelryDecoration();
            jewelryDecoration.GetRandomJewelry(10);
            jewelryDecoration.PrintJewelry();

            XmlSerializer xmlseri = new XmlSerializer(typeof(JewelryDecoration));
            Stream serialStreams = new FileStream("jewerly.xml", FileMode.Create);
            xmlseri.Serialize(serialStreams, jewelryDecoration);

            Stream file2 = new FileStream("jewerly.json", FileMode.Create);
            DataContractJsonSerializer seri = new DataContractJsonSerializer(typeof(JewelryDecoration));
            seri.WriteObject(file2, jewelryDecoration);

            //List<JewelryDecoration> jewelryDecoration = new List<JewelryDecoration>();

            Console.ReadKey();
        }
    }
}
