using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using XX.Practice.CoreApi.DataAccess.Interfaces;
using XX.Practice.CoreApi.Model.V1;

namespace XX.Practice.CoreApi.DataAccess
{
    public class PersonDataAccess : IPersonDataAccess
    {        
        public Person GetPersonById(int personId, string personNameSpace)
        {
            Person person = new Person();

            //Asume we are getting data here through Entity framework or stored procedure or any other way from database
            // and passing the result to person object as defined above.

            return person;
        }

        public List<Person> SearchPerson(string lastName, DateTime birthDate)
        {
            List<Person> person = new List<Person>();

            //Asume we are getting data here through Entity framework or stored procedure or any other way from database
            // and passing the result to person object as defined above.

            return person;
        }
    }
}
