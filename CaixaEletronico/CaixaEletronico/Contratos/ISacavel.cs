namespace CaixaEletronico
{
    internal interface ISacavel
    {
        public Banco Banco { get; }

        public Saque Sacar(ICliente cliente, int valor);

        public bool ValidarSaque(ICliente cliente, int valor);
    }
}