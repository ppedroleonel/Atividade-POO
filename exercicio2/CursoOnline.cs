using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AtividadePOOHeranca
{
    public class CursoOnline : ProdutoDigital
    {
        // atributo
        public int CargaHoraria {get;set;}

        // ctor obrigatorio por conta do ProdutoDigital
        // seta oq ele receber no nome e preco q foi criado la na class ProdutoDigital
        public CursoOnline(string nome, decimal preco, int cargaHoraria) : base(nome, preco)
        {
            CargaHoraria = cargaHoraria;
        }
    }
}