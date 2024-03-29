﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace ApresentacaoCSharp
{
    public class Program
    {
        static void Main()
        {
            
            ListaConta.PreencheListaConta();
            ListaExtrato.PreencheListaExtrato();
            
            bool fimApp = false;

            Console.WriteLine("\nBem vindo a Apresentação, informe uma das tecnicas que deseja apresentar:\n");
            

            while(!fimApp)
            {
                Console.WriteLine("1: Upcast e Downcast\n2: Classe Generic\n3: LINQ");

                int opcao = Convert.ToInt32(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        new ApresentaUpDowncasting().RealizaTeste();
                    break;

                    case 2:
                        new ApresentacaoGeneric().ApresentaGeneric();
                    break;

                    case 3:
                        new ApresentaLINQ().ApresentaResultados();
                    break;

                    default:
                        Console.WriteLine("Opcao invalida!");
                    break;
                }

                Console.WriteLine("\n\nDeseja continuar apresentando?\n S para sim, N para não: ");
                if (Console.ReadLine() == "N")
                    fimApp = true;
            }

            return;            
        }
    }
}
