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
            int numConta = 1;
            GeradorDeExtrato extrato = new GeradorDeExtrato();

            List<Conta> lista = ListaConta.GetContas();
            Conta conta = lista.FirstOrDefault(lc => lc.Numero == numConta);
            extrato.Titular = conta.Titular;
            extrato.NumConta = conta.Numero;
            extrato.SaldoAnterior = conta.Saldo;
            extrato.Valor = 100;
            conta.Deposita(extrato.Valor);
            extrato.Operacao = nameof(ContaCorrente.Deposita);
            extrato.SaldoAtual = conta.Saldo;
            extrato.DadosDaOperacao(extrato);
            extrato.MostraRelatorio();
           // new ApresentacaoGeneric().MostraValorServico(conta, extrato.Valor);

            //new ApresentaUpDowncasting().RealizaTeste();

        }
    }
}
