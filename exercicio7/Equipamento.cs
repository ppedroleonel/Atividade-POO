using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AtividadePOOHeranca
{
    public abstract class Equipamento
    {
        public string? Modelo {get; set;}
        protected int NumeroSerie {get; set;}

        // construtor
        public Equipamento(string modelo, int numeroserie)
        {
            Modelo = modelo;
            NumeroSerie = numeroserie;
        }

        public virtual void ExibirInformacoes()
        {
            Console.WriteLine($"Modelo: {Modelo}");
            Console.WriteLine($"Numero de Serie: {NumeroSerie}");
        }
    }
}