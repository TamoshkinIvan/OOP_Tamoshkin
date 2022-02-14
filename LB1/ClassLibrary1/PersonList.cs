using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    /// <summary>
    /// Class person list
    /// </summary>
    public class PersonList
    {
        /// <summary>
        /// Person array
        /// </summary>
        private Person[] _persons = new Person[0];

        /// <summary>
        /// Get person list length
        /// </summary>
        public int Length => _persons.Length;

        /// <summary>
        /// Add a new person in list
        /// </summary>
        /// <param name="person"></param>
        public void AddPerson(Person person)
        {

        }

    }
}
