using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApresentacaoCSharp
{
    //Conferir se classe está criada nos padrões corretos
    public class ListaConta
    {
        public static List<Conta> GetContas()
        {
            var listaConta = new List<Conta>();

            Conta c1 = new ContaCorrente();
            c1.Titular = "Victor";
            c1.Deposita(700);
            listaConta.Add(c1);

            Conta c2 = new ContaPoupanca();
            c2.Titular = "Mauricio";
            c2.Deposita(300);
            listaConta.Add(c2);

            Conta c3 = new ContaCorrente();
            c3.Titular = "Osni";
            c3.Deposita(800);
            listaConta.Add(c3);

            Conta c4 = new ContaPoupanca();
            c4.Titular = "Pedro";
            c4.Deposita(1000);
            listaConta.Add(c4);

            return listaConta;
        }

    }
}
