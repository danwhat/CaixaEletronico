using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaixaEletronico
{
    class CaixaEletronico : ISacavel
    {
        public CaixaEletronico(Banco banco)
        {
            Banco = banco;
        }

        public Banco Banco { get; }

        public Saque Sacar(ICliente cliente, int valor)
        {
            if (ValidarSaque(cliente, valor))
            {
                cliente.Saldo -= valor;
                Saque saque = new Saque(valor);
                Banco.AdicionarSaque(saque);
                return saque;
            }
            return new Saque(0);
        }

        public bool ValidarSaque(ICliente cliente, int valor)
        {
            if (cliente.Saldo >= valor) {
                return true;
            }
            return false;
        }

        public void MostrarSaldo(ICliente cliente)
        {
            Console.WriteLine(cliente.Saldo);
        }
    }
}
