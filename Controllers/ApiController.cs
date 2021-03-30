using BCG_Orgbuilder.Models;
using BCG_Orgbuilder.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BCG_Orgbuilder.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ApiController : ControllerBase
    {
        
        private readonly IApiRepo _repository;
        private readonly ILogger<ApiController> _logger;
        private readonly IConfiguration _configuration;

        public ApiController(IApiRepo repository, ILogger<ApiController> logger, IConfiguration configuration)
        {
            _repository = repository;
            _logger = logger;
            _configuration = configuration;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Api>> GetAllCommands()
        {
            
            _logger.LogInformation(_configuration.GetConnectionString("PostgreSqlConnection"));
            var commands = _repository.GetAllCommands();
            Console.WriteLine(commands);
            return Ok(commands);
            
        }
    }
}
