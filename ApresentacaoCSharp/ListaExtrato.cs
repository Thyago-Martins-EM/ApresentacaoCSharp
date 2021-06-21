using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApresentacaoCSharp
{
    public class ListaExtrato
    {
        public static List<GeradorDeExtrato> listaExtrato = new List<GeradorDeExtrato>();
        public static void PreencheListaExtrato()
        {

            GeradorDeExtrato dados1 = new GeradorDeExtrato();
            dados1.NumConta = 1;
            Conta conta = ListaConta.listaContas.FirstOrDefault(lc => lc.Numero == dados1.NumConta);

            dados1.Titular = conta.Titular;
            dados1.NumConta = conta.Numero;
            dados1.SaldoAnterior = conta.Saldo;
            dados1.Valor = 30;
            conta.Deposita(dados1.Valor);
            dados1.Operacao = "Deposito";
            dados1.SaldoAtual = conta.Saldo;
            dados1.HoraEvento();
            listaExtrato.Add(dados1);

            GeradorDeExtrato dados2 = new GeradorDeExtrato();
            dados2.NumConta = 1;
            dados2.Titular = conta.Titular;
            dados2.NumConta = conta.Numero;
            dados2.SaldoAnterior = conta.Saldo;
            dados2.Valor = 90;
            conta.Saca(dados2.Valor);
            dados2.Operacao = "Saque";
            dados2.SaldoAtual = conta.Saldo;
            dados2.HoraEvento();
            listaExtrato.Add(dados2);

            GeradorDeExtrato dados3 = new GeradorDeExtrato();
            dados3.NumConta = 1;
            dados3.Titular = conta.Titular;
            dados3.NumConta = conta.Numero;
            dados3.SaldoAnterior = conta.Saldo;
            dados3.Valor = 90;
            conta.Saca(dados2.Valor);
            dados3.Operacao = "Saque";
            dados3.SaldoAtual = conta.Saldo;
            dados3.HoraEvento();
            listaExtrato.Add(dados3);
        }
    }
}
