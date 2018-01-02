using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;

namespace SoftServeITAcademy_DEMO
{
    [Serializable]
    [DataContract]
    public class JewelryStore : JewelryDecoration
    {
        [DataMember]
        private string address;
        [DataMember]
        private int amount;
        //private List<string>  = new List<string>();
        [DataMember]
        private List<JewelryStore> stores;

        public string Address { get; set; }

        public int Amount { get; set; }

       public List<JewelryStore> Stores { get; set; }

        public JewelryStore()
        {

        }

        public JewelryStore(string addresses, int amounts)
        {
            this.address = addresses;
            this.amount = amounts;
        }

        public override string ToString()
        {
            return $"Adress {this.address} Amount {this.amount} ";
        }

        public void GetStores(int count)
        {
            stores = new List<JewelryStore>(count);

            stores.Add(new JewelryStore
            {
                    Address = "Lviv",
                    Amount = 4

                });
            stores.Add(new JewelryStore
            {
                Address = "Kuiv",
                Amount = 10

            });
            stores.Add(new JewelryStore
            {
                Address = "Rivne",
                Amount = 2

            });
            stores.Add(new JewelryStore
            {
                Address = "Odessa",
                Amount = 1

            });
            Console.WriteLine($"Adress {this.address} Amount {this.amount}");

        }

        public void Print()
        {
            Console.WriteLine($"Adress {this.address} Amount {this.amount}");
        }

        public void PrintStore()
        {
            this.PrintStore(this.stores);
        }

        public void PrintStore(List<JewelryStore> stores)
        {

            foreach (var w in stores)
            {
                w.Print();
            }
        }

        //public void Read()
        //{
        //    List<string> phones = new List<string>();
        //    string line;
        //    string fileNames = @"D:\ATQC\C#\Labs\SoftServeITAcademy_DEMO\SoftServeITAcademy_DEMO\JewelryStore.txt";
        //    using (StreamReader sr = new StreamReader(fileNames))
        //    {

        //        while ((line = sr.ReadLine()) != null)
        //        {
        //            this.jewelry.Add(line);
        //            // Console.WriteLine(line);
        //        }
        //    }
        //}

        //public void Print()
        //{
        //    foreach (string l in jewelry)
        //    {
        //        Console.WriteLine(l);
        //    }
        //}

        //public void Printy()
        //{
        //    Console.WriteLine($"Adress {this.address} Amount {this.amount} ");
        //}


    }
}
