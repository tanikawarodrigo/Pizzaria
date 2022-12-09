using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzaria.Domain.Model
{
    public class Produto
    {
        public int Id { get; set; }
        public string NomeProduto { get; set; }
        public string Descricao { get; set; }
        public float PrecoUnitario { get; set; }
        public int ProdutoCategoriaId { get; set; }
        public string ProdutoURL { get; set;}
        public virtual ProdutoCategoria ProdutoCategoria { get; set; }
        public List<PedidoProduto> PedidoProduto { get; set; }
    }
}
