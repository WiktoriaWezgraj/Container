using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ContainerLibrary.Container;

namespace WebApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContainerController : ControllerBase
    {
        private readonly IContainer<int> _container;

        public ContainerController(IContainer<int> container)
        {
            _container = container;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok();
        }

        [HttpPut]
        public IActionResult Put([FromQuery] bool forceAdd, [FromQuery] int value)
        {
            if (forceAdd)
            {
                _container.ForceAdd(value);
            }
            else
            {
                _container.TryAdd(value);
            }

            return Ok();
        }

    }
}
