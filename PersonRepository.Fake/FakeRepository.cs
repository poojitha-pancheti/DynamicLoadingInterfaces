using PersonRepository.Interface;
using System;
using System.Collections.Generic;

namespace PersonRepository.Fake
{
    public class FakeRepository : IPersonRepository
    {
        public IEnumerable<Person> GetPeople()
        {
            return new List<Person>()
            {
                new Person() {
                    Id=1, GivenName="Mini", FamilyName="Srini",
                    StartDate = new DateTime(1975, 10, 17), Rating=6
                },
                new Person() { Id=2, GivenName="Pooji", FamilyName="Panc",
                    StartDate = new DateTime(2000, 10, 2), Rating=8
                }
            };
        }

        public void AddPerson(Person newPerson)
        {
            throw new NotImplementedException();
        }

        public void DeletePerson(int id)
        {
            throw new NotImplementedException();
        }

        public Person GetPerson(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdatePerson(int id, Person updatedPerson)
        {
            throw new NotImplementedException();
        }
    }
}
