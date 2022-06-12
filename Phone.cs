using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1_Home_Work_laptop_
{
    /// <summary>
    /// Класс описывающий телефон
    /// </summary>
    class Phone
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
                if (value >= 1)
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
        /// <summary>
        /// Конструктор с параметрами
        /// </summary>
        /// <param name="name">Модель телефона</param>
        /// <param name="manufacturer">производитель</param>
        /// <param name="price">цена</param>
        public Phone(string name, string manufacturer, int price)
        {
            this.name = name;
            this.manufacturer = manufacturer;
            if (price >= 1)
            {
                this.price = price;
            }
            else
            {
                Console.WriteLine("Price must be more than 0!");
                Environment.Exit(0);
            }
        }
        /// <summary>
        /// Конструктор п оумолчанию
        /// </summary>
        public Phone() : this("Galaxy S22", "Samsung", 1500) { }

        /// <summary>
        /// переопределенный метод перевода информации в строку
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "Info about phone: \nModel: " + this.Name + "\nManufacturer: " +
                this.Manufacturer + "\nPrice: " + this.Price + "\n==========================";
        }
        

    }
}
