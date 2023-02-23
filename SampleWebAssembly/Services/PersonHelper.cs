using SampleBlazorWebAssembly.Models;

namespace SampleBlazorWebAssembly.Services
{
    public static class PersonHelper
    {
        public static IEnumerable<Person> GetPeople()
        {
            List<string> names = new List<string>
            {
                "John", "Jane", "David", "Mary", "Sarah",
                "William", "Emily", "James", "Olivia", "Jacob",
                "Emma", "Michael", "Sophia", "Ethan", "Isabella",
                "Benjamin", "Mia", "Daniel", "Ava", "Matthew"
            };

            Random random = new Random();

            List<Person> people = new List<Person>();

            for (int i = 0; i < 1000; i++)
            {
                string name = names[random.Next(names.Count)];
                DateOnly birthdate = new DateOnly(random.Next(1950, 2010), random.Next(1, 13), random.Next(1, 29));
                Person person = new Person(i + 1, name, birthdate);
                people.Add(person);
            }
            return people;
        }
    }
}
