using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApresentacaoCSharp
{
    public class ApresentacaoGeneric
    {
        //Repensar ideia de classe ou metodo Generic
        
        public void ApresentaGeneric()
        {
            bool fimApresentacao = false;
            int num = 0;

            while (!fimApresentacao)
            {

                Console.WriteLine("\nPara apresentar generic com Array e List digite 1 e aperte enter\n" +
                                  "Para apresentar uma siples apresentação com generic digite 2 e aperte enter");
                switch (Convert.ToInt32(Console.ReadLine()))
                {
                    case 1:
                        ComparaArrayComList();
                        break;

                    case 2:
                        Console.WriteLine("Selecione um item da lista para verificar que tipo de conta ela pertence:\n");
                        ListaConta.listaContas.ForEach(lc => Console.WriteLine("\tTitular: " + lc.Titular + "\tNumero da Conta: " + lc.Numero + "\tSaldo: " + lc.Saldo.ToString("C")));
                        num = Convert.ToInt32(Console.ReadLine());
                        Conta conta = ListaConta.listaContas.FirstOrDefault(lc => lc.Numero == num);
                        MostraTipoDeConta(conta);
                        break;
                }

                Console.WriteLine("Deseja continuar apresentando a classe generica?\n \tS para sim N para não: ");
                if (Console.ReadLine() == "N")
                    fimApresentacao = true;
            }
        }

        public void ComparaArrayComList()
        {
            List<string> servicos = new List<string>();
            ArrayList arrayServicos = new ArrayList();
            bool fimTeste = false;
            double valor = 0;

            while (!fimTeste)
            {
                Console.WriteLine("\nRealizar teste de ArrayList digite 1 e aperte enter\n"+
                                  "Para realizar teste de List digite 2 e aperte enter");

                switch (Convert.ToInt32(Console.ReadLine()))
                {
                    case 1:
                        
                        valor = 3000;
                        arrayServicos.Add("Seguro Carro");                     
                        arrayServicos.Add("Cheque Especial");
                        //arrayServicos.Add(valor);

                        foreach(string i in arrayServicos)
                        {
                            Console.WriteLine(i);
                        }
                    break;

                    case 2:
                        servicos.Add("Cartão de Credito");
                        servicos.Add("Emprestimo");
                        servicos.Add("Cheque Especial");
                        servicos.ForEach(ls => Console.WriteLine(ls));
                        //servicos.Add(1);
                    break;
                }

                Console.WriteLine("Deseja continuar apresentando Upcast e Downcast?\n \tS para sim N para não: ");
                if (Console.ReadLine() == "N")
                    fimTeste = true;
            }
            
        }
        public void MostraTipoDeConta<T>(T objeto)
        {
            if (objeto is ContaPoupanca)
            {
                Console.WriteLine("É uma conta Poupança");
            }
            else if (objeto is ContaCorrente)
            {
                Console.WriteLine("É uma conta Corrente");
            }
            else
            {
                Console.WriteLine("O objeto não é do tipo conta!!!");
            }
        }
    }
}
