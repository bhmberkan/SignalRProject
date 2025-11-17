using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SignalR.BussinesLayer.Abstract;

namespace SignalRApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BasketController : ControllerBase
    {
        private readonly IBasketservice _basketservice;

        public BasketController(IBasketservice basketservice)
        {
            _basketservice = basketservice;
        }

        [HttpGet]
        public IActionResult GetBasketByMenuTableID(int id)
        {
            var values = _basketservice.TGetbasketByMenuTableNumber(id);
            return Ok(values);
        }
    }
}
