using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.Extensions.Logging;

namespace FuncCs.Controllers
{
  public class HelloworldController
  {
    public HelloworldController()
    {
    }

    [FunctionName("HelloworldController_Get")]
    public IActionResult Get(
        [HttpTrigger(AuthorizationLevel.Anonymous, "get", Route = "hello_world")] HttpRequest req,
        ILogger logger
    )
    {
      logger.LogInformation("!!HelloworldController_Get!!");

      return new OkResult();
    }
  }
}
