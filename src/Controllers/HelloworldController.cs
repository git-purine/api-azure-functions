using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;

namespace GitPurine.Controllers
{
  public class HelloworldController
  {
    public HelloworldController()
    {
    }

    [FunctionName("HelloworldController_Get")]
    public IActionResult Get(
        [HttpTrigger(AuthorizationLevel.Anonymous, "get", Route = "hello_world")] HttpRequest req
    )
    {
      return new OkResult();
    }
  }
}
