using System;
using System.Linq;

namespace ClassLibrary1
{
    /// <summary>
    /// Class person list
    /// </summary>
    public class PersonList
    {
        /// <summary>
        /// PersonBase array
        /// </summary>
        private PersonBase[] _persons = new PersonBase[0];
        
        /// <summary>
        /// Add a new personBase in list
        /// </summary>
        /// <param name="personBase"></param>
        public void AddPerson(PersonBase personBase)
        {
            int lengthArray = _persons.Length;
            Array.Resize(ref _persons, lengthArray + 1);
            _persons[lengthArray] = personBase;

        }

        /// <summary>
        /// Delete the last personBase in list
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
        /// Get personBase by index
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public PersonBase SearchByIndex(int index)
        {
            return _persons[index];
        }

        /// <summary>
        /// Get index by name
        /// </summary>
        /// <param name="personBase"></param>
        /// <returns></returns>
        public int SearchByName(PersonBase personBase)
        {
            return Array.IndexOf(_persons, personBase);
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
            var strInfo = "";
            foreach (PersonBase person in _persons)
            {
                strInfo += "\n" + person.GetPersonInfo();
            }
            return strInfo;
        }

        public void AddPerson((Action Action, string Message) createPerson)
        {
            throw new NotImplementedException();
        }
    }
}