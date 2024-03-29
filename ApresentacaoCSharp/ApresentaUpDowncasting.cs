﻿using System;
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

                Console.WriteLine("\nEscolha uma das contas para consultar:\n");
                Console.WriteLine("Titular\t" + "\tNumero da Conta\t" + "\tSaldo");
                ListaConta.listaContas.ForEach(lc => Console.WriteLine(lc.Titular + "\t\t" + lc.Numero + "\t\t\t" + lc.Saldo.ToString("C")));
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
                        Console.WriteLine("Titular: " + conta.Titular + "\nSaldo: " + conta.Saldo.ToString("C"));
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
                        Console.WriteLine("Titular: " + conta.Titular + "\nSaldo: " + conta.Saldo.ToString("C"));
                        dadosExtrato.Operacao = "Deposito";
                        dadosExtrato.Valor = valor;
                        dadosExtrato.SaldoAtual = conta.Saldo;
                        dadosExtrato.HoraEvento();
                        ListaExtrato.listaExtrato.Add(dadosExtrato);
                        break;

                    // Para utilizar o metodo transferencia é preciso utilizar a tecnica de Downcast, pois a variavél conta
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
                            Console.WriteLine("Titular: " + ct.Titular + "\nSaldo: " + ct.Saldo);
                            dadosExtrato.Operacao = "Transferência";
                            dadosExtrato.Valor = valor;
                            dadosExtrato.SaldoAtual = conta.Saldo;
                            dadosExtrato.HoraEvento();
                            ListaExtrato.listaExtrato.Add(dadosExtrato);
                        }
                        else
                        {
                            Console.WriteLine("\nO tipo dessa conta não permite transferencias");
                        }

                        break;

                    default:
                        break;
                }

                Console.WriteLine("\nDeseja continuar apresentando Upcast e Downcast?\n \tS para sim N para não: ");
                if (Console.ReadLine() == "N")
                    fimOperacao = true;
            }
        }
    }
}
