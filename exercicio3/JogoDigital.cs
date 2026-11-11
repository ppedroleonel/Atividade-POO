using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AtividadePOOHeranca
{
    public class JogoDigital : Jogo
    {
        // atributo
        public int EspacoNecessario{get;set;}
        
        public JogoDigital(string nome, string plataforma, int espacoNecessario) : base(nome, plataforma)
        {
            EspacoNecessario = espacoNecessario;
        }

        public override void ExibirInfo()
        {
            base.ExibirInfo();
            Console.WriteLine($"Espaço Necessário: {EspacoNecessario} GB"); 
        }
    }
}