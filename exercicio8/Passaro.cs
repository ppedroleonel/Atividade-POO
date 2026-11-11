using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AtividadePOOHeranca
{
    public class Passaro : Animal
    {
        public Passaro(string nome) : base(nome)
        {
        }

        public override string ExibirSom()
        {
            return "canto";
        }
    }
}