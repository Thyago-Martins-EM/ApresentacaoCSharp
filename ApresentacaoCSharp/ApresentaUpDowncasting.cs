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
            //Upcast
            ContaCorrente c4 = new ContaCorrente();
            Conta f = c4;
            f.Titular = "Thyago";
            double valor = 100.50;
            f.Deposita(valor);
            Console.WriteLine("Deposito Realizado com Sucesso!!!");
            Console.WriteLine("Numero Conta: " + f.Numero + "\n" + "Titular Conta: " + f.Titular + "\n" + "Saldo Conta: " + f.Saldo.ToString("C"));

            //Downcast com is
            /*
            if (c4 is ContaCorrente)
            {
                ContaCorrente ct = (ContaCorrente)c4;
                Console.WriteLine("Total do valor do serviço descontado: " + ct.DescontaServico(valor).ToString("C"));

            }
            else
            {
                Console.WriteLine("Taxa de serviço isenta!!!");
            }
            */

            //Downcast com as: 
            ContaCorrente ct = f as ContaCorrente;

            if (ct != null)
            {

                Console.WriteLine("Total do valor do serviço descontado: " + ct.DescontaServico(valor).ToString("C"));

            }
            else
            {
                Console.WriteLine("Taxa de serviço isenta!!!");
            }
        }
    }
}
