using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using lab1_iot_jankowiak.Rest.Context;
using lab1_iot_jankowiak.Rest.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace lab1_iot_jankowiak.Rest.Controllers
{
    [ApiController]
    [Route("people")]
    public class PeopleController : ControllerBase
    {
        AzureDbContext _azureDbContext;

        public PeopleController(AzureDbContext azureDbContext)
        {
            _azureDbContext = azureDbContext;
        }

        [HttpGet]
        public IEnumerable<Person> Get()
        {
            return _azureDbContext.People;
        }
    }
}
