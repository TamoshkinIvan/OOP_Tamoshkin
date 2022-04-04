using System;
using System.Collections.Generic;

namespace ClassLibrary1
{
    /// <summary>
    /// Class child 
    /// </summary>
    public class Child : PersonBase
    {
        /// <summary>
        /// Child age
        /// </summary>
        private int _age;

        /// <summary>
        /// Max child age
        /// </summary>
        public const int ChildAge = 18;

        /// <summary>
        /// Mother name
        /// </summary>
        private string _motherName;

        /// <summary>
        /// Father name
        /// </summary>
        private string _fatherName;
        
        /// <summary>
        /// Mother name validation
        /// </summary>
        public string MotherName
        {
            get => _motherName;
            set
            {
                if (_motherName != null)
                {
                    _motherName = StringControl(value);
                }
                _motherName = value;
            }

        }
        
        /// <summary>
        /// Father name validation
        /// </summary>
        public string FatherName
        {
            get => _fatherName;
            set
            {
                if (_fatherName != null)
                {
                    _fatherName = StringControl(value);
                }
                _fatherName = value;
            }
        }
        
        /// <summary>
        /// Child age
        /// </summary>
        public override int Age
        {
            get => _age;
            set
            {
                if (value < MinAge || value > ChildAge)
                {
                    throw new ArgumentException(("Please enter an age in range" +
                                                 $"between {MinAge} and {ChildAge}"));
                }
                _age = value;
            }
        }
        /// <summary>
        /// Child kinder garden name
        /// </summary>
        public string KinderGardenName { get; set; }

        /// <summary>
        /// Constructor of child instance
        /// </summary>
        /// <param name="name"></param>
        /// <param name="surname"></param>
        /// <param name="age"></param>
        /// <param name="gender"></param>
        /// <param name="motherName"></param>
        /// <param name="fatherName"></param>
        /// <param name="kinderGardenName"></param>
        public Child(string name, string surname, int age, PersonGender gender,
            string motherName, string fatherName, string kinderGardenName)
            : base(name, surname, gender, age)
        {
            FatherName = fatherName;
            MotherName = motherName;
            KinderGardenName = kinderGardenName;
        }

        /// <summary>
        /// Get child 
        /// </summary>
        /// <returns></returns>
        public static Child GetRandomPerson(Random rnd)
        {
            var names = new Dictionary<int, List<string>>()
            {
                {
                    1, new List<string> {"Alphonso", "Giovanni", "Buratino", "Hussein" }
                },
                {
                    0, new List<string> { "Maria", "Rosa", "Kassandra", "Hermione" }
                }
            };
            string[] surnames =
            {
                "Jones", "Tramp", "Phillips",
                "Kill", "Black", "Freeman"
            };
            var genderDictionary = new Dictionary<int, PersonGender>
            {
                {0, PersonGender.Female},
                {1, PersonGender.Male}
            };
            string[] kinderGardenList =
            {
                "Sunny","Cloudy","Happy","Mally","Candy"
            };
            var rndMaleNames = names[1][rnd.Next(names[1].Count)];
            var rndFemaleNames = names[0][rnd.Next(names[0].Count)];
            var rndGender = rnd.Next(1);
            var rndParent = rnd.Next(2);
            var name = names[rndGender][rnd.Next(names[rndGender].Count)];
            var rndSurname = surnames[rnd.Next(surnames.Length)];
            var childGender = genderDictionary[rndGender];
            var kinderGardenName = kinderGardenList[rnd.Next(kinderGardenList.Length)];
            string motherName = null;
            string fatherName = null;
            //TODO: +
            switch (rndParent)
            {
                // Child has no mother.
                case 0:
                    fatherName = rndMaleNames;
                    break;
                // Child has no father
                case 1:
                    motherName = rndFemaleNames;
                    break;
                // Child has mother and father 
                case 2:
                    motherName = rndFemaleNames;
                    fatherName = rndMaleNames;
                    break;
            }

            return new Child(name, rndSurname, rnd.Next(MinAge, ChildAge), childGender,
                motherName, fatherName, kinderGardenName);
        }
        
        /// <summary>
        /// Get information about a child
        /// </summary>
        /// <returns></returns>
        protected internal override string GetPersonInfo()
        {
            var info = $"\nName: {Name}; Surname: {Surname};" +
                       $"\nAge: {Age}; Gender: {Gender}; ";
            if (MotherName != null)
            {
                info = $"{info}\nMother: {MotherName} {Surname};";
            }
            if (FatherName != null)
            {
                info = $"{info}\nFather: {FatherName} {Surname};";
            }

            info = $"{info}\nKindergarten: {KinderGardenName};";
            return info;
        }

        /// <summary>
        /// Child method
        /// </summary>
        public void GetYounger()
        {
            Console.WriteLine("Get vape.");
        }

    }
}
