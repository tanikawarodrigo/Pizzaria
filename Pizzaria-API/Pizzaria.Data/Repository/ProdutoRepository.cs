using AutoMapper;
using Dapper;
using Microsoft.EntityFrameworkCore;
using Pizzaria.Data.IRepository;
using Pizzaria.Domain.DTO;
using Pizzaria.Domain.Model;
using Pizzaria.Infraestructure.Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzaria.Data.Repository
{
    public class ProdutoRepository: IProdutoRepository
    {
        private readonly IMapper _mapper;
        private readonly ApplicationDbContext _context;
        private readonly DapperConnection _connection;

        private const string GetProdutoByIdDapper = @"SELECT * FROM [Produtos] WHERE Id = @id";
        private const string GetProdutoByNameDapper = @"SELECT * FROM [Produtos] WHERE NomeProduto = @nome";
        private const string GetProdutoListDapper = @"SELECT * FROM [Produtos]";
        private const string GetBebidaListDapper = @"SELECT * FROM [Produtos] WHERE ProdutoCategoriaId = 1";
        public ProdutoRepository(ApplicationDbContext context, DapperConnection connection, IMapper mapper)
        {
            _mapper = mapper;
            _context = context;
            _connection = connection;
        }

        public async void CreateProduto(ProdutoDTO produtoDTO)
        {
            var produto = _mapper.Map<Produto>(produtoDTO);
            await _context.Produtos.AddAsync(produto);
        }
        public async Task<List<Produto>> GetAllProduto()
        {
            var list = new List<Produto>();
            var produtos = await _connection.Connection.QueryAsync<Produto>(GetProdutoListDapper);
            foreach (var produto in produtos)
            {
                list.Add(produto);
            }
            return list;
        }

        public async Task<Produto> GetProdutoById(int id)
        {
            var produto = await _connection.Connection.QueryFirstOrDefaultAsync<Produto>(GetProdutoByIdDapper, new {id});
            return produto;
        }

        public async Task<Produto> GetProdutoByName (string nome)
        {
            var produto = await _connection.Connection.QueryFirstOrDefaultAsync<Produto>(GetProdutoByNameDapper, new { nome });
            return produto;
        }

        public async Task<bool> SaveChanges()
        {
            return await _context.SaveChangesAsync() > 0;
        }

        public void UpdateProduto(Produto produto)
        {
            _context.Produtos.Update(produto);
        }

        public void DeleteProdutoById(Produto produto)
        {
            _context.Produtos.Remove(produto);
        }

        public async Task<List<Produto>> GetAllBebidas()
        {
            var list = new List<Produto>();
            var produtos = await _connection.Connection.QueryAsync<Produto>(GetBebidaListDapper);
            foreach (var produto in produtos)
            {
                list.Add(produto);
            }
            return list;
        }
    }
}
