using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1_Home_Work_laptop_
{
    class Laptop
    {
        string name;
        string manufacturer;
        int price;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Manufacturer
        {
            get { return manufacturer; }
            set { manufacturer = value; }
        }
        public int Price
        {
            get { return price; }
            set 
            {
                if (value>=1) 
                {
                    price = value;
                }
                else
                {
                    Console.WriteLine("Price must be more than 0!");
                    Environment.Exit(0);
                }
            }
        }
        public Laptop(string name, string manufacturer, int price)
        {
            this.name = name;
            this.manufacturer = manufacturer;
            if(price>=1)
            {
                this.price = price;
            }
            else
            {
                Console.WriteLine("Price must be more than 0!");
                Environment.Exit(0);
            }
        }
        public Laptop() : this("Aspire", "Acer", 1000) { }
        public void ShowInfo()
        {
            Console.WriteLine("Info about laptop: ");
            Console.WriteLine("Model: " + this.Name);
            Console.WriteLine("Manufacturer: "+this.Manufacturer);
            Console.WriteLine("Price: "+this.Price);
            Console.WriteLine("==========================");
        }
       
         

    }
}
