using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CitiesManager.WebAPI.Controllers
{
    [ApiVersion("1")]
    [Route("api/v{version:ApiVersion}/[controller]/[action]")]
    [ApiController]
    public class ApiBaseController : ControllerBase
    {
    }
}
