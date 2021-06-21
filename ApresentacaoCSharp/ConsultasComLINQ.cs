using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApresentacaoCSharp
{
    public class ConsultasComLINQ
    {
        
        public void MostraExtratoTitular(int numConta)
        {
            List<GeradorDeExtrato> operacao = ListaExtrato.listaExtrato;
            var resultado = from op in operacao where op.NumConta == numConta select op;
            foreach (var extrato in resultado)
            {
                Console.WriteLine("Conta: " + extrato.NumConta +
                    "\nTitular: " + extrato.Titular +
                    "\nOperação: " + extrato.Operacao + 
                    "\nSaldo Anterior: " + extrato.SaldoAnterior + 
                    "\nValor:  " + extrato.Valor + 
                    "\nSaldo Atual: " + extrato.SaldoAtual +
                    "\nHorario: " + extrato.Horario + "\n");
            }
        }

        public void MostraJoin()
        {

        }

        public void MostraTotalSaques(int numConta)
        {
            List<GeradorDeExtrato> operacao = ListaExtrato.listaExtrato;
            var resultado = from op in operacao where op.NumConta == numConta && op.Operacao == "Saque" select op;
            double total = resultado.Sum(ex => ex.Valor);
            Console.WriteLine("Total de saques realizados: " + total);
        }

        public void MostraTotalDepositos(int numConta)
        {
            List<GeradorDeExtrato> operacao = ListaExtrato.listaExtrato;
            var resultado = from op in operacao where op.NumConta == numConta && op.Operacao == "Deposito" select op;
            double total = resultado.Sum(ex => ex.Valor);
            Console.WriteLine("Total de saques realizados: " + total);
        }

        public void MostraMediaTotalDoSaldo()
        {
            List<Conta> contas = ListaConta.listaContas;
            //var resultado = from ct in contas select ct;
            double media = contas.Average(sd => sd.Saldo);
            Console.WriteLine("Medi total do Saldo de todas as contas: " + media);
        }
    }
}
