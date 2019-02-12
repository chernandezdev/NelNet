using System;
using Newtonsoft.Json;
using System.Linq;
using System.Collections.Generic;

namespace PetMatcher
{
    public class PersonRoot
    {
        public Person[] People { get; set; }

        public PersonRoot CreatePeople(string json)
        {
            return JsonConvert.DeserializeObject<PersonRoot>(json);
        }

    }
    public class Person
    {
        public string Name { get; set; }
        public string[] PreferredClassifications { get; set; }
        public string[] PreferredTypes { get; set; }
    }
}
