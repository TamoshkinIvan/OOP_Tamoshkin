using System;
using System.Text.RegularExpressions;

namespace ClassLibrary1
{
    /// <summary>
    /// Class Person
    /// </summary>
    public class Person
    {
        /// <summary>
        /// Person name
        /// </summary>

        private string _name;
        
        /// <summary>
        /// Person surname
        /// </summary>

        private string _surname;
        
        /// <summary>
        /// Person gender
        /// </summary>

        private PersonGender _gender;

        /// <summary>
        /// Person age
        /// </summary>

        private int _age;

        /// <summary>
        /// Person age
        /// </summary>
        public int Age
        {
            get => _age;
            set
            {
                if (value > 120 || value <= 0)
                {
                    throw new ArgumentException(("Invalid value, try again"));

                }
                _age = value;
            }
        }

        /// <summary>
        /// Person name 
        /// </summary>
        public string Name
        {
            get => _name;

            set
            {
                if (!InputCheck(value) || SpaceCheck(value))
                {
                    throw new ArgumentException("Invalid value, try again");
                }

                _name = value;
            }
        }

        /// <summary>
        /// Person name 
        /// </summary>
        public string Surname
        {
            get => _surname;

            set
            {

                if (!InputCheck(value) || SpaceCheck(value))
                {
                    throw new ArgumentException("Invalid value, try again");
                }
                _surname = value;
            }
        }

        /// <summary>
        /// Person gender
        /// </summary>
        public PersonGender Gender { get; set;  }



        /// <summary>
        /// Create person instance 
        /// </summary>
        /// <param name="gender">Person gender</param>
        /// <param name="age">Person age</param>
        /// <param name="name">Person name</param>
        /// <param name="surname">Person surname</param>
        
        public Person( string name, string surname, int age, PersonGender gender)
        {
            Name = name;
            Gender = gender;
            Age = age;
            Surname = surname;
            
        }

        /// <summary>
        /// Default constructor
        /// </summary>
        public  Person() : this("Ivan", "Tamoshkin", 23, PersonGender.Male)
        {}





        /// <summary>
        /// 
        /// </summary>
        /// <param name="checkString"></param>
        /// <returns></returns>
        public bool InputCheck(string checkString)
        {
            return Regex.IsMatch(checkString.ToLower(),
                @"(^[a-z]+[-]?[a-z]+$)|(^[а-я]+[-]?[а-я]+$)|(^[a-zа-я]$)");
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="checkString"></param>
        /// <returns></returns>
        public bool SpaceCheck(string checkString)
        {
            return Regex.IsMatch(checkString, @" ");
        }


    }
}
