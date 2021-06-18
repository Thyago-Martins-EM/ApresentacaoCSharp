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
                Saldo += valor-this.DescontaServico(valor);
            }
        }

        public override void Saca(double valor)
        {
            if (valor > Saldo)
            {
                throw new ArgumentException();
            }
            else
            {
                Saldo -= valor;
            }
        }

        public void Transferencia(double valor, Conta destino) 
        {
            Saca(valor);
            destino.Deposita(valor);
        }

        public double DescontaServico (double valor)
        {
            valor *= 0.05;
            return valor;
        }
    }
}
