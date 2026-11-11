using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AtividadePOOHeranca
{
    public class Cachorro : Animal
    {
        public Cachorro(string nome) : base(nome)
        {
        }

        public override string ExibirSom()
        {
            return "Latido";
        }
    }
}