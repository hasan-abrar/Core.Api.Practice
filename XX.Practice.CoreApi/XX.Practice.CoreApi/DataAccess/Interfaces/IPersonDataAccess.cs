using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using XX.Practice.CoreApi.Model.V1;

namespace XX.Practice.CoreApi.DataAccess.Interfaces
{
    public interface IPersonDataAccess
    {
        Person GetPersonById(int personId, string personNameSpace);

        List<Person> SearchPerson(string lastName, DateTime birthDate);
    }
}
