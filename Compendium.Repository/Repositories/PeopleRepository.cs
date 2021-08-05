using System.Linq;
using Compendium.Repository.Models;

namespace Compendium.Repository
{
    public class PeopleRepository : IPeopleRepository
    {
        private readonly CompendiumContext _context;

        public PeopleRepository(CompendiumContext context)
        {
            _context = context;
        }

        public void AddPerson(People person)
        {
            _context.People.Add(person);
        }

        public People GetPerson(string firstName, string surname)
        {
            var person = _context.People.FirstOrDefault(p =>
                p.FirstName.ToLower() == firstName.ToLower()
                && p.Surname.ToLower() == surname.ToLower());

            return person;
        }

        public People GetPerson(int id)
        {
            var person = _context.People.FirstOrDefault(p => p.Id == id);

            return person;
        }
    }
}
