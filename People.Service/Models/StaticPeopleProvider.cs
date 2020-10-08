using PersonRepository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace People.Service.Models
{
    public class StaticPeopleProvider : IPeopleProvider
    {
        public List<Person> GetPeople()
        {
            var p = new List<Person>()
            {
                new Person() { Id=1, GivenName="Pooji", FamilyName="Panc",
                    StartDate = new DateTime(1975, 10, 17), Rating=6 },
                new Person() { Id=2, GivenName="Mini", FamilyName="Panc",
                    StartDate = new DateTime(2000, 10, 2), Rating=8 },
                new Person() { Id=3, GivenName="Manju", FamilyName="Kolla",
                    StartDate = new DateTime(1999, 3, 28), Rating=8,
                    FormatString = "{1} {0}" },
                new Person() { Id=4, GivenName="Pooji", FamilyName="Panc",
                    StartDate = new DateTime(1999, 3, 19), Rating=7 },
                new Person() { Id=5, GivenName="Pooja", FamilyName="Pool",
                    StartDate = new DateTime(1988, 2, 15), Rating=9 },
                new Person() { Id=6, GivenName="Dimpu", FamilyName="Pool",
                    StartDate = new DateTime(2003, 12, 8), Rating=6},
                new Person() { Id=7, GivenName="Srujana", FamilyName="Jami",
                    StartDate = new DateTime(1994, 1, 26), Rating=6 },
                new Person() { Id=8, GivenName="Theethu", FamilyName="Kolla",
                    StartDate = new DateTime(2000, 11, 1), Rating=5 },
                new Person() { Id=9, GivenName="Nayani", FamilyName="Kolla",
                    StartDate = new DateTime(1977, 9, 10), Rating=4 },
            };
            return p;
        }
    }
}
