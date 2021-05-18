using Compendium.Repository.Models;

namespace Compendium.Repository
{
    public interface IPeopleRepository
    {
        void AddPerson(People person);
        People GetPerson(string firstName, string surname);
        People GetPerson(int id);
    }
}