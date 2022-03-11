﻿using System;
using System.Collections.Generic;
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

            var personList1 = new PersonList();

            var personList2 = new PersonList();

            var personList3 = new PersonList();

            personList2.DeleteLastPerson();

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

            Console.WriteLine("Person with index 0 added to list 1");
            Console.WriteLine("Person list 1");
            PrintPersonList(personList1);
            Console.WriteLine("Person list 2");
            PrintPersonList(personList2);

            personList1.DeleteByIndex(0);
            Console.WriteLine("Person list 1");
            PrintPersonList(personList1);

            Console.WriteLine("Person with index 1 deleted\n");

            personList1.ClearList();
            Console.WriteLine("Person list 1");
            PrintPersonList(personList1);
            Console.WriteLine("Person list 1 removed");

            var inputPerson =  ReadPerson();
            personList3.AddPerson(inputPerson);
            
            PrintPersonList(personList3);
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
        /// Inter person from console
        /// </summary>
        /// <returns>Instance person</returns>
        private static Person ReadPerson()
        {
            var defaultPerson = new Person( 10, PersonGender.Female);
            var actionsTupleList = new List<(Action Action, string Message)>
            {
                (
                    () =>
                    {
                        defaultPerson.Name = Console.ReadLine();
                    },
                    "Enter name of person:"),
                (
                    () =>
                    {
                        defaultPerson.Surname = Console.ReadLine();
                    },
                    "Enter surname of person:"),
                (
                    () =>
                    {
                        defaultPerson.Age =
                            Convert.ToInt32(Console.ReadLine());
                    },
                    "Enter age of person:"),
                (
                    () =>
                    {
                        int gender = Convert.ToInt32(Console.ReadLine());
                        switch (gender)
                        {
                            case 1:
                            {
                                defaultPerson.Gender = PersonGender.Male;
                                return;
                            }
                            case 2:
                            {
                                defaultPerson.Gender = PersonGender.Female;
                                return;
                            }
                            case 3:
                            {
                                defaultPerson.Gender = PersonGender.Unknown;
                                return;
                            }

                            default:
                            {
                                throw new ArgumentException
                                    ("Please enter 1 or 2");
                            }
                        }
                    },
                    "Choose gender of person." +
                    "Enter 1 for male or 2 for female and 3 for unknown gender")
            };

            foreach (var actionTuple in actionsTupleList)
            {
                ActionHandler(actionTuple.Action, actionTuple.Message);
            }

            return defaultPerson;
        }

        /// <summary>
        /// Handler of enter person from console
        /// </summary>
        /// <param name="action">Executable action</param>
        /// <param name="inputMessage">Message to action</param>
        private static void ActionHandler(Action action, string inputMessage)
        {
            while (true)
            {
                Console.WriteLine(inputMessage);
                try
                {
                    action.Invoke();
                    return;
                }
                catch (Exception e)
                {
                    if (e is ArgumentException
                        || e is FormatException)
                    {
                        Console.WriteLine(e.Message);
                        Console.WriteLine("Try again!");
                    }
                    else
                    {
                        throw;
                    }
                }
            }
        }
    }
}