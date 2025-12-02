using Ecommerce.Domain.Interfaces.Repository;
using Ecommerce.Domain.Interfaces.Service;
using Ecommerce.Domain.Models;

namespace Ecommerce.Domain.Services;

    public class PersonService (IPersonRepository _personRepository) : IPerson
    {

    public async Task CreatePersonF(PersonF person)
    {
        //Check if person exists
        if (person is null)
            throw new Exception("Person do not exists");
        await _personRepository.CreatePersonF(person);
        //Write on db
    }
    public async Task CreatePersonJ(PersonJ person)
    {
        //Check if person exists
        if (person is null)
            throw new Exception("Person do not exists");
        await _personRepository.CreatePersonJ(person);
        //Write on db
    }
    public async Task<IList<PersonJ>> ReadPersonJ() => await _personRepository.ReadPersonJ();
    public async Task<IList<PersonF>> ReadPersonF() => await _personRepository.ReadPersonF();

    public async Task Delete(Guid id)
    {
        var person = await _personRepository.ReadById(id);
        if (person is null)
            throw new Exception("Person do not exists");
        await _personRepository.Delete(id);
    }
    public async Task<Person> ReadById(Guid id)
    {
        var person = await _personRepository.ReadById(id);
        if (person is null)
            throw new Exception("Person do not exixts");
        return person;
}
    public async Task UpdatePersonF(PersonF person)
    {
        if (person is null)
            throw new Exception("Person do not exists");
    
        var person_exists = await _personRepository.ReadById(person.Id);
        if (person_exists is null)
            throw new Exception("Person do not exists");
    
    
        var personF = person_exists as PersonF;
        if (personF is null)
            throw new Exception("Person is not PersonF type");
    
        personF.Name = person.Name;
        personF.CPF = person.CPF;
        personF.Email = person.Email;
        personF.Phone = person.Phone;
        personF.Address = person.Address;
        

        await _personRepository.UpdatePersonF(personF);
    }

        public async Task UpdatePersonJ(PersonJ person)
    {
        if (person is null)
            throw new Exception("Person do not exists");

        var person_exists = await _personRepository.ReadById(person.Id);
        if (person_exists is null)
            throw new Exception("Person do not exists");

        var personJ = person_exists as PersonJ;
        if (personJ is null)
            throw new Exception("Person do not exists");

        personJ.BusinessName = person.BusinessName;
        personJ.CNPJ = person.CNPJ;
        personJ.Email = person.Email;
        personJ.Phone = person.Phone;
        personJ.Address = person.Address;

         await _personRepository.UpdatePersonJ(personJ);
        }
    }
