using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AtividadePOOHeranca
{
    public class Gato : Animal
    {
        public Gato(string nome) : base(nome)
        {
        }

        public override string ExibirSom()
        {
            return "miado";
        }
    }
}