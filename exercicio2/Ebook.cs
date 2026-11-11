using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AtividadePOOHeranca
{
    public class Ebook : ProdutoDigital
    {
        // atributo
        public int QuantidadePaginas {get;set;}

        // ctor obrigatorio por conta do ProdutoDigital
        // seta oq ele receber no nome e preco q foi criado la na class ProdutoDigital
        public Ebook(string nome, decimal preco, int quantidadePaginas) : base(nome, preco)
        {
            QuantidadePaginas = quantidadePaginas;
        }
    }
}