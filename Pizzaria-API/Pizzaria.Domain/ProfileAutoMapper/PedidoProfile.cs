using AutoMapper;
using Pizzaria.Domain.DTO;
using Pizzaria.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzaria.Domain.ProfileAutoMapper
{
    public class PedidoProfile : Profile
    {
        public PedidoProfile()
        {
            CreateMap<PedidoDTO, Pedido>().ReverseMap();
        }
    }
}
