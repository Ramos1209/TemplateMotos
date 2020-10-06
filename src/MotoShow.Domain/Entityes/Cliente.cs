using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MotoShow.Domain.Entityes
{
   public class Cliente:EntityBase
    {

        public string Apelido { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Contato { get; set; }
        public string CPFCNPJ { get; set; }
        public string Telefone1 { get; set; }
        public string Telefone2 { get; set; }
        public string Endereco { get; set; }
        public string Complemento { get; set; }
        public string Celular { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string UF { get; set; }
        public string Cep { get; set; }

    }
}
