using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Microsoft.AspNetCore.Razor.Language;
using Microsoft.Extensions.Configuration;

namespace K8sAppConfigurationKeyVaultExample.Controllers
{
   [Route( "api/[controller]" )]
   [ApiController]
   public class ValuesController : ControllerBase
   {
      private readonly IConfiguration _configuration;
      public ValuesController(IConfiguration configuration)
      {
         _configuration = configuration;
      }

      // GET api/values
      [HttpGet]
      public ActionResult<IEnumerable<string>> Get()
      {
         return new string[] { $"From Key Vault: {_configuration["FromKeyVault"]}", $"From App Configuration: {_configuration["FromAppConfiguration"]}" };
      }

      // GET api/values/all
      [HttpGet("all")]
      public ActionResult<string> GetAll()
      {
         return string.Join(',', _configuration.AsEnumerable());
      }

      // GET api/values/5
      [HttpGet( "{id}" )]
      public ActionResult<string> Get( int id )
      {
         return "value";
      }

      // POST api/values
      [HttpPost]
      public void Post( [FromBody] string value )
      {
      }

      // PUT api/values/5
      [HttpPut( "{id}" )]
      public void Put( int id, [FromBody] string value )
      {
      }

      // DELETE api/values/5
      [HttpDelete( "{id}" )]
      public void Delete( int id )
      {
      }
   }
}
