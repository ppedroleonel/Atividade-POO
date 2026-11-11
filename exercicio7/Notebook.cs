using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AtividadePOOHeranca
{
    public class Notebook : Equipamento
    {   
        public int MemoriaRam {get;set;}
        public Notebook(string modelo, int numeroserie, int memoriaram) : base(modelo, numeroserie)
        {
            MemoriaRam = memoriaram;
        }

        public override void ExibirInformacoes()
        {
            base.ExibirInformacoes();
            Console.WriteLine($"Memoria RAM: {MemoriaRam}gb");
        }
    }
}