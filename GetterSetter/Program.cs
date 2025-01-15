using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetterSetter
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.Name = "Ádám";
            Console.WriteLine(person.Name);

            person.Id = 99;
            Console.WriteLine(person.Id);

            Console.ReadKey();
        }
    }
    
    class Person
    {
        public Person() { }

        public string Name { get; set; }

        private int id;

        public int Id { get => id; set => id = 101; }

        private int age;

        public void setAge(int age) { this.age = age; }

        public int getAge() { return this.age; }

        private int gender;

        public string getGender()
        {
            switch(this.gender)
            {
                case 1: return "Férfi";
                case 2: return "Nő";
                default: return "Ismeretlen";
            }
        }
    }
}
