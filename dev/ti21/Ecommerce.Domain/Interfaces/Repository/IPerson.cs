using Ecommerce.Domain.Models;

namespace Ecommerce.Domain.Interfaces.Repository
{
    public interface IPersonRepository
     {
        Task CreatePersonF(PersonF person);
        Task CreatePersonJ(PersonJ person);
        Task<IList<PersonF>> ReadPersonF();
        Task<IList<PersonJ>> ReadPersonJ();
        Task Update(Person person);
        Task Delete(Guid id);
        Task<Person> ReadById(Guid id);
    }
}