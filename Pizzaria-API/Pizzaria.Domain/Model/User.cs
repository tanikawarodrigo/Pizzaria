using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzaria.Domain.Model
{
    public class User
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Senha { get; set; }
        public string Celular { get; set; }
        public string Cpf { get; set; }
        public string Endereço { get; set; }
        public string Role { get; set; }
        public List<Pedido> Pedido { get; set; }
    }
}
