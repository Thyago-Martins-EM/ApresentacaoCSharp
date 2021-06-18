using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApresentacaoCSharp
{
    public class GeradorDeExtrato 
    {
        public double Valor { get; set; }
        public int NumConta { get; set; }
        public double SaldoAnterior { get; set; }
        public string Operacao { get; set; }
        public string Titular { get; set; }
        public double SaldoAtual { get; set; }
        public string Horario { get; set; }

        public string HoraEvento()
        {
            DateTime agora = DateTime.Now;
            this.Horario = String.Format("{0: d/M/yyyy HH:mm:ss}",agora);
            return this.Horario;
            //Criar Classe ListaExtrato para incluir alguns valores para realizar teste LINQ
        }

        public void MostraRelatorio()
        {
            /*ex.ForEach(le => Console.WriteLine("Conta: " + le.NumConta
                                               + "\nTitular: " + le.Titular
                                               + "\nOperação: " + le.Operacao
                                               + "\nSaldo Anterior: " + le.SaldoAnterior.ToString("F")
                                               + "\nValor:  " + le.Valor.ToString("F")
                                               + "\nSaldo Atual: " + le.SaldoAtual.ToString("F")
                                               + "\nHorario: " + le.Horario + "\n"
                                              )
            );*/
        }
  
    }
}
