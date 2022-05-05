using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1_Home_Work_laptop_
{
    class Shop
    {
        private string name;
        private Laptop[] laptops;
        public Shop(string name, int count)
        {
            this.name = name;
            laptops = new Laptop[count];
            for (int i = 0; i < laptops.Length; i++)
            {
                laptops[i] = new Laptop();
            }
        }
        public Laptop this[int index]
        {
            get
            {
                if ((index>=0)&&(index<laptops.Length))
                {
                    return laptops[index];
                }
                else
                {
                    return laptops[0];
                }
            }
            set
            {
                if ((index >= 0) && (index < laptops.Length))
                {
                    laptops[index] = value;
                }
            }
        }
        public Shop() : this("Radio market", 5) { }
        public Shop(int count) :this("Radio market", count) { }
        public Shop(Laptop [] array) :this("Radio market" , array.Length) 
        {
            for (int i = 0; i < array.Length; i++)
            {
                laptops[i] = array[i];
            }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public void ShowLaptops()
        {
            Console.WriteLine("++++++++++++++++++++++++++");
            Console.WriteLine("Name of shop: "+this.Name);
            Console.WriteLine("models of Laptops: \n");
            for (int i = 0; i < laptops.Length; i++)
            {
                laptops[i].ShowInfo();
            }
        }
    }
}
