using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzaria.Domain.Model
{
    public class PedidoProduto
    {
        public int Id { get; set; }
        public int PedidoId { get; set; }
        public int ProdutoId { get; set; }
        public int QuantidadeProduto { get; set; }
        public float PrecoPorQuantidade { get; set; }
        public virtual Pedido Pedido { get; set; }
        public virtual Produto Produto { get; set; }

    }
}
