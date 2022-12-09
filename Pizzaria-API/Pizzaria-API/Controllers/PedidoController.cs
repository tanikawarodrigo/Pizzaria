using Microsoft.AspNetCore.Mvc;
using Pizzaria.Domain.DTO;
using Pizzaria.Domain.Model;
using Pizzaria.Service.IService;
using Pizzaria.Service.Service;

namespace Pizzaria_API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PedidoController : ControllerBase
    {
        private readonly IPedidoService _pedidoService;
        public PedidoController(IPedidoService pedidoService)
        {
            _pedidoService = pedidoService;
        }
        [HttpPost("create/pedido")]
        public async Task<ActionResult<PedidoDTO>> CreatePedido([FromBody] PedidoDTO pedidoReq)
        {
            try
            {
                var result = await _pedidoService.CreatePedido(pedidoReq);

                return result;
            }

            catch (Exception ex)
            {
                throw ex;
            }

        }
        [HttpGet("pedido")]
        public async Task<ActionResult<Pedido>> GetPedidoById([FromBody] int id)
        {
            try
            {
                var result = await _pedidoService.GetPedidoById(id);

                return result;
            }

            catch (Exception ex)
            {
                throw ex;
            }

        }
        [HttpGet("pedidos")]
        public async Task<ActionResult<List<Pedido>>> Getpedidos(int skip, int take)
        {
            try
            {
                var result = await _pedidoService.GetAllPedidos(skip, take);

                return result;
            }

            catch (Exception ex)
            {
                throw ex;
            }

        }
    }
}
