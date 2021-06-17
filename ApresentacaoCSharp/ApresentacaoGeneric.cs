using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApresentacaoCSharp
{
    public class ApresentacaoGeneric
    {
        ContaCorrente _conta = new ContaCorrente();
        public void MostraValorServico<T>(T conta, double valor)
        {
            if (conta is ContaCorrente)
            {
                Console.WriteLine("Total do valor do serviço descontado: " + this._conta.DescontaServico(valor).ToString("C"));
            }
            else
            {
                Console.WriteLine("Taxa de serviço isenta!!!");
            }
        }

    }
}
