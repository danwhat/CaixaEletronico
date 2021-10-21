using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaixaEletronico
{
    abstract class Pessoa
    {
        public String Nome { get; set; }
        public String Cpf { get; set; }

        public Pessoa(string nome, String cpf)
        {
            Nome = nome;
            Cpf = cpf;
        }
    }
}
