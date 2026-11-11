using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AtividadePOOHeranca
{
    public class BancoDados : IArmazenavel
    {
        public string? Conteudo {get;set;}
        public void Ler()
        {
            Console.WriteLine(Conteudo);
        }

        public void Salvar(string conteudo)
        {
            Conteudo = conteudo;
            Console.WriteLine("Conteudo salvo em um .sql");
        }
    }
}