using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaixaEletronico
{
    interface IBanco
    {
        public void AdicionarSaque(Saque saque);
        public List<Saque> PegarSaque();

        public Cliente AdicionarCliente(int conta, int saldo, string nome, string cpf);
        public List<Cliente> PegarClientes();
        public Cliente PegarCliente(int conta);
    }
}
