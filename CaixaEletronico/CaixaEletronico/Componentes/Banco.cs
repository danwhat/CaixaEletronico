using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaixaEletronico
{
    class Banco : IBanco
    {
        public Banco(string nome)
        {
            Nome = nome;
        }

        List<Cliente> ListaDeClientes = new List<Cliente>();
        List<Saque> ListaDeSaques = new List<Saque>();
        public string Nome { get; }

        public void AdicionarSaque(Saque saque)
        {
            if (saque.Sucesso) ListaDeSaques.Add(saque);
        }
        public List<Saque> PegarSaque()
        {
            return ListaDeSaques;
        }

        public Cliente AdicionarCliente(int conta, int saldo, string nome, string cpf)
        {
            Cliente cliente = new Cliente(conta, saldo, nome, cpf);
            ListaDeClientes.Add(cliente);
            return cliente;
        }
        public List<Cliente> PegarClientes()
        {
            return ListaDeClientes;
        }
        public Cliente PegarCliente(int conta)
        {
            return ListaDeClientes.Find(c => c.Conta == conta);
        }
    }
}
