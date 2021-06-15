using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApresentacaoCSharp
{
    class ApresentaUpDowncasting
    {
        public void RealizaTeste()
        {
            Conta c4 = new ContaCorrente();
            c4.Titular = "Thyago";
            double valor = 100.50;
            c4.Deposita(valor);
            Console.WriteLine("Deposito Realizado com Sucesso!!!");
            Console.WriteLine("Numero Conta: " + c4.Numero + "\n" + "Titular Conta: " + c4.Titular + "\n" + "Saldo Conta: " + c4.Saldo.ToString("F"));
            if (c4 is ContaCorrente)
            {
                ContaCorrente ct = (ContaCorrente)c4;

                Console.WriteLine("Total do valor do serviço descontado: " + ct.DescontaServico(valor).ToString("F"));

            }
        }
    }
}
