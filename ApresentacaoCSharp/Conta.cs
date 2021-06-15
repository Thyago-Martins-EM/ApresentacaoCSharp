using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApresentacaoCSharp
{
    public abstract class Conta
    {
        private static int numeroDeContas;

        public Conta()
        {
            Conta.numeroDeContas++;
            this.Numero = numeroDeContas;
        }

        public int Numero { get; private set; }
        public double Saldo { get; protected set; }
        public string Titular { get; set; }
        public abstract void Deposita(double valor);
        public abstract void Saca(double valor);

        public static int ProximoNumero()
        {
            return numeroDeContas + 1;
        }
    }
}
