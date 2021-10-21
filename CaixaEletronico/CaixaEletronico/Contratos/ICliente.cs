using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaixaEletronico
{
    interface ICliente
    {
        public int Conta { get; }
        public int Saldo { get; set; }
    }
}
