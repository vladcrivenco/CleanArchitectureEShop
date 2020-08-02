using Microsoft.AspNetCore.Mvc;

namespace CleanArchitectureEShop.Web.Api
{
    [Route("api/[controller]")]
    [ApiController]
    public abstract class BaseApiController : Controller
    {
    }
}
