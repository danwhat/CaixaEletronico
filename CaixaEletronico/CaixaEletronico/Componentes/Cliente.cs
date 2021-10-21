using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaixaEletronico
{
    class Cliente : Pessoa, ICliente
    {
        public Cliente(int conta, int saldo, string nome, string cpf) : base(nome, cpf)
        {
            Conta = conta;
            Saldo = saldo;
        }
        public int Conta { get; }
        public int Saldo { get; set; }
    }
}
