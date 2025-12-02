using Ecommerce.Domain.Interfaces.Repository;
using Ecommerce.Domain.Models;
using Ecommerce.Data;
using Microsoft.EntityFrameworkCore;

namespace Ecommerce.Domain.Repositories
{
    public class PersonRepository(DataContext _context) : IPersonRepository
    {
        public async Task CreatePersonF(PersonF person)
        {
            _context.PeopleF.Add(person);
            await _context.SaveChangesAsync();
        }

        public async Task CreatePersonJ(PersonJ person)
        {
            _context.PeopleJ.Add(person);
            await _context.SaveChangesAsync();
        }    

        public async Task Update(Person person)
        {
            _context.Update(person);
            await _context.SaveChangesAsync();
        }

        public async Task<IList<PersonF>> ReadPersonF() => await _context.PeopleF.AsNoTracking().ToListAsync();

        public async Task<IList<PersonJ>> ReadPersonJ() => await _context.PeopleJ.AsNoTracking().ToListAsync();

        public async Task<Person> ReadById(Guid id) => await _context.People.FirstOrDefaultAsync(x => x.Id == id);

        public async Task Delete(Guid id)
        {
            var person = await _context.People.FindAsync(id);
            if (person != null)
            {
                _context.Remove(person);
                await _context.SaveChangesAsync();
            }
        }
    }
}