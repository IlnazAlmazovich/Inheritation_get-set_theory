using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritation_theory
{
    class Person // создаём класс Person
    {
        public string Name { get; set; } //Создаём свойство
        public string FirstName { get; set; } //Создаём свойство
        public string LastName { get; set; } //Создаём свойство

        public virtual void Write() // создание виртуальный метод для вывода сообщения
        {
            Console.WriteLine($"Привет!!! Меня звать {FirstName} {Name} {LastName}");
        }
    }

    class Student : Person // Создаём класс Student и наследуем данные из класса Person
    { 
       public int Id { get; set; } //Добавляем новое свойство
        public int Age //Добавляем новое свойство
        {
            get
            {
                return Age;
            }
            set
            {
                if (value < 18 || value > 30) // Выполняем проверку на возрост с помощью свойства //или
                {
                    Console.WriteLine("Недопустимый возраст для студента");
                }
                else
                {
                    Console.WriteLine("Студент");
                }
            }
        }
            
            
       public int group { get; set; }//Добавляем новое свойство
        public override void Write() //переопределние метод с родительского класса
        {
            Console.WriteLine($"Привет!!! Меня звать {FirstName} {Name} {LastName}. Мой номер {Id}. Я учусь в группе {group}");
        }
    } 
    internal class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            int a = r.Next(); //рандом для генерации ID
            Student s = new Student() {Name = "Михаил", LastName = "Петрович", FirstName = "Зубенко", group = 228, Id = a }; //присваиваем полям значения
            s.Write(); // вызов метода с класса Student
            Console.WriteLine("Введите возраст");
            s.Age = Convert.ToInt32(Console.ReadLine()); //присваение полю Age значения
            Console.ReadKey();
            
        }
    }
}
