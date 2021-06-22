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
        public void ApresentaGeneric()
        {
            bool fimApresentacao = false;
            int num = 0;

            while (!fimApresentacao)
            {

                Console.WriteLine("\nPara apresentar Array e List digite 1 e aperte enter\n" +
                                  "Para apresentar uma siples apresentação com generic digite 2 e aperte enter");
                switch (Convert.ToInt32(Console.ReadLine()))
                {
                    case 1:
                        ComparaArrayComList();//Chama o metodo ComparaArrayComList
                        break;

                    case 2:
                        Console.WriteLine("Selecione um item da lista para verificar que tipo de conta ela pertence:\n");
                        ListaConta.listaContas.ForEach(lc => Console.WriteLine("\tTitular: " + lc.Titular + "\tNumero da Conta: " + lc.Numero + "\tSaldo: " + lc.Saldo.ToString("C")));//Lista os dados da ListaConta
                        num = Convert.ToInt32(Console.ReadLine());
                        Conta conta = ListaConta.listaContas.FirstOrDefault(lc => lc.Numero == num);//Seleciona um registro do tipo conta na ListaConta e guarda em um objeto conta
                        MostraTipoDeConta(conta);//Envia um objeto para o metodo generico MostraTipoDeConta e retorna se a conta é Conta Corrente ou Poupança 
                        break;
                }

                Console.WriteLine("Deseja continuar apresentando a classe generica?\n \tS para sim N para não: ");
                if (Console.ReadLine() == "N")
                    fimApresentacao = true;
            }
        }

        public void ComparaArrayComList()
        {
            
            bool fimTeste = false;
            double valor = 0;

            while (!fimTeste)
            {
                Console.WriteLine("\nRealizar teste de ArrayList digite 1 e aperte enter\n"+
                                  "Para realizar teste de List digite 2 e aperte enter");

                switch (Convert.ToInt32(Console.ReadLine()))
                {
                    case 1:
                        ArrayList arrayServicos = new ArrayList();//ArrayList utiliza uma pratica de conversão de tipo para referencia
                                                                  //boxing para tranformar um tipo em referencia, unboxing para retornar a referencia em um tipo.
                        valor = 3000;
                        arrayServicos.Add("Seguro Carro");                     
                        arrayServicos.Add("Cheque Especial"); //Add está incluindo a mensagem do tipo string no ArrayList, e string sofrerá o boxing.
                        //arrayServicos.Add(valor);
                        //Um dos problemas do ArrayList é que nele pode ser incluído mais de um tipo, que ele não acusa erro,
                        //Mas ao realizar a leitura ele vai gerar uma exceção e parar a aplicação.
                        
                        foreach (string i in arrayServicos)
                        {
                            Console.WriteLine(i);//ao realizar a leitura é feito o unboxing
                        }
                        //Para evitar o processo de boxing e um boxing pode ser feito uma classe generica para poder gerar a lista.
                        //O mais indicado é utilizar o List ao invés do ArrayList, devido List ja ser uma classe generic.
                        break;

                    case 2:
                        List<string> servicos = new List<string>();
                        //List faz parte das Collections.Generic, as classes pertencentes a esse namespace utilizam da generic para
                        //coleções mais seguras, fortimente tipadas e de forma mais performaticas. Utilizar essas classes para gerir
                        //coleções é indicado pois é utilizado pouquissimo codigo e se tem a disposição vários metodos que garantem
                        //seguraça e performace.
                        servicos.Add("Cartão de Credito");
                        servicos.Add("Emprestimo");
                        servicos.Add("Cheque Especial");
                        servicos.ForEach(ls => Console.WriteLine(ls));
                        //servicos.Add(1);
                    break;
                }

                Console.WriteLine("\nDeseja continuar apresentando ArrayList e List?\n \tS para sim N para não: ");
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
