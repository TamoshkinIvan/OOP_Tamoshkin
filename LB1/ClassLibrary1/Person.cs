using System;
using System.Data;
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

        public const int MaxAge = 120;
        public  int MinAge = 0;
        public int Age
        {
            get => _age;
            set
            {
                //TODO: to const (+)
                if (value > MaxAge || value <= MinAge)
                {
                    throw new ArgumentException(("Please enter an age in range" +
                                                 $"between {MinAge} and {MaxAge}"));

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
            
            //TODO: дубль (+)
            set => _name = StringControl(value);

        }



        /// <summary>
        /// Person name 
        /// </summary>
        public string Surname
        {
            get => _surname;
            //TODO: дубль (+)
            set => _surname = StringControl(value);
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
        /// Detect space in string
        /// </summary>
        /// <param name="checkString"></param>
        /// <returns></returns>
        public bool SpaceCheck(string checkString)
        {
            //Regex.IsMatch(checkString, @" ");
            //TODO(+):
            return checkString.Contains(" ");
        }

        /// <summary>
        /// Check input string for errors
        /// </summary>
        /// <param name="checkString"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentException"></exception>
        public string StringControl(string checkString)
        {
            if (!InputCheck(checkString) || SpaceCheck(checkString))
            {
                throw new ArgumentException("Invalid value, try again");
            }
            return checkString;

        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static Person GetRandomPerson()
        {
            Random rnd = new Random();

            string[] Names =
            {
                "Alex", "Joe", "Ashley",
                "Casey", "Jordan", "Taylor"
            };

            string[] Surnames =
            {
                "Jones", "Tramp", "Phillips",
                "Kill", "Black", "Freeman"
            };

            int rndAge = rnd.Next(MaxAge);
            int rndGender = rnd.Next(Names.Length);

            if (rndGender % 2 == 0)
            {
                return new Person(Names[rnd.Next(Names.Length)],
                    Surnames[rnd.Next(Surnames.Length)], rndAge, PersonGender.Male);
            }

            return new Person(Names[rnd.Next(Names.Length)],
                Surnames[rnd.Next(Surnames.Length)], rndAge, PersonGender.Female);

        }

        /// <summary>
        /// Get person info 
        /// </summary>
        /// <returns></returns>

        public string GetPersonInfo()
        {
            return $"{this._name} {this._surname} {this._age} {this.Gender}";
        }
    }
}
