using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using XX.Practice.CoreApi.Model.V1;
using XX.Practice.CoreApi.Services.Interfaces;

namespace XX.Practice.CoreApi.Controllers
{
    [Route("/customers/v1/customer")]
    [Produces("application/json")]
    public class CustomerController : Controller
    {
        private readonly IPersonService _personService;

        public CustomerController(IPersonService personService)
        {
            _personService = personService;
        }

        // /customers/v1/customer/123
        [HttpGet]
        [Route("{pid?}")]
        public ActionResult<Person> Get(string pid=null)
        {
            int personId = 1;
            string personNameSpace = "";

            var person = _personService.GetPerson(personId, personNameSpace);

            return person;
        }

        // /customers/v1/customer/Search?lastName=abc
        [Route("Search")]
        [HttpGet]        
        public ActionResult<PagingResult<Person>> Search(string lastName=null, string birthDate=null)
        {
            
            var person = _personService.GetPersons(lastName, birthDate);

            return person;
        }
    }
}