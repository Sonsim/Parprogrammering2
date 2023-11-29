using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parprogrammering2
{
    internal class PersonListe
    {

        List<Person> personList = new List<Person>();


        public void addPerson(Person person)
        {
            personList.Add(person);
        }
        public void showall()
        {
            foreach (Person person in personList)
            {
                Console.WriteLine();
                person.ShowPerson();
                Console.WriteLine();
            }
        }
    }
}
