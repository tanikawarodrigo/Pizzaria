using Pizzaria.Data.IRepository;
using Pizzaria.Domain.DTO;
using Pizzaria.Domain.Model;
using Pizzaria.Service.IService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzaria.Service.Service
{
    public class PedidoProdutoService : IPedidoProdutoService
    {
        private readonly IPedidoProdutoRepository _pedidoProdutoRepository;
        private readonly IProdutoRepository _produtoRepository;

        public PedidoProdutoService(IPedidoProdutoRepository pedidoProdutoRepository, IProdutoRepository produtoRepository)
        {
            _pedidoProdutoRepository = pedidoProdutoRepository;
            _produtoRepository = produtoRepository;
        }

        public async Task<bool> CreatePedidoProduto(PedidoProdutoDTO pedidoProdutoDto)
        {
            var produtoExiste = await _produtoRepository.GetProdutoById(pedidoProdutoDto.ProdutoId);
            if(produtoExiste == null)
            {
                throw new Exception();
            }
            var pedidoProduto = new PedidoProduto();
            pedidoProduto.ProdutoId = pedidoProdutoDto.ProdutoId;
            pedidoProduto.QuantidadeProduto = pedidoProdutoDto.QuantidadeProduto;
            pedidoProduto.PedidoId = pedidoProdutoDto.PedidoId;
            _pedidoProdutoRepository.CreatePedidoProduto(pedidoProduto);
            var result = await _pedidoProdutoRepository.SaveChanges();
            if(result == false)
            {
                throw new Exception();
            }
            return result;
        }
    }
}
