using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApresentacaoCSharp
{
    class ApresentacaoGeneric
    {
        static public List<T> CriaLista<T>(params T[] pars)
        {
            List<T> lista = new List<T>();
            foreach(T elem in pars)
            {
                lista.Add(elem);
            }

            return lista;
        }
    }
}
