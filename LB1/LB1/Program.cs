using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;


namespace LB1
{
    /// <summary>
    /// Class Program
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// Entry point of application
        /// </summary>
        /// <param name="args"></param>
        private static void Main(string[] args)
        {
            var personList1 = new PersonList();

            var personList2 = new PersonList();

            try
            {
                var person1 = new Person("Ivan", "Tamoshkin",
                    100, PersonGender.Male);
                personList1.AddPerson(person1);
            }
            catch (AggregateException e)
            {
                Console.WriteLine(e.Message);
            }

            var person = Person.GetRandomPerson();

            personList1.AddPerson(person);

            try
            {
                personList2.AddPerson(personList1.SearchByIndex(1));
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
            }

            PrintPersonList(personList1);
            PrintPersonList(personList2);


            Console.ReadKey();


        }
        
        
        private static void PrintPersonList(PersonList personList)

        {
            Console.WriteLine("\n////////////");
            Console.WriteLine(personList.Info());
            Console.WriteLine("\n////////////");

        }
        
    }
}
