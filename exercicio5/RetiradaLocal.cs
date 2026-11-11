using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AtividadePOOHeranca
{
    public class RetiradaLocal : Entrega
    {
        public RetiradaLocal(double distancia = 0) : base(distancia)
        {
        }

        public override decimal CalcularFrete()
        {
            // taxa gratuita para retirada local
            return 0.00m;
        }
    }
}