using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApresentacaoCSharp
{
    public class ContaCorrente : Conta
    {
        public override void Deposita(double valor)
        {
            if(valor < 0)
            {
                throw new ArgumentException();
            }
            else
            {
                Saldo += valor;
            }
        }

        public override void Saca(double valor)
        {
            if(valor > Saldo)
            {
                throw new ArgumentException();
            }
            else
            {
                Saldo -= valor;
            }
        }
    }
}
