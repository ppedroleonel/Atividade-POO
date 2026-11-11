using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AtividadePOOHeranca
{
    public class JogoFisico : Jogo
    {
        public string? TipoMidia {get; set;}
        public JogoFisico(string nome, string plataforma, string tipoMidia) : base(nome, plataforma)
        {
            TipoMidia = tipoMidia;
        }

        public override void ExibirInfo()
        {
            base.ExibirInfo();
            Console.WriteLine($"Tipo de Midia: {TipoMidia}");
        }
    }
}