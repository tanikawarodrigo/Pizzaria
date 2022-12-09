using Pizzaria.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzaria.Domain.DTO
{
    public record PedidoProdutoDTO
    {
        public int PedidoId { get; set; }
        public int ProdutoId { get; set; }
        public int QuantidadeProduto { get; set; }
        public float PrecoPorQuantidade { get; set; }
    }
}
