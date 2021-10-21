namespace CaixaEletronico
{
    internal interface ISacavel
    {
        public Banco Banco { get; }

        public Saque Sacar(Cliente cliente, int valor);

        public bool ValidarSaque(Cliente cliente, int valor);
    }
}