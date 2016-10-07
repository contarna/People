using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace People
{
    class People :DictionaryBase
    {
        public void Add(string newName, Person newPerson)
        {
            Dictionary.Add(newName, newPerson);
        }

        public void Remove(string newName)
        {
            Dictionary.Remove(newName);
        }

        public Person this[string newName]
        {
            get { return (Person)Dictionary[newName]; }
            set { Dictionary[newName] = value; }
        }
    }
}
