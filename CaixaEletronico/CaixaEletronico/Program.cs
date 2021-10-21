using CaixaEletronico.Componentes;
using System;

namespace CaixaEletronico
{
    class Program
    {
        static void Main(string[] args)
        {
            Banco banco = new Banco("BancoBacana");

            // Testar Cliente
            if (true)
            {
                Cliente cliente = banco.AdicionarCliente(0001, 1000, "João", "12345678901");
                Console.WriteLine(cliente.Nome);
                Console.WriteLine(cliente.Cpf);
                Console.WriteLine(cliente.Conta);
                Console.WriteLine(cliente.Saldo);
            }
            Console.WriteLine("---//---");

            // Testar Saque 
            if (true)
            {
                ISacavel caixa = new CaixaEletronico(banco);

                ICliente cliente = banco.AdicionarCliente(0001, 1000, "João", "12345678901");
                Console.WriteLine("Saldo: " + cliente.Saldo);
                Saque saque = caixa.Sacar(cliente, 175);
                Console.WriteLine("Sucesso: " + saque.Sucesso);
                Console.WriteLine("Hora do Saque: " + saque.HoraDoSaque);
                Console.WriteLine("Saldo: " + cliente.Saldo);
                saque.MostrarNotas();
                Console.WriteLine();

                ICliente cliente2 = banco.AdicionarCliente(0002, 1000, "João", "12345678902");
                Console.WriteLine("Saldo: " + cliente2.Saldo);
                Saque saque2 = caixa.Sacar(cliente2, 1500);
                Console.WriteLine("Sucesso: " + saque2.Sucesso);
                Console.WriteLine("Hora do Saque: " + saque2.HoraDoSaque);
                Console.WriteLine("Saldo: " + cliente2.Saldo);
                saque2.MostrarNotas();
            }
            Console.WriteLine("---//---");

            // Sacar de qualquer Caixa Eletronico
            if (true)
            {
                ISacavel caixa = new CaixaEletronico(banco);
                ISacavel caixa2 = new AgenciaBancaria(banco);
                ISacavel caixa3 = new AgenciaBancaria(banco);

                ICliente cliente = banco.AdicionarCliente(0001, 1000, "João", "12345678901");

                Console.WriteLine("Primeiro Saque");
                Console.WriteLine("Saldo: " + cliente.Saldo);
                Saque saque = caixa.Sacar(cliente, 175);
                saque.MostrarNotas();
                Console.WriteLine("Saldo Final: " + cliente.Saldo);
                Console.WriteLine();

                Console.WriteLine("Segundo Saque");
                Console.WriteLine("Saldo: " + cliente.Saldo);
                Saque saque2 = caixa2.Sacar(cliente, 365);
                saque2.MostrarNotas();
                Console.WriteLine("Saldo Final: " + cliente.Saldo);
                Console.WriteLine();

                Console.WriteLine("Terceiro Saque");
                Console.WriteLine("Saldo: " + cliente.Saldo);
                Saque saque3 = caixa3.Sacar(cliente, 855);
                saque3.MostrarNotas();
                Console.WriteLine("Saldo Final: " + cliente.Saldo);
                Console.WriteLine();
            }
            Console.WriteLine("---//---");

        }
    }
}


