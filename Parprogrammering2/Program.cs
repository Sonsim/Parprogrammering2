using System;

namespace Parprogrammering2
{
    internal class Program
    {
        static void Main()
        {
           
                var Sondre = new Person("Sondre", 30, "Mann", "Nå spiller jeg Tarkov", "Etterpå skal jeg gå tur i skogen med bikkja", "Brunt", 190, "i Rælingen");
                var list = new PersonListe();


                list.addPerson(Sondre);
                list.showall();

                Console.WriteLine("Vil du legge til en person? Y/N");
                var ans = Console.ReadLine();

                switch (ans)
                {
                    case "y":
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
                        var height = Console.ReadLine();


                        var person = new Person($"{name}", Convert.ToInt32($"{age}"), $"{gender}", $"{hobby1}", $"{hair}", Convert.ToInt32($"{height}"), $"{adress}");
                        list.addPerson(person);
                        list.showall();

                        break;
                    case "n":
                        System.Environment.Exit(0);
                        break;
                }
            }
        }
    }
