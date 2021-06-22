using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApresentacaoCSharp
{
    public class ConsultasComLINQ
    {

        private List<Servico> servicos = new List<Servico>();
        private List<Conta> contas = ListaConta.listaContas;
        private List<GeradorDeExtrato> operacao = ListaExtrato.listaExtrato;

        public void MostraExtratoTitular(int numConta)
        {
            
            var resultado = from op in operacao where op.NumConta == numConta select op;
            foreach (var extrato in resultado)
            {
                Console.WriteLine("\nConta: " + extrato.NumConta +
                    "\nTitular: " + extrato.Titular +
                    "\nOperação: " + extrato.Operacao + 
                    "\nSaldo Anterior: " + extrato.SaldoAnterior.ToString("C") + 
                    "\nValor:  " + extrato.Valor.ToString("C") + 
                    "\nSaldo Atual: " + extrato.SaldoAtual.ToString("C") +
                    "\nHorario: " + extrato.Horario + "\n");
            }
        }

        public void MostraJoin(int numConta)
        {
            var query = from c in contas
                        join s in servicos
                        on c.Numero equals s.NumConta
                        where c.Numero == numConta
                        select new
                        {
                            nomeContratante = c.Titular,
                            nomeServico = s.Nome,
                            valorServico = s.Valor
                        };

            Console.WriteLine("\nContratante\t" + "Serviço\t" + "\t\tValor do Servico");
            foreach (var resultado in query)
            {
                
                Console.WriteLine(resultado.nomeContratante + "\t\t" + resultado.nomeServico + "\t\t" + resultado.valorServico.ToString("C"));
            }

        }

        public void MostraTotalSaques(int numConta)
        {
            var resultado = from op in operacao where op.NumConta == numConta && op.Operacao == "Saque" select op;
            double total = resultado.Sum(ex => ex.Valor);
            Console.WriteLine("Total de saques realizados: " + total.ToString("C"));
        }

        public void MostraTotalDepositos(int numConta)
        {
            var resultado = from op in operacao where op.NumConta == numConta && op.Operacao == "Deposito" select op;
            double total = resultado.Sum(ex => ex.Valor);
            Console.WriteLine("Total de saques realizados: " + total.ToString("C"));
        }

        public void MostraMediaTotalDoSaldo()
        {
            double media = contas.Average(sd => sd.Saldo);
            Console.WriteLine("Medi total do Saldo de todas as contas: " + media.ToString("C"));
        }

        public void PreencheListaServico()
        {
            Servico servico1 = new Servico();
            servico1.Contratente = "Eu";
            servico1.NumConta = 1;
            servico1.Nome = "Emprestimo";
            servico1.Valor = 1000;
            servicos.Add(servico1);

            Servico servico2 = new Servico();
            servico2.Contratente = "Eu";
            servico2.NumConta = 1;
            servico2.Nome = "Seguro Carro";
            servico2.Valor = 300;
            servicos.Add(servico2);

            Servico servico3 = new Servico();
            servico3.Contratente = "Eu";
            servico3.NumConta = 1;
            servico3.Nome = "Cartao de Credito";
            servico3.Valor = 3000;
            servicos.Add(servico3);
        }
    }
}
