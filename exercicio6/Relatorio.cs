using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace AtividadePOOHeranca
{
    public class Relatorio : IExportavel, IImprimivel
    {
        public void Exportar()
        {
            Console.WriteLine("Relatorio exportado");
        }

        public void Imprimir()
        {
            Console.WriteLine("Relatorio imprimido");
        }
    }
}