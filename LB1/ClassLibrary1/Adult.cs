using System;
using System.Collections.Generic;

namespace ClassLibrary1
{
    public class Adult : PersonBase
    {
        /// <summary>
        /// PersonBase passport serial number
        /// </summary>
        private int _passportSN;

        /// <summary>
        /// PersonBase job
        /// </summary>
        private string _personJob;

        /// <summary>
        /// Maximal passport sn
        /// </summary>
        public const int MaxPassporSN = 100000;

        /// <summary>
        /// Minimal passport sn
        /// </summary>
        public const int MinPassporSN = 0;

        /// <summary>
        /// Minimal passport ID
        /// </summary>
        public const int MinPassportID = 0;

        /// <summary>
        /// Maximum passport ID
        /// </summary>
        public const int MaxPassportID = 1000000;

        /// <summary>
        /// PersonBase passport number
        /// </summary>
        private int _passportID;

        /// <summary>
        /// PersonBase partner name
        /// </summary>
        private string _partnerName;

        /// <summary>
        /// PersonBase partner surname
        /// </summary>
        private string _partnerSurname;

        /// <summary>
        /// Adult person age
        /// </summary>
        private int _age;

        /// <summary>
        /// Adult person age
        /// </summary>
        public override int Age
        {
            get => _age;
            set
            {
                if (value > MaxAge || value < AdultAge)
                {
                    throw new ArgumentException(("Please enter an age in range" +
                                                 $"between {AdultAge} and {MaxAge}"));

                }
                _age = value;
            }
        }

        /// <summary>
        /// Person family status
        /// </summary>
        public FamilyStatus FamilyStatus { get; set; }

        /// <summary>
        /// Person job
        /// </summary>
        public string PersonJob
        {
            get => _personJob;
            set => _personJob = CheckJob(value);
        }

        /// <summary>
        /// PersonBase passport serial number
        /// </summary>
        public int PassportSerialNumber
        {
            get => _passportSN;
            set
            {
                if (value < MinPassporSN || value > MaxPassporSN)
                {
                    throw new ArgumentException("Please enter passport SN in range" +
                                                $"between {MinPassporSN} and {MaxPassporSN}");
                }
                _passportSN = value;
            }
        }

        /// <summary>
        /// PersonBase passport number
        /// </summary>
        public int PassportID 
        { 
            get => _passportID; 
            set
            {
                if (value < MinPassportID || value >= MaxPassportID)
                {
                    throw new ArgumentException("Please enter passport ID in range" +
                                                $"between {MinPassportID} and {MaxPassportID}");
                }
                _passportID = value;
            }
        }
        /// <summary>
        /// person partner name
        /// </summary>
        public string PartnerName
        {
            get => _partnerName;
            set => _partnerName = StringControl(value);
        }
        /// <summary>
        /// person partner surname
        /// </summary>
        public string PartnerSurname
        {
            get => _partnerSurname;
            set => _partnerSurname = StringControl(value);
        }

        /// <summary>
        /// Adult person instance constructor
        /// </summary>
        /// <param name="passportSerialNumber"></param>
        /// <param name="passportID"></param>
        /// <param name="name"></param>
        /// <param name="surname"></param>
        /// <param name="age"></param>
        /// <param name="gender"></param>
        /// <param name="personJob"></param>
        /// <param name="partnerName"></param>
        /// <param name="partnerSurname"></param>
        /// <param name="familyStatus"></param>
        public Adult(int passportSerialNumber, int passportID, string name,
            string surname, int age, PersonGender gender, FamilyStatus familyStatus, string personJob, 
            string partnerName, string partnerSurname) : base(name, surname, gender)
        {
            PassportSerialNumber = passportSerialNumber;
            PassportID = passportID;
            PartnerName = partnerName;
            PartnerSurname = partnerSurname;
            FamilyStatus = familyStatus;
            PersonJob = personJob;
            Age = age;
        }
        /// <summary>
        /// Instance for console input
        /// </summary>
        /// <param name="passportSerialNumber"></param>
        /// <param name="passportID"></param>
        /// <param name="age"></param>
        /// <param name="gender"></param>
        /// <param name="familyStatus"></param>
        /// <param name="personJob"></param>
        public Adult(int passportSerialNumber, int passportID, int age, PersonGender gender,
            FamilyStatus familyStatus, string personJob) : base(age, gender)
        {
            PassportSerialNumber = passportSerialNumber;
            PassportID = passportID;
            FamilyStatus = familyStatus;
            PersonJob = personJob;
        }
        /// <summary>
        /// 
        /// </summary>
        public Adult() : this(100, 120, "Boris", "Jonson",
            120, PersonGender.Female, FamilyStatus.Unmarried, null, "Alisa",
            "Petrol" )
        {}

        /// <summary>
        /// Check entered person job for null and if condition is true, return "Jobless"
        /// </summary>
        /// <param name="job"></param>
        /// <returns></returns>
        public string CheckJob(string job)
        {
            return job ?? "Jobless";
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static Adult GetRandomPerson()
        {
           Random rnd = new Random();
       
           string[] maleNames =
               { "Alex", "John", "Nikolas", "Pit"};
           string[] femaleNames =
               {"Maria", "Rosa", "Kasandra", "Germiona"};
           string[] jobList =
           {"Driver", "Teacher", "Hostess", "Flight attendant", "Waiter",
               "Interpreter", "Entrepreneur", null};


            var familyStatus = new Dictionary<int, FamilyStatus>()
           {
                {0, FamilyStatus.Divorced},
                {1, FamilyStatus.Married},
                {2, FamilyStatus.Widow},
                {3, FamilyStatus.Unmarried}
            };
            var personGender = new Dictionary<int, PersonGender>()
            {
                {0, PersonGender.Female},
                {1, PersonGender.Male},
                {2, PersonGender.Unknown}
            };

            int rndName = rnd.Next(maleNames.Length);
            int rndAge = rnd.Next(AdultAge, MaxAge);

            int rndMarried = rnd.Next(0, 3);
            int rndJob = rnd.Next(jobList.Length);

            PersonGender rndGender =  personGender[rnd.Next(2)];


            if (familyStatus[rndMarried] != FamilyStatus.Married)
            {
                return new Adult(rnd.Next(MaxPassporSN), rnd.Next(MaxPassportID),
                    rnd.Next(AdultAge, MaxAge),personGender[rnd.Next(2)], FamilyStatus.Divorced,
                    jobList[rnd.Next(jobList.Length)]);
            }

        }

    }
}
