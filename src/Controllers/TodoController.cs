using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.Extensions.Logging;
using System.Linq;

namespace FuncCs.Controllers
{
  using Models;

  public class TodoController
  {
    public TodoController(FuncDbContext funcDbContext)
    {
      _funcDbContext = funcDbContext;
    }

    private readonly FuncDbContext _funcDbContext;

    [FunctionName("TodoController_Get")]
    public IActionResult Get(
        [HttpTrigger(AuthorizationLevel.Anonymous, "get", Route = "hello_world")] HttpRequest req,
        ILogger logger
    )
    {
      logger.LogInformation("!!TodoController_Get!!");

      var todos = _funcDbContext.Todos.ToList();

      return new OkObjectResult(todos);
    }
  }
}
