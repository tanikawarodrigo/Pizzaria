using Pizzaria.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzaria.Domain.DTO
{
    public record ProdutoDTO
    {
        public int? Id { get; set; }
        public string? NomeProduto { get; set; }
        public string? Descricao { get; set; }
        public float? PrecoUnitario { get; set; }
        public int? ProdutoCategoriaId { get; set; }
        public string? ProdutoURL { get; set; }

    }
}
