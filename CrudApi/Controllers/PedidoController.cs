using CrudApi.Context;
using CrudApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace CrudApi.Controllers
{
    [ApiController]
    [Route("pedidos")]
    public class PedidoController : Controller
    {

        private readonly ClienteContext _pedidoContext;

        public PedidoController(ClienteContext pedido)
        {
            _pedidoContext = pedido;
        }

        //public Task<IActionResult> CriarPedido(int id) 
        //{
            
        //}

        [HttpGet]
        public IActionResult ListarPedido(int id)
        {
            var pedidosBanco = _pedidoContext.Pedidos.Find(id);
            return Ok(pedidosBanco);
        }
    }
}
