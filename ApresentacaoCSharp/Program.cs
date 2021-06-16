using System;
using System.Collections.Generic;
using System.Linq;

namespace ApresentacaoCSharp
{
    public class Program
    {

        
        static void Main()
        {
            int numConta = 2;
            GeradorDeExtrato extrato = new GeradorDeExtrato();

            List<Conta> lista = ListaConta.GetContas();
            Conta conta = lista.FirstOrDefault(lc => lc.Numero == numConta);
            extrato.SaldoAnterior = conta.Saldo;
            double valor = 100;
            conta.Saca(valor);
            extrato.NumConta = numConta;
            extrato.Titular = conta.Titular;
            extrato.Operacao = nameof(ContaCorrente.Saca);
            extrato.SaldoAtual = conta.Saldo;
            extrato.DadosDaOperacao();

        }
    }
}
