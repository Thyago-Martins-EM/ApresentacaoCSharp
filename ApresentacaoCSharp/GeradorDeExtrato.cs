using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApresentacaoCSharp
{
    class GeradorDeExtrato
    {
        public void DadosDaOperacao(Conta conta, double valor)
        {
            DateTime agora = DateTime.Now;
            string horario = String.Format("{0: d/M/ yyyy HH:mm:ss}",agora);

            Console.WriteLine("Titular: " + conta.Titular);
            Console.WriteLine("Valor: " + valor);
            Console.WriteLine("Operação: " + conta.ToString().);
            Console.WriteLine("Horario: " + horario);
        }
    }
}
