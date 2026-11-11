using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AtividadePOOHeranca
{
    public class Consultoria : IContratavel
    {
        public void Contratar()
        {
            Console.WriteLine("Contratado com sucesso");
        }
    }
}