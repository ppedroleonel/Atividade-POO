using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AtividadePOOHeranca
{
    public abstract class Entrega
    {
        public double Distancia {get; set;}

        // construtor
        public Entrega(double distancia)
        {
            Distancia = distancia;
        }

        public abstract decimal CalcularFrete();
    }
}