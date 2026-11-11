using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AtividadePOOHeranca
{
    public class EntregaExpressa : Entrega
    {
        public EntregaExpressa(double distancia) : base(distancia)
        {
        }

        public override decimal CalcularFrete()
        {
            // taxa de  1.20 por KM + Taxa adicional de 15 reais
            return (decimal)Distancia * 1.50m + 15.00m;
        }
    }
}