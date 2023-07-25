using Commerce.Data.Entities;
using Commerce.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Commerce.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PedidoController : ControllerBase
    {

        [HttpGet("Pedido")]
        async public Task<ActionResult> FazerPedido(List<ProdutoDTO> pedidosRequest)
        {
            if(!ModelState.IsValid) {
                return BadRequest(ModelState.SelectMany(p => p.Value.Errors).ToList());
            }
            var Pedidos = new List<Pedido>();
            return Ok(Pedidos);
        }
    }
}
