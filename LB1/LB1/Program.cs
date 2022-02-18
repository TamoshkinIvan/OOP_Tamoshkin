using System;
using System.Collections.Generic;
using System.Linq;
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

            try
            {
                var person1 = new Person("Ivan", "Tamoshkin",
                    130, PersonGender.Male);
                personList1.AddPerson(person1);
            }
            catch (AggregateException e)
            {
                Console.WriteLine(e.Message);
            }

        }
    }
}
