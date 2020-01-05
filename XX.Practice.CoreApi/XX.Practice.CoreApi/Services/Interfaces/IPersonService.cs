using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using XX.Practice.CoreApi.Model.V1;

namespace XX.Practice.CoreApi.Services.Interfaces
{
    public interface IPersonService
    {
        Person GetPerson(int personId, string personNameSpace);
        PagingResult<Person> GetPersons(string lastName, string birthDate);
    }
}
