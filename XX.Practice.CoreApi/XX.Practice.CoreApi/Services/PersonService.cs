using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using XX.Practice.CoreApi.DataAccess.Interfaces;
using XX.Practice.CoreApi.Model.V1;
using XX.Practice.CoreApi.Services.Interfaces;

namespace XX.Practice.CoreApi.Services
{
    public class PersonService : IPersonService
    {
        private readonly IPersonDataAccess _personDataAccess;

        public PersonService(IPersonDataAccess personDataAccess)
        {
            _personDataAccess = personDataAccess;
        }
        public Person GetPerson(int personId, string personNameSpace)
        {
            var person = _personDataAccess.GetPersonById(personId, personNameSpace);

            return person;
        }

        public PagingResult<Person> GetPersons(string lastName, string birthDate)
        {
            PagingResult<Person> pagingResult = new PagingResult<Person>();

            DateTime.TryParse(birthDate, out DateTime birthDateTime);

            pagingResult.Results = _personDataAccess.SearchPerson(lastName, birthDateTime);

            return pagingResult;
        }
    }
}
