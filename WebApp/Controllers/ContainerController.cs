using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ContainerLibrary.Container;


namespace WebApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContainerController : ControllerBase
    {
        private readonly Container<int> _container;
        public ContainerController(Container<int> containerController)
        {
            _container = containerController;
        }

        [HttpGet]
        public ActionResult<ContainerResponse> Get()
        {
            var content = _container.GetAll();
            return Ok(new ContainerResponse { Content = content, Count = content.Length });
        }

        [HttpPut]
        public ActionResult<AddItemRequest> Put([FromBody] AddItemRequest item, [FromQuery] bool forceAdd)
        {
            if (forceAdd)
            {
                _container.ForceAdd(item.Item);
            }
            else
            {
                _container.TryAdd(item.Item);
            }
            return Ok(new AddItemRequest { Item = item.Item });
        }

    }
}
