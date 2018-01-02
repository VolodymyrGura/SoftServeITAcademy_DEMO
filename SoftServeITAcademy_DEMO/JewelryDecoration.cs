using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;

namespace SoftServeITAcademy_DEMO
{
    public enum NameJewelries
    {
        Earrings, Necklace, WeddingRing, Coulomb
    }

    public enum Metals
    {
        Gold, Silver, Platinum, Palladium, Copper
    }

    [Serializable]
    [DataContract]

    public class JewelryDecoration : IComparable<JewelryDecoration>
    {
        [DataMember]
        private NameJewelries name;
        [DataMember]
        private Metals metal;
        [DataMember]
        private double weight;
        [DataMember]
        private double price;

        [DataMember]
        private readonly Random random;
        [DataMember]
        private List<JewelryDecoration> jewelries;
        [DataMember]
        private List<string> jewelry = new List<string>();

        public NameJewelries Name { get; set; }

        public Metals Metal { get; set; }

        public double Weight { get; set; }

        public double Price { get; set; }

        public List<string> Jewelry { get; set; }

        public List<JewelryDecoration> Jewelries { get => jewelries; set => jewelries = value; }

        public JewelryDecoration()
        {
            this.random = new Random();
        }

        public JewelryDecoration(NameJewelries names, Metals metals, double weights, double prices)
        {
            this.name = names;
            this.metal = metals;
            this.weight = weights;
            this.price = prices;
        }

        public void Read()
        {
            string line;
            string fileNames = @"D:\ATQC\C#\Labs\SoftServeITAcademy_DEMO\SoftServeITAcademy_DEMO\JewelryStore.txt";
            using (StreamReader sr = new StreamReader(fileNames))
            {
                while ((line = sr.ReadLine()) != null)
                {
                    this.jewelry.Add(line);
                    Console.WriteLine(line);
                }
            }
        }

        public void GetRandomJewelry(int amounts)
        {
            Random rand = new Random();
            this.jewelries = new List<JewelryDecoration>(amounts);

            for (var i = 0; i < amounts; i++)
            {
                this.jewelries.Add(new JewelryDecoration
                {
                    Name = (NameJewelries)this.random.Next(4),
                    Metal = (Metals)this.random.Next(5),
                    Weight = rand.Next(20),
                    //Price = this.Weight * (int)this.Metal
                    Price = this.Weight * (int)(Metals)this.random.Next(5)
                });

                Console.WriteLine($"Name {this.name} Metal {this.metal} Weight {this.weight} Price {this.price} ");
            }
        }

        public void Print()
        {
            Console.WriteLine($"Name {this.name} Adress {this.metal} Weight {this.weight} Price {this.price} ");
        }

        public void PrintJewelry()
        {
            this.PrintJewelry(this.jewelries);
        }

        public void PrintJewelry(List<JewelryDecoration> jewelries)
        {
            foreach (var w in jewelries)
            {
                w.Print();
            }
        }

        public int CompareTo(JewelryDecoration other)
        {
            return this.name.CompareTo(other.name);
        }

        public IEnumerable<JewelryDecoration> SortJewelryDecoration()
        {
            return this.jewelries.OrderBy(j => j.Name);
        }
       
    }
}
