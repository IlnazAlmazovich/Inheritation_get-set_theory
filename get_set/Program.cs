using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace get_set
{
    class Person // создаём класс Person
    {
        public string _name; //поле которое хранит имя

        public string Name
        {
            get
            {
                return _name; //Возвращает значение поля _name
            }
            set
            {
                _name = value; //устанавливает полю _name некое значение
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person(); //создаём экземпляр класса Person
            Console.WriteLine("Введите имя: ");
            p.Name = Console.ReadLine(); //пользователь вводит имя
            Console.WriteLine(p.Name); // Вывод значения Name на консоль
            Console.ReadKey();
        }
    }
}
