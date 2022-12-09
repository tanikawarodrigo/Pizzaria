using Pizzaria.Domain.DTO;
using Pizzaria.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzaria.Service.IService
{
    public interface IPedidoService
    {
        Task<PedidoDTO> CreatePedido(PedidoDTO pedidoDTO);
        Task<List<Pedido>> GetAllPedidos(int skip, int take);
        Task<Pedido> GetPedidoById(int id);
        Task<bool> DeletePedidoById(int id);
        //Task<bool>UpdatePedido(Pedido pedido);
    }
}
