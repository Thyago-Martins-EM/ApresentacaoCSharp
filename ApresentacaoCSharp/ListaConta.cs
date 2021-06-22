using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApresentacaoCSharp
{
    public class ListaConta
    {
        public static List<Conta> listaContas = new List<Conta>(); 
        public static void PreencheListaConta()
        {

            Conta c1 = new ContaCorrente();
            c1.Titular = "Victor";
            c1.Deposita(700);
            listaContas.Add(c1);

            Conta c2 = new ContaPoupanca();
            c2.Titular = "Mauricio";
            c2.Deposita(300);
            listaContas.Add(c2);

            Conta c3 = new ContaCorrente();
            c3.Titular = "Osni";
            c3.Deposita(800);
            listaContas.Add(c3);

            Conta c4 = new ContaPoupanca();
            c4.Titular = "Pedro";
            c4.Deposita(1000);
            listaContas.Add(c4);
        }

    }
}
