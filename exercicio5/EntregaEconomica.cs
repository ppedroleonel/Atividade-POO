using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AtividadePOOHeranca
{
    public class EntregaEconomica : Entrega
    {
        public EntregaEconomica(double distancia) : base(distancia)
        {
        }

        public override decimal CalcularFrete()
        {
            // taxa de 1 real por KM
            return (decimal)Distancia * 1m;
        }
    }
}