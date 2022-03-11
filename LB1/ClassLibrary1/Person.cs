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
        /// Person age
        /// </summary>
        private int _age;

        /// <summary>
        /// Max person age
        /// </summary>
        public const int MaxAge = 120;
        
        /// <summary>
        /// min person age
        /// </summary>
        public const int MinAge = 0;
        
        /// <summary>
        /// Person age
        /// </summary>
        public int Age
        {
            get => _age;
            set
            {
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
            set => _name = StringControl(value);
        }

        /// <summary>
        /// Person name 
        /// </summary>
        public string Surname
        {
            get => _surname;
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
            Age = age;
            Surname = surname;
            Gender = gender;
        }

        /// <summary>
        /// Default person
        /// </summary>
        public Person() : this("Ivan", "Tamoshkin", 56, PersonGender.Male)
        {}

        /// <summary>
        /// Instance for console input 
        /// </summary>
        /// <param name="age"></param>
        /// <param name="gender"></param>
        public Person( int age, PersonGender gender)
        {
            Age = age;
            Gender = gender;
        }

        /// <summary>
        /// Detect space in string
        /// </summary>
        /// <param name="checkString"></param>
        /// <returns></returns>
        public bool SpaceCheck(string checkString)
        {
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
            if ( SpaceCheck(checkString))
            {
                throw new ArgumentException("There a space in the entered string.\n" +
                                            " Please enter without spaces. ");
            }
            
            if (CheckLanguage(checkString) == Language.Other)
            {
                throw new ArgumentException("The person name and surname " +
                                            "should be in russian or english and without digits.");
            }

            if (_name != null && CheckLanguage(checkString) != CheckLanguage(_name))
            {
                throw new ArgumentException("The person name and surname " +
                                            "should be in the same language.");
            }

            if (checkString == null)
            {
                throw new ArgumentException("Entered value is empty. \n" +
                                            "Please enter your name or surname.");
            }

            return checkString;

        }
        /// <summary>
        /// Get random person 
        /// </summary>
        /// <returns></returns>
        public static Person GetRandomPerson()
        {
            Random rnd = new Random();
            
            string[] names =
            {
                "Alex", "Joe", "Ashley",
                "Casey", "Jordan", "Taylor"
            };
            
            string[] surnames =
            {
                "Jones", "Tramp", "Phillips",
                "Kill", "Black", "Freeman"
            };

            int rndAge = rnd.Next(MaxAge);
            int rndGender = rnd.Next(names.Length);

            if (rndGender % 2 == 0)
            {
                return new Person(names[rnd.Next(names.Length)],
                    surnames[rnd.Next(surnames.Length)], rndAge, PersonGender.Male);
            }

            return new Person(names[rnd.Next(names.Length)],
                surnames[rnd.Next(surnames.Length)], rndAge, PersonGender.Female);

        }

        /// <summary>
        /// Get person info 
        /// </summary>
        /// <returns></returns>
        public string GetPersonInfo()
        {
            return $"{this._name} {this._surname} {this._age} {this.Gender}";
        }

        //TODO(+):
        /// <summary>
        /// Check string language
        /// </summary>
        /// <returns></returns>
        public Language CheckLanguage(string text)
        {
            bool isRus = false;
            bool isEng = false;

            text = text.ToLower();

            foreach (char c in text)
            {
                if ((c >= 'а' && c <= 'я'))
                {
                    isRus = true;
                }
                else if ((c >= 'a' && c <= 'z'))
                {
                    isEng = true;
                }
                else if (c == '-') { }
                else
                {
                    isEng = true;
                    isRus = true;
                }
            }
            
            if (isEng && !isRus) return Language.English;
            
            if (isRus && !isEng) return Language.Russian;
            
            return Language.Other;
        }
    }
}
