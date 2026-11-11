using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AtividadePOOHeranca
{
    public abstract class ProdutoDigital
    {
        // atributo
        public string? Nome {get; set;}
        public decimal? Preco {get; set;}
        
        //construtor
        public ProdutoDigital(string nome, decimal preco)
        {
            Nome = nome;
            Preco = preco;
        }
    }
}