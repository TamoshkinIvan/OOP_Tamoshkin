using System;
using System.Linq;

namespace ClassLibrary1
{
    /// <summary>
    /// Class PersonBase
    /// </summary>
    public  abstract class PersonBase
    {
        /// <summary>
        /// PersonBase name
        /// </summary>
        private string _name;
        
        /// <summary>
        /// PersonBase surname
        /// </summary>
        private string _surname;
        
        /// <summary>
        /// PersonBase age
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
        /// PersonBase age
        /// </summary>
        public abstract int Age { get; set; }

        /// <summary>
        /// PersonBase name 
        /// </summary>
        public string Name
        {
            get => _name;
            set => _name = StringControl(value);
        }

        /// <summary>
        /// PersonBase name 
        /// </summary>
        public string Surname
        {
            get => _surname;
            set => _surname = StringControl(value);
        }

        /// <summary>
        /// PersonBase gender
        /// </summary>
        public PersonGender Gender { get; set;  }

        /// <summary>
        /// Create person instance 
        /// </summary>
        /// <param name="gender">PersonBase gender</param>
        /// <param name="name">PersonBase name</param>
        /// <param name="surname">PersonBase surname</param>
        protected PersonBase( string name, string surname, PersonGender gender, int age)
        {
            Name = name;
            Surname = surname;
            Gender = gender;
            Age = age;
        }

        /// <summary>
        /// Instance for console input 
        /// </summary>
        /// <param name="age"></param>
        /// <param name="gender"></param>
        protected PersonBase( int age, PersonGender gender)
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

            if (CheckCapital(checkString))
            {
                throw new ArgumentException("First and last name must be capitalized. \n" +
                                            "Please enter a capitalized string.");
            }

            return checkString;

        }
        
        ///// <summary>
        ///// Get person info 
        ///// </summary>
        //// <returns></returns>
        protected internal abstract string GetPersonInfo();

        /// <summary>
        /// Check string language
        /// </summary>
        /// <returns></returns>
        public Language CheckLanguage(string text)
        {
            var isRus = false;
            var isEng = false;

            text = text.ToLower();

            foreach (var c in text)
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

        /// <summary>
        /// Check for capital letter 
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public bool CheckCapital(string text)
        {
            return text.Count(char.IsUpper) != 1 || char.IsLower(text, 0);
        }
    }
}
