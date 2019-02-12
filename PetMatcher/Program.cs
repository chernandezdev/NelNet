using System;
using Newtonsoft.Json;
using System.Linq;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
namespace PetMatcher
{
    class Program
    {
        static void Main(string[] args)
        {
            PetRoot Pets = new PetRoot();
            PersonRoot People = new PersonRoot();
            //Map JSON to Person and Pet objects
            Parallel.Invoke
            (
               () => People = People.CreatePeople(Constants.jsonPeople),
               () => Pets = Pets.CreatePets(Constants.jsonPet)
            );
            getResults(People, Pets);
        }
        public static void getResults(PersonRoot people, PetRoot pets)
        {
            foreach (var person in people.People)
            {
                IList<MatchResult> results = new List<MatchResult>();
                results = getMatches(person, pets);
                Console.WriteLine("\nPets for " + person.Name + ":\n");
                printResults(results);
            }

        }
        public static void printResults(IList<MatchResult> results)
        {
            foreach (var result in results)
            {
                if (result.IsGoodPet)
                {
                    Console.WriteLine(result.PetName + " " + Constants.goodPet + "\n");
                }
                else
                {
                    Console.WriteLine(result.PetName + " " + Constants.badPet + "\n");
                }
            }

        }
        public static IList<MatchResult> getMatches(Person person, PetRoot pets)
        {
            IList<MatchResult> matchResults = new List<MatchResult>();
            foreach (var pet in pets.Pets)
            {
                if ((person.PreferredClassifications.Contains(pet.Classification)) || (person.PreferredTypes.Contains(pet.Type)))
                {
                    matchResults.Add(new MatchResult() { PetName = pet.Name, IsGoodPet = true });
                }
                else
                { matchResults.Add(new MatchResult() { PetName = pet.Name, IsGoodPet = false }); }
            }

            return matchResults;

        }
    }
}