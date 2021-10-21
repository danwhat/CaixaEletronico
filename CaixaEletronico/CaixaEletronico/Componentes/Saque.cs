using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaixaEletronico
{
    class Saque
    {
        public DateTime HoraDoSaque { get; }
        public int ValorDoSaque { get; }
        public bool Sucesso { get; }
        private List<int> Cedulas = new List<int>();

        public Saque(int valorDoSaque)
        {

            HoraDoSaque = DateTime.Now;
            ValorDoSaque = valorDoSaque;
            Sucesso = (valorDoSaque != 0);
        }

        public void MostrarNotas()
        {
            if (ValorDoSaque != 0)
            {
                Console.WriteLine($"Valor do Saque: {ValorDoSaque}");
                string notas = "Notas: ";
                CalcularNotas(ValorDoSaque).ForEach(e => notas += ($"{e}, "));
                Console.WriteLine(notas.Substring(0, notas.Length - 2));
            }
            else Console.WriteLine("Saque não realizado.");
        }

        private List<int> CalcularNotas(int valor)
        {
            List<int> lista = new List<int>();
            List<int> notas = new List<int> { 100, 50, 20, 10, 5 };
            while (notas.Count != 0)
            {
                while (valor / notas[0] != 0)
                {
                    valor -= notas[0];
                    lista.Add(notas[0]);
                }
                notas.Remove(notas[0]);
            }
            return lista;
        }
    }
}
