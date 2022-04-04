using System;
using System.Collections.Generic;

namespace ClassLibrary1
{
    /// <summary>
    /// Class adult
    /// </summary>
    public class Adult : PersonBase
    {
        /// <summary>
        /// PersonBase passport serial number
        /// </summary>
        private int _passportSerialNumber;

        /// <summary>
        /// Adult age
        /// </summary>
        public const int AdultAge = 18;

        /// <summary>
        /// PersonBase job
        /// </summary>
        private string _personJob;
        
        /// <summary>
        /// Maximal passport serial number
        /// </summary>
        public const int MaxPassportSerialNumber = 9999;
        
        /// <summary>
        /// Minimal passport serial number
        /// </summary>
        public const int MinPassportSerialNumber = 0;
        
        /// <summary>
        /// Minimal passport Id
        /// </summary>
        public const int MinPassportId = 0;

        /// <summary>
        /// Maximum passport ID
        /// </summary>
        public const int MaxPassportId = 999999;

        /// <summary>
        /// PersonBase passport number
        /// </summary>
        private int _passportId;

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
            get => _passportSerialNumber;
            set
            {
                if (value < MinPassportSerialNumber || value > MaxPassportSerialNumber)
                {
                    //TODO: RSDN+
                    throw new ArgumentException(
                        "Please enter passport SN in range" +
                        $"between {MinPassportSerialNumber} and {MaxPassportSerialNumber}"
                        );
                }
                _passportSerialNumber = value;
            }
        }

        /// <summary>
        /// PersonBase passport number
        /// </summary>
        public int PassportID 
        { 
            get => _passportId; 
            set
            {
                if (value < MinPassportId || value >= MaxPassportId)
                {
                    throw new ArgumentException("Please enter passport ID in range" +
                                                $"between {MinPassportId} and {MaxPassportId}");
                }
                _passportId = value;
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

        //TODO: XML +
        /// <summary>
        /// Adult person instance constructor
        /// </summary>
        /// <param name="passportSerialNumber">Person passport serial number</param>
        /// <param name="passportId">Person passport id</param>
        /// <param name="name">Person name</param>
        /// <param name="surname">Person surname</param>
        /// <param name="age">Person age</param>
        /// <param name="gender">Person gender</param>
        /// <param name="familyStatus">Person family status</param>
        /// <param name="personJob">person job</param>
        /// <param name="partnerName">Person partner name</param>
        /// <param name="partnerSurname">Person partner surname</param>
        public Adult(int passportSerialNumber, 
            int passportId, string name, 
            string surname, int age,
            PersonGender gender, FamilyStatus familyStatus, 
            string personJob, string partnerName, string partnerSurname) 
            : this(passportSerialNumber, passportId,name, 
                surname, age, gender, familyStatus, personJob)
        {
            PartnerName = partnerName;
            PartnerSurname = partnerSurname;
        }

        /// <summary>
        /// Instance for console input
        /// </summary>
        /// <param name="passportSerialNumber"></param>
        /// <param name="passportId"></param>
        /// <param name="name"></param>
        /// <param name="surname"></param>
        /// <param name="age"></param>
        /// <param name="gender"></param>
        /// <param name="familyStatus"></param>
        /// <param name="personJob"></param>
        public Adult(int passportSerialNumber, int passportId, string name,string surname ,
            int age, PersonGender gender, FamilyStatus familyStatus, string personJob) 
            : base(name, surname, gender,age)
        {
            PassportSerialNumber = passportSerialNumber;
            PassportID = passportId;
            FamilyStatus = familyStatus;
            PersonJob = personJob;
        }

        /// <summary>
        /// Default constructor
        /// </summary>
        public Adult() : this(666, 666, "John",
            "Wick", 35, PersonGender.Female, FamilyStatus.Widow, "Killer")
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
        /// Get random person
        /// </summary>
        /// <returns></returns>
        public static Adult GetRandomPerson(Random rnd)
        {
           var familyStatus = new Dictionary<int, FamilyStatus>
           {
                     {0, FamilyStatus.Divorced},
                     {1, FamilyStatus.Married},
                     {2, FamilyStatus.Widow},
                     {3, FamilyStatus.Unmarried}
                 };

            var getFamilyStatus = familyStatus[rnd.Next(3)];
            var rndGender = rnd.Next(1);
            return GetAdult(getFamilyStatus, rndGender);
        }

        /// <summary>
        /// Get Adult person
        /// </summary>
        /// <param name="familyStatus"></param>
        /// <param name="gender"></param>
        /// <returns></returns>
        public static Adult GetAdult(FamilyStatus familyStatus, int gender)
        {
            var rnd = new Random();
            var names = new Dictionary<int, List<string>>()
            {
                {
                    1, new List<string> {"Alex", "John", "Nikolas", "Piter"}

                },
                {
                    0, new List<string> { "Maria", "Rosa", "Kasandra", "Germiona" }

                }
            };
            string[] surnames =
            {
                "Jones", "Tramp", "Phillips",
                "Kill", "Black", "Freeman"
            };
            string[] jobList =
            {
                "Driver", "Teacher", "Hostess", "Flight attendant", "Waiter",
                "Interpreter", "Entrepreneur", null , "KremleBot", "Killer"
            };
            var genderDictionary = new Dictionary<int, PersonGender>
            {
                {0, PersonGender.Female},
                {1, PersonGender.Male}
            };

            
            var rndSurname = surnames[rnd.Next(surnames.Length)];
            var rndJob = jobList[rnd.Next(jobList.Length)];
            var name = names[gender][rnd.Next(names[gender].Count)];
            var genderAbs = Math.Abs(gender - 1);
            var partnerName = names[genderAbs][rnd.Next(names[genderAbs].Count)];
            var personGender = genderDictionary[gender];
            var passportSerialNumber = rnd.Next(MaxPassportSerialNumber);
            var passportId = rnd.Next(MaxPassportId);

            //TODO:  +
            if (familyStatus != FamilyStatus.Married)
            {
                return new Adult
                (
                    passportSerialNumber, passportId, name, rndSurname,
                    rnd.Next(AdultAge, MaxAge),
                    personGender, familyStatus, rndJob
                    );
            }
            return new Adult
            (
                passportSerialNumber, passportId, name, rndSurname,
                rnd.Next(AdultAge, MaxAge),
                personGender, familyStatus, rndJob,
                partnerName, rndSurname
                );

        }

        /// <summary>
        /// Get information about an adult person
        /// </summary>
        /// <returns></returns>
        protected internal override string GetPersonInfo()
        {
            var inf = $"\nName: {Name};  Surname: {Surname};" +
                      $"\nAge: {_age} years;  Gender: {Gender}; Job: {PersonJob}" +
                      $"\nPassport Serial Number: {_passportSerialNumber}; PassportId: {_passportId};" +
                      $"\nFamily Status: {FamilyStatus};";
            if (FamilyStatus == FamilyStatus.Married)
            {
                inf = $"{inf}" +
                      $"\nPartner Name: { _partnerName}; Partner Surname: { _partnerSurname}; " +
                      "\n";
            }
            return inf;
        }

        /// <summary>
        /// Adult method
        /// </summary>
        public void GetOlder()
        {
            Console.WriteLine("Take a loan");
        }
    }
}
