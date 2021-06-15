using System;
using System.Collections.Generic;
using System.Linq;

namespace ApresentacaoCSharp
{
    public class Program
    {

        static List<Conta> contas;

        static void Main(string[] args)
        {

            contas = new List<Conta>();

            Conta c1 = new ContaCorrente();
            c1.Titular = "Victor";
            c1.Deposita(700);
            contas.Add(c1);

            Conta c2 = new ContaPoupanca();
            c2.Titular = "Mauricio";
            c2.Deposita(100);
            contas.Add(c2);

            Conta c3 = new ContaCorrente();
            c3.Titular = "Osni";
            c3.Deposita(800);
            contas.Add(c3);

            Conta c4 = new ContaPoupanca();
            c4.Titular = "Pedro";
            c4.Deposita(1000);
            contas.Add(c4);

            foreach (Conta conta in contas)
            {
                Console.WriteLine(conta.Titular +"/n"+ conta.Numero + "/n" + conta.Saldo);
            }
        }
    }
}
