using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1_Home_Work_laptop_
{ 
    /// <summary>
    /// Шаблонный класс магазина принимающий как телефоны так и ноутбуки
    /// </summary>
    /// <typeparam name="T">как парметр передается класс продукта (телефон или лэптоп)</typeparam>
    class Shop<T> where T:class, new ()
                  
    {
        
        private string name;
        private T[] items;
        /// <summary>
        /// Конструктор с параметрами
        /// </summary>
        /// <param name="name">имя магазина</param>
        /// <param name="count">количество товаров</param>
        public Shop(string name, int count) 
        {
            this.name = name;
            items = new T[count];
            for (int i = 0; i < items.Length; i++)
            {
                items[i] = new T();
            }
        }
        public T this[int index]
        {
            get
            {
                if ((index>=0)&&(index<items.Length))
                {
                    return items[index];
                }
                else
                {
                    return items[0];
                }
            }
            set
            {
                if ((index >= 0) && (index < items.Length))
                {
                    items[index] = value;
                }
            }
        }
        /// <summary>
        /// Конструктор по умолчанию
        /// </summary>
        public Shop() : this("Radio market", 5) { }

        public Shop(int count) :this("Radio market", count) { }
        /// <summary>
        /// конструктор принимающий в парметр массив техники
        /// </summary>
        /// <param name="array">как параметр принимает массив продуктов (гаджеты)</param>
        public Shop(T [] array) :this("Radio market" , array.Length) 
        {
            for (int i = 0; i < array.Length; i++)
            {
                items[i] = array[i];
            }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        /// <summary>
        /// вывод информация об магазине и товарах
        /// </summary>
        public void ShowItems()
        {
            Console.WriteLine("++++++++++++++++++++++++++");
            Console.WriteLine("Name of shop: "+this.Name);
            Console.WriteLine("models of gadjets: \n");
            for (int i = 0; i < items.Length; i++)
            {
                Console.WriteLine(items[i].ToString());
            }
        }
    }
}
