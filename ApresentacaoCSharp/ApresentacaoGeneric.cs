using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApresentacaoCSharp
{
    public class ApresentacaoGeneric
    {
        //Repensar ideia de classe ou metodo Generic
        ContaCorrente ct = new ContaCorrente();
        public void MostraValorServico<T>(T conta, double valor, T destino)
        {
            if (conta is ContaCorrente)
            {
                
            }
            else
            {
                Console.WriteLine("Serviço não habiliatado para esse tipo de conta!!!");
            }
        }
    }
}
