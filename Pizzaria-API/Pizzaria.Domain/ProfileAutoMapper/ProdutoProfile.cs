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
    public class ProdutoProfile : Profile
    {
        public ProdutoProfile()
        {
            CreateMap<ProdutoDTO, Produto>().ReverseMap();
        }
    }
}
