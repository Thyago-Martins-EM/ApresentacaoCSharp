using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApresentacaoCSharp
{
    public class ApresentaLINQ
    {
        

        public void ApresentaResultados()
        {
            bool fimConsulta = false;
            int num = 0;
            ConsultasComLINQ consultas = new ConsultasComLINQ();
            while (!fimConsulta)
            {
                Console.WriteLine("Informe qual consulta deseja realizar: " + 
                                   "\n1- Extrato por titular:"+
                                   "\n2- Total de Saques titular:"+
                                   "\n3- Total de Depositos titular:"+
                                   "\n4- Media total do Saldo das contas:"+
                                   "\n5- Realiza um Join:");
                int opcao = Convert.ToInt32(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        Console.WriteLine("Escolha uma das contas para consultar:");
                        ListaConta.listaContas.ForEach(lc => Console.WriteLine("\tTitular: " + lc.Titular + "\tNumero da Conta: " + lc.Numero + "\tSaldo: " + lc.Saldo));
                        num = Convert.ToInt32(Console.ReadLine());
                        consultas.MostraExtratoTitular(num);
                    break;

                    case 2:
                        Console.WriteLine("Escolha uma das contas para consultar:");
                        ListaConta.listaContas.ForEach(lc => Console.WriteLine("\tTitular: " + lc.Titular + "\tNumero da Conta: " + lc.Numero + "\tSaldo: " + lc.Saldo));
                        num = Convert.ToInt32(Console.ReadLine());
                        consultas.MostraTotalSaques(num);
                    break;

                    case 3:
                        Console.WriteLine("Escolha uma das contas para consultar:");
                        ListaConta.listaContas.ForEach(lc => Console.WriteLine("\tTitular: " + lc.Titular + "\tNumero da Conta: " + lc.Numero + "\tSaldo: " + lc.Saldo));
                        num = Convert.ToInt32(Console.ReadLine());
                        consultas.MostraTotalDepositos(num);
                    break;

                    case 4:
                        consultas.MostraMediaTotalDoSaldo();
                    break;

                    case 5:
                        Console.WriteLine("Não criado ainda");
                    break;

                    default:
                        Console.WriteLine("Opcao invalida!");
                    break;
                }
                Console.WriteLine("Deseja continuar as consultas?\n S para sim, N para não: ");
                if (Console.ReadLine() == "N")
                    fimConsulta = true;
            }
        }
    }
}
