using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1_Home_Work_laptop_
{
    class Program
    {
        static void Main(string[] args)
        {
            //Laptop a = new Laptop("maccbook" , "Apple" , 2000);
            //a.ShowInfo();
            //a.Price = 5000;
            //a.Name = "Air";
            //a.ShowInfo();



            //Laptop b = new Laptop
            //{
            //    Name = "p500",
            //    Manufacturer = "HP",
            //    Price = 400
            //};
            //b.ShowInfo();

            //Shop shop = new Shop();
            //shop.ShowLaptops();


            //Laptop[] lapArray = new Laptop[5];
            //lapArray[0] = new Laptop("MacBook Pro", "Apple", 2000);
            //lapArray[1] = new Laptop("MacBook Air", "Apple", 1000);
            //lapArray[2] = new Laptop("Aspire", "Acer", 600);
            //lapArray[3] = new Laptop("P600", "HP", 2500);
            //lapArray[4] = new Laptop("ROG 6", "Asus", 5000);

            //Shop shop = new Shop(lapArray);
            //shop.ShowLaptops();
            //shop[2] = new Laptop("MacBook Super Pro MAX", "Apple", 100000);
            //shop.ShowLaptops();
            //shop[2].ShowInfo();

            //Phone b = new Phone();
            //Console.WriteLine(b.ToString());


            //Laptop a = new Laptop();
            //Console.WriteLine(a.ToString()); 

            //Shop<Phone> a = new Shop<Phone>();
            //a.ShowItems();
            //Shop<Laptop> b = new Shop<Laptop>();
            //b.ShowItems();

            Laptop[] lapArray = new Laptop[5];
            lapArray[0] = new Laptop("MacBook Pro", "Apple", 2000);
            lapArray[1] = new Laptop("MacBook Air", "Apple", 1000);
            lapArray[2] = new Laptop("Aspire", "Acer", 600);
            lapArray[3] = new Laptop("P600", "HP", 2500);
            lapArray[4] = new Laptop("ROG 6", "Asus", 5000);

            Shop<Laptop> laptops = new Shop<Laptop>(lapArray);
            laptops.ShowItems();

            Phone a = new Phone();

        }
    }
}
