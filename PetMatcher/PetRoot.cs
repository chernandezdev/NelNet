using System;
using Newtonsoft.Json;
using System.Linq;
using System.Collections.Generic;

namespace PetMatcher
{
    public class PetRoot
    {
        public Pet[] Pets { get; set; }
        public class Pet
        {
            public string Name { get; set; }
            public string Classification { get; set; }
            public string Type { get; set; }
        }
        public PetRoot CreatePets(string json)
        {
            return JsonConvert.DeserializeObject<PetRoot>(json);
        }
    }
}
