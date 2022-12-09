using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzaria.Domain.DTO.Request.PedidoReqDTO
{
    public record PedidoCreateRequestDTO
    {
        public string? Celular { get; set; }
        public string? Email { get; set; }
        public string? Cpf { get; set; }
        public string? Endereço { get; set; }
        public float? PrecoTotal { get; set; }
        public int? UserId { get; set; }
        public int? TipoPagamentoId { get; set; }
        public int? StatusPedidoId { get; set; }
        public int? TipoEntregaId { get; set; }
        public int? StatusEntregaId { get; set; }
        public int? CriadoPor { get; set; }
        public DateTime? DataCriacao { get; set; }
        public int? AtualizadoPor { get; set; }
        public DateTime? DataAtualizacao { get; set; }
        public bool? Ativo { get; set; }
        public virtual List<PedidoProdutoDTO> PedidoProduto { get; set; }
    }
}
