using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace LabClasses
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
            get
            {
                return _age;
            }
            set
            {
                if (value > 100 || value <= 0)
                {
                    throw new ArgumentException(string.Format("Invalid value, try again"));

                }
                _age = value;
            }
        }

        /// <summary>
        /// Person name 
        /// </summary>
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {

                _name = value;
            }
        }

        /// <summary>
        /// Person gender
        /// </summary>
        public PersonGender Gender
        {
            get
            {
                return _gender;
            }
            set
            {
                _gender = value;
            }
        }

        /// <summary>
        /// Create person instance 
        /// </summary>
        /// <param name="gender">Person gender</param>
        /// <param name="age">Person age</param>
        /// <param name="name">Person name</param>
        /// <param name="surname">Person surname</param>
        
        public Person(PersonGender gender, int age, string name, string surname)
        {
            _name = name;
            _gender = gender;
            _age = age;
            _surname = surname;
            
        }


    }
}
