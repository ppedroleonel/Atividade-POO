using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AtividadePOOHeranca
{
    public abstract class Jogo
    {
        // atributo
        public string? Nome {get;set;}
        protected string? Plataforma {get;set;}

        // construtor
        public Jogo(string nome, string plataforma)
        {
            Nome = nome;
            Plataforma = plataforma;
        }

        // metodo
        public virtual void ExibirInfo()
        {
            Console.WriteLine($"Nome: {Nome}");
            Console.WriteLine($"Plataforma: {Plataforma}");
        }
    }
}