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
    public class ProdutoService : IProdutoService
    {
        private readonly IProdutoRepository _produtoRepository;
        private readonly IMapper _mapper;
        public ProdutoService(IProdutoRepository produtoRepository, IMapper mapper)
        {
            _produtoRepository = produtoRepository;
            _mapper = mapper;
        }

        public async Task<ProdutoDTO> CreateProduto(ProdutoDTO produtoDTO)
        {
            var produtoExiste = await _produtoRepository.GetProdutoByName(produtoDTO.NomeProduto);
            if(produtoExiste == null)
            {
                _produtoRepository.CreateProduto(produtoDTO);
                var result = await _produtoRepository.SaveChanges();
                if(result == false)
                {
                    throw new Exception();
                }
                return produtoDTO;
            }
            throw new Exception();
        }

        public async Task<bool> DeleteProdutoById(int id)
        {
            var produtoExiste = await _produtoRepository.GetProdutoById(id);
            if(produtoExiste == null)
            {
                throw new Exception();
            }
            _produtoRepository.DeleteProdutoById(produtoExiste);
            var result = await _produtoRepository.SaveChanges();
            if(result == false)
            {
                throw new Exception();
            }
            return result;
        }

        public async Task<List<Produto>> GetAllBebidas()
        {
            var produtos = await _produtoRepository.GetAllBebidas();
            return produtos;
        }

        public async Task<List<Produto>> GetAllProdutos()
        {
            var produtos = await _produtoRepository.GetAllProduto();
            return produtos;
        }

        public async Task<Produto> GetProdutoById(int id)
        {
            var produto = await _produtoRepository.GetProdutoById(id);
            return produto;
        }

        public async Task<bool> UpdateProduto(ProdutoDTO produtoDTO)
        {
            var produto = await _produtoRepository.GetProdutoById((int)produtoDTO.Id);
            if (produto == null)
            {
                throw new Exception();
            }
            produto.NomeProduto = produtoDTO.NomeProduto == null ? produto.NomeProduto : produtoDTO.NomeProduto;
            produto.ProdutoURL = produtoDTO.ProdutoURL == null ? produto.ProdutoURL : produtoDTO.ProdutoURL; ;
            produto.PrecoUnitario = (float)(produtoDTO.PrecoUnitario == null ? produto.PrecoUnitario : produtoDTO.PrecoUnitario);
            produto.Descricao = produtoDTO.Descricao == null ? produto.Descricao : produtoDTO.Descricao;
            produto.ProdutoCategoriaId = (int)(produtoDTO.ProdutoCategoriaId == null ? produto.ProdutoCategoriaId : produtoDTO.ProdutoCategoriaId);
            _produtoRepository.UpdateProduto(produto);
            var result = await _produtoRepository.SaveChanges();
            if(result == false)
            {
                throw new Exception();
            }
            return result;
        }
    }
}
