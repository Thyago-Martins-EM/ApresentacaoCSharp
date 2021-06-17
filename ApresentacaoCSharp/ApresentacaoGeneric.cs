﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApresentacaoCSharp
{
    public class ApresentacaoGeneric
    {
        //Repensar ideia de classe ou metodo Generic
        ContaCorrente c1 = new ContaCorrente();
        public void MostraValorServico<T>(T conta, double valor)
        {
            if (conta is ContaCorrente)
            {
                Console.WriteLine("Total do valor do serviço descontado: " + this.c1.DescontaServico(valor).ToString("C"));
            }
            else
            {
                Console.WriteLine("Taxa de serviço isenta!!!");
            }
        }

    }
}
