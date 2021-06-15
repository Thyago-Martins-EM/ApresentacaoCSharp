using System;
using System.Collections.Generic;
using System.Linq;

namespace ApresentacaoCSharp
{
    public class Program
    {
        static void Main()
        {
            //new ApresentaUpDowncasting().RealizaTeste();

            //List<Conta> lista = ListaConta.GetContas();
            //lista.ForEach(lc => Console.WriteLine(lc.Titular));

            Conta c4 = new ContaCorrente();
            c4.Titular = "Thyago";
            double valor = 100.50;
            c4.Deposita(valor);
            Console.WriteLine("Metodo retornado: ");
        }
    }
}
