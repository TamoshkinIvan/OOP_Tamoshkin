using System;
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
            System.Console.OutputEncoding = System.Text.Encoding.Unicode;
            System.Console.InputEncoding = System.Text.Encoding.Unicode;

            var rnd = new Random();
            var personList1 = CreateList(rnd);
            PrintPersonList(personList1);

            var person = personList1.SearchByIndex(3);

            switch (person)
            {
                case Adult adult:
                    adult.GetOlder();
                    break;
                case Child child:
                    child.GetYounger();
                    break;
            }

            Console.ReadKey();
        }
        
        /// <summary>
        /// Print person list
        /// </summary>
        /// <param name="personList"></param>
        private static void PrintPersonList(PersonList personList)
        {
            Console.WriteLine("////////////");
            Console.WriteLine(personList.Info());
            Console.WriteLine("\n////////////\n");
        }

        /// <summary>
        /// Create random person list
        /// </summary>
        /// <param name="rnd"></param>
        /// <returns></returns>
        private static PersonList CreateList(Random rnd)
        {
            var personList1 = new PersonList();
            for (var i = 0; i <= 7; i++)
            {
                if (rnd.Next(2) == 1)
                {
                    personList1.AddPerson(Adult.GetRandomPerson(rnd));
                }
                personList1.AddPerson(Child.GetRandomPerson(rnd));
            }
            return personList1;

        }
    }
}