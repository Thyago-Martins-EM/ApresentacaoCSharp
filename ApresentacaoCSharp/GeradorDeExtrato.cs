using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApresentacaoCSharp
{
    class GeradorDeExtrato 
    {

        public double Valor { get; set; }
        public int NumConta { get; set; }
        public double SaldoAnterior { get; set; }
        public string Operacao { get; set; }
        public string Titular { get; set; }
        public double SaldoAtual { get; set; }
        public string Horario { get; set; }

        List<GeradorDeExtrato> ex = new List<GeradorDeExtrato>();
        public void DadosDaOperacao(GeradorDeExtrato extrato)
        {
            DateTime agora = DateTime.Now;
            this.Horario = String.Format("{0: d/M/yyyy HH:mm:ss}",agora);
            ex.Add(extrato);
            //Criar Classe ListaExtrato para incluir alguns valores para realizar teste LINQ
        }

        public void MostraRelatorio()
        {
            ex.ForEach(le => Console.WriteLine("Conta: " + le.NumConta
                                               + "\nTitular: " + le.Titular
                                               + "\nOperação: " + le.Operacao
                                               + "\nSaldo Anterior: " + le.SaldoAnterior.ToString("F")
                                               + "\nValor:  " + le.Valor.ToString("F")
                                               + "\nSaldo Atual: " + le.SaldoAtual.ToString("F")
                                               + "\nHorario: " + le.Horario
                                              )
            );
        }
  
    }
}
