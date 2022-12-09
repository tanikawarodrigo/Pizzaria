using AutoMapper;
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
    public class PedidoService : IPedidoService
    {
        private readonly IPedidoRepository _pedidoRepository;
        private readonly IMapper _mapper;
        private readonly IPedidoProdutoService _pedidoProdutoService;
        public PedidoService(IPedidoRepository pedidoRepository, IMapper mapper, IPedidoProdutoService pedidoProdutoService)
        {
            _pedidoRepository = pedidoRepository;
            _mapper = mapper;
            _pedidoProdutoService = pedidoProdutoService;
        }

        public async Task<PedidoDTO> CreatePedido(PedidoDTO pedidoDTO)
        {
            var pedido = _mapper.Map<Pedido>(pedidoDTO);
            var pedidoId =  await _pedidoRepository.CreatePedido(pedido);
            //var result = await _pedidoRepository.SaveChanges();
            
            foreach(var pedidoProdutos in pedidoDTO.PedidoProduto)
            {
                pedidoProdutos.PedidoId = pedidoId;
                await _pedidoProdutoService.CreatePedidoProduto(pedidoProdutos);
            }
            return pedidoDTO;
        }

        public async Task<bool> DeletePedidoById(int id)
        {
            var existePedido = await _pedidoRepository.GetPedidoById(id);
            if(existePedido == null)
            {
                throw new Exception();
            }
            _pedidoRepository.DeletePedido(existePedido);
            var result = await _pedidoRepository.SaveChanges();
            if (result == true) { return true; }
            throw new Exception();
        }

        public async Task<List<Pedido>> GetAllPedidos(int skip, int take)
        {
            var listaPedidos = await _pedidoRepository.GetAllPedidos(skip, take);
            return listaPedidos;
        }

        public async Task<Pedido> GetPedidoById(int id)
        {
            var pedido = await _pedidoRepository.GetPedidoById(id);
            if(pedido == null)
            {
                throw new Exception();
            }
            return pedido;
        }

        //public async Task<bool> UpdatePedido(Pedido pedidoRequest)
        //{
        //    var pedido = await _pedidoRepository.GetPedidoById(pedidoRequest.Id);

        //}
    }
}
