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
        /// Add a new person in list
        /// </summary>
        /// <param name="person"></param>
        public void AddPerson(Person person)
        {
            int lengthArray = _persons.Length;
            Array.Resize(ref _persons, lengthArray + 1);
            _persons[lengthArray] = person;

        }

        /// <summary>
        /// Delete the last person in list
        /// </summary>
        public void DeleteLastPerson()
        {
            int lengthArray = _persons.Length;
            if (lengthArray != 0)
            {
                Array.Resize(ref _persons, lengthArray - 1);
            }
        }

        /// <summary>
        /// Get person by index
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public Person SearchByIndex(int index)
        {
            return _persons[index];
        }

        /// <summary>
        /// Get index by name
        /// </summary>
        /// <param name="person"></param>
        /// <returns></returns>
        public int SearchByName(Person person)
        {
            return Array.IndexOf(_persons, person);
        }

        /// <summary>
        /// Clear the list
        /// </summary>
        public void ClearList()
        {
            Array.Resize(ref _persons, 0);
        }

        /// <summary>
        /// Delete element by index 
        /// </summary>
        /// <param name="index"></param>
        public void DeleteByIndex( int index)
        {
           _persons = _persons.Where((_,indexArray) => index != indexArray).ToArray();
        }
        
        /// <summary>
        /// Display persons information
        /// </summary>
        /// <returns></returns>
        public string Info()
        {
            string strInfo = "";
            foreach (Person person in _persons)
            {
                strInfo += "\n" + person.GetPersonInfo();
            }

            return strInfo;
        }
    }
}