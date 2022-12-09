using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Mvc;
using Pizzaria.Domain.DTO;
using Pizzaria.Domain.Model;
using Pizzaria.Service.IService;

namespace Pizzaria_API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProdutoController : ControllerBase
    {
        private readonly IProdutoService _produtoService;

        public ProdutoController(IProdutoService produtoService)
        {
            _produtoService = produtoService;
        }

        [HttpPost("create")]
        public async Task<ActionResult<ProdutoDTO>> CreateProduto( ProdutoDTO produtoReq)
        {
            try
            {
                var result = await _produtoService.CreateProduto(produtoReq);

                return result;
            }
  
            catch (Exception ex)
            {
                throw ex;
            }

        }
        [HttpGet("produto")]
        public async Task<ActionResult<Produto>> GetProdutoById( int id)
        {
            try
            {
                var result = await _produtoService.GetProdutoById(id);

                return result;
            }

            catch (Exception ex)
            {
                throw ex;
            }

        }
        [HttpGet("produtos")]
        public async Task<ActionResult<List<Produto>>> GetProdutos()
        {
            try
            {
                var result = await _produtoService.GetAllProdutos();

                return result;
            }

            catch (Exception ex)
            {
                throw ex;
            }

        }
        [HttpGet("bebidas")]
        public async Task<ActionResult<List<Produto>>> GetAllBebidas()
        {
            try
            {
                var result = await _produtoService.GetAllBebidas();

                return result;
            }

            catch (Exception ex)
            {
                throw ex;
            }

        }
        [HttpDelete("produto")]
        public async Task<ActionResult<bool>> DeleteProdutoById(int id)
        {
            try
            {
                var result = await _produtoService.DeleteProdutoById(id);

                return result;
            }

            catch (Exception ex)
            {
                throw ex;
            }

        }
        [HttpPut("produto")]
        public async Task<ActionResult<bool>> UpdateProduto(ProdutoDTO produtoReq)
        {
            try
            {
                var result = await _produtoService.UpdateProduto(produtoReq);

                return result;
            }

            catch (Exception ex)
            {
                throw ex;
            }

        }
    }
}
