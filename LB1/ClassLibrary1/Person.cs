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

        //TODO:
        /// <summary>
        /// Person age
        /// </summary>

        public const int MaxAge = 120;
        public const int MinAge = 0;


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
            Gender = gender;
            Age = age;
            Surname = surname;
        }

        /// <summary>
        /// Default person
        /// </summary>
        public Person() : this("Ivan", "Tamoshkin", 56, PersonGender.Male)
        {}


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
        /// 
        /// </summary>
        /// <returns></returns>
        public static Person GetRandomPerson()
        {
            Random rnd = new Random();

            //TODO: RSDN
            string[] Names =
            {
                "Alex", "Joe", "Ashley",
                "Casey", "Jordan", "Taylor"
            };

            //TODO: RSDN
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

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public Language CheckLanguage(string text)
        {
            //TODO: naming
            bool rus = false;
            bool eng = false;

            text = text.ToLower();

            foreach (char c in text)
            {
                if ((c >= 'а' && c <= 'я'))
                {
                    rus = true;
                }
                else if ((c >= 'a' && c <= 'z'))
                {
                    eng = true;
                }
                else if (c == '-') { }
                else
                {
                    eng = true;
                    rus = true;
                }
            }

            //TODO:
            if (eng & !rus) return Language.English;
            if (rus & !eng) return Language.Russian;
            return Language.Other;
        }
    }
}
