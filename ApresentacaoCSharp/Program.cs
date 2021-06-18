using System;
using System.Collections.Generic;
using System.Linq;

namespace ApresentacaoCSharp
{
    public class Program
    {

        
        static void Main()
        {
            //Organizar chamadas das classes que vão ser usadas para apresentação

            /*int numConta = 1;
            GeradorDeExtrato dados = new GeradorDeExtrato();
            ListaConta.PreencheListaConta();
            ListaExtrato.PreencheListaExtrato();

            Conta conta = ListaConta.listaContas.FirstOrDefault(lc => lc.Numero == numConta);

            dados.Titular = conta.Titular;
            dados.NumConta = conta.Numero;
            dados.SaldoAnterior = conta.Saldo;
            dados.Valor = 90;
            conta.Deposita(dados.Valor);
            dados.Operacao = nameof(ContaCorrente.Deposita);
            dados.SaldoAtual = conta.Saldo;

            ListaExtrato.listaExtrato.Add(dados);

            ListaExtrato.listaExtrato.ForEach(ex => Console.WriteLine(ex.Operacao + "\n" + ex.Titular + "\n" + ex.NumConta));
            */

            // new ApresentacaoGeneric().MostraValorServico(conta, extrato.Valor);

            //new ApresentaUpDowncasting().RealizaTeste();

            /*Realiza saque e envia a operação para a classe GeradorDeExtrato
            double valor;
            double saldoAnterior;
            string operacao;
            List<Conta> lista = ListaConta.GetContas();
            Conta conta = lista.FirstOrDefault(lc => lc.Numero == 2);
            saldoAnterior = conta.Saldo;
            valor = 100;
            conta.Saca(valor);
            operacao = nameof(ContaCorrente.Saca);
            new GeradorDeExtrato().DadosDaOperacao(valor, saldoAnterior, operacao, conta);

            Console.WriteLine("Conta: " + conta.Numero + "\nTitular: " + conta.Titular + "\nOperação: " + operacao + "\nSaldo Anterior: " + saldoAnterior + "\nValor:  " + valor + "\nSaldo Atual: " + conta.Saldo);
            */

            /*
             Conta c1 = new ContaCorrente();
                c1.Titular = "Thyago";
                double valor = 100.50;
                c1.Deposita(valor);
                var operacao = nameof(ContaCorrente.Deposita);
                new GeradorDeExtrato().DadosDaOperacao(c1.Titular, valor, operacao, c1);
                valor = 50.5;
                c1.Saca(valor);
                operacao = nameof(ContaCorrente.Saca);

                GeradorDeExtrato extrato = new GeradorDeExtrato();
                extratos.ForEach(ls => Console.WriteLine(extrato));
             */
        }
    }
}
