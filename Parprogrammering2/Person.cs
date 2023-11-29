using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parprogrammering2
{
    internal class Person
    {
        private string _name;
        private int _age;
        private string _gender;
        private string _hobby;
        private string _hobby2;
        private string _haircolor;
        private int _height;
        private string _address;


        public Person(string Name, int Age, string Gender, string Hobby, string Hair, int Height, string Address)
        {
            _name = Name;
            _age = Age;
            _gender = Gender;
            _hobby = Hobby;
            _haircolor = Hair;
            _height = Height;
            _address = Address;

        }
        public Person(string Name, int Age, string Gender, string Hobby, string Hobby2, string Hair, int Height, string Address)
        {
            _name = Name;
            _age = Age;
            _gender = Gender;
            _hobby = Hobby;
            _hobby2 = Hobby2;
            _haircolor = Hair;
            _height = Height;
            _address = Address;

        }

        public static void CreatePerson()
        {
            Console.WriteLine($"Hva heter du?");
            var name = Console.ReadLine();

            Console.WriteLine($"Hvor gammel er du?");
            var age = Console.ReadLine();

            Console.WriteLine($"Hvilke kjønn er du?");
            var gender = Console.ReadLine();

            Console.WriteLine($"Hva liker du å gjøre på fritiden?");
            var hobby1 = Console.ReadLine();

            Console.WriteLine($"Hva slags hårfarge har du?");
            var hair = Console.ReadLine();

            Console.WriteLine($"Hvor bor du?");
            var adress = Console.ReadLine();

            Console.WriteLine("Hvor høy er du?");
            int height = Convert.ToInt32(Console.ReadLine());


            var person = new Person($"{name}", Convert.ToInt32($"{age}"), $"{gender}", $"{hobby1}", $"{hair}", Convert.ToInt32($"{height}"), $"{adress}");
            person.ShowPerson();

        }


        public void ShowPerson()
        {
            Console.WriteLine($"Hei, jeg heter {_name} og jeg her en {_age} gammel {_gender}");
            Console.WriteLine($"Jeg har {_haircolor} hår, er {_height}cm høy og bor {_address}");
            Console.WriteLine($"{_hobby}");
            Console.WriteLine($"{_hobby2}");
        }
    }
}
