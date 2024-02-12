using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    /// <summary>
    /// Название класса Сотрудник
    /// </summary>
    class Employee
    {
        /// <summary>
        /// Поле имени
        /// </summary>
        string name;
        /// <summary>
        /// Поле фамилии                                                                            
        /// </summary>
        string surname;
        /// <summary>
        /// Поле даты рождения
        /// </summary>
        DateTime dateBirth;
        /// <summary>
        /// Поле минимальной зарплаты
        /// </summary>
        int minimumWage;
        /// <summary>
        /// Свойства полей
        /// </summary>
        string Name { get => name; set => name = value; }
        string Surname { get => surname; set => surname = value; }
        DateTime DateBirth { get => dateBirth; set => dateBirth = value; }
        int MinimumWage { get => minimumWage; set => minimumWage = value; }
        /// <summary>
        /// Конструктор без параметров
        /// </summary>
        public Employee()
        {

        }
        /// <summary>
        /// Конструктор с параметрами
        /// </summary>
        /// <param name="name"></param>
        /// <param name="surname"></param>
        /// <param name="dateBirth"></param>
        /// <param name="minimumWage"></param>
        public Employee(string name, string surname, DateTime dateBirth, int minimumWage)
        {
            this.name = name;
            this.surname = surname;
            this.dateBirth = dateBirth;
            this.minimumWage = minimumWage;
        }
        public virtual void PrintInfo()
        {
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Surname: " + surname);
            Console.WriteLine("DateBirth: " + dateBirth);
            Console.WriteLine("MinimumWage: " + minimumWage);
        }
        /// <summary>
        /// Виртуальный метод, где k – повышающий коэффициент.
        /// </summary>
        public virtual double CalculateIncome(double k)
        {
            return k * minimumWage;
        }
    }
}
