﻿using Pizzaria.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzaria.Domain.DTO
{
    public record PedidoDTO
    {
        public int? Id { get; set; }
        //public int? CodPedido { get; set; }
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

        //public virtual TipoPagamento TipoPagamento { get; set; }

        //public virtual User? User { get; set; }
        //public virtual StatusPedido StatusPedido { get; set; }
        //public virtual StatusEntrega StatusEntrega { get; set; }
        //public virtual TipoEntrega TipoEntrega { get; set; }
        public virtual List<PedidoProdutoDTO> PedidoProduto { get; set; }
    }
}
