using DA;
using DA.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace Api_Test.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ClassController
    {
        [HttpGet("GetVista")]

        public async Task<string> GetVista()
        {
            TestProviders vista = new TestProviders();
            IEnumerable<vAdditionalContactInfo> resultado = await vista.LeerVista();
            return JsonConvert.SerializeObject(resultado);
        }
    }
}

