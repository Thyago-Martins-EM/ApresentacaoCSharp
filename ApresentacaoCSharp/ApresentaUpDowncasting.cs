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
            bool fimOperacao = false;
            int num = 0;
            

            while (!fimOperacao)
            {

                GeradorDeExtrato dadosExtrato = new GeradorDeExtrato();
                double valor;

                Console.WriteLine("Escolha uma das contas a qual deseja operar:");
                ListaConta.listaContas.ForEach(lc => Console.WriteLine("\tTitular: " + lc.Titular + "\tNumero da Conta: " + lc.Numero +"\tSaldo: " + lc.Saldo));
                num = Convert.ToInt32(Console.ReadLine());
                Conta conta = ListaConta.listaContas.FirstOrDefault(lc => lc.Numero == num);
                dadosExtrato.Titular = conta.Titular;
                dadosExtrato.NumConta = num;
                dadosExtrato.SaldoAnterior = conta.Saldo;

                Console.WriteLine("\nConta escolhida foi do titular: " + conta.Titular);

                Console.WriteLine("\nQual operação deseja realizar?\n"+"\tS para Saque\n"+"\tD para Deposito\n"+"\tT para Transferência\n"+"\tOu digite E para encerrar");
                string operacao = Console.ReadLine();

                switch (operacao)
                {
                    case "S":
                        Console.WriteLine("Informeo valor a ser sacado:");
                        valor = Convert.ToInt32(Console.ReadLine());
                        conta.Saca(valor);
                        ListaConta.listaContas.ForEach(lc => Console.WriteLine("Titular: "+ lc.Titular +"\nSaldo: " + lc.Saldo));
                        dadosExtrato.Operacao = "Saque";
                        dadosExtrato.Valor = valor;
                        dadosExtrato.SaldoAtual = conta.Saldo;
                        dadosExtrato.HoraEvento();
                        ListaExtrato.listaExtrato.Add(dadosExtrato);
                        break;

                    case "D":
                        Console.WriteLine("Informeo valor a ser depositado:");
                        valor = Convert.ToInt32(Console.ReadLine());
                        conta.Deposita(valor);
                        ListaConta.listaContas.ForEach(lc => Console.WriteLine("Titular: " + lc.Titular + "\nSaldo: " + lc.Saldo));
                        dadosExtrato.Operacao = "Deposito";
                        dadosExtrato.Valor = valor;
                        dadosExtrato.SaldoAtual = conta.Saldo;
                        dadosExtrato.HoraEvento();
                        ListaExtrato.listaExtrato.Add(dadosExtrato);
                        break;

                    // Para utilizar o metodo transferencia é utilizado a tecnica de Downcast pois a variavél conta
                    // recebu um objeto ContaCorrente que foi aplicado Upcast para que restringisse o objeto
                    // a somente as opções da classe Conta.
                    case "T":

                        //Realizando tecnica de Downcast com AS para realizar a conversão.
                        ContaCorrente ct = conta as ContaCorrente;

                        if (ct != null)
                        {
                            Console.WriteLine("Informer o numero da conta a qual deseja realizar a tranferência:");
                            num = Convert.ToInt32(Console.ReadLine());
                            Conta destino = ListaConta.listaContas.FirstOrDefault(lc => lc.Numero == num);
                            Console.WriteLine("Informe o valor a ser transferido: ");
                            valor = Convert.ToDouble(Console.ReadLine());
                            ct.Transferencia(valor, destino);
                            ListaConta.listaContas.ForEach(lc => Console.WriteLine("Titular: " + lc.Titular + "\nSaldo: " + lc.Saldo));
                            dadosExtrato.Operacao = "Transferência";
                            dadosExtrato.Valor = valor;
                            dadosExtrato.SaldoAtual = conta.Saldo;
                            dadosExtrato.HoraEvento();
                            ListaExtrato.listaExtrato.Add(dadosExtrato);
                        }
                        else
                        {
                            Console.WriteLine("O tipo dessa conta não permite transferencias");
                        }

                        break;

                    default:
                        break;
                }

                Console.WriteLine("Deseja continuar apresentando Upcast e Downcast?\n \tS para sim N para não: ");
                if (Console.ReadLine() == "N")
                    fimOperacao = true;
            }
        }
    }
}
