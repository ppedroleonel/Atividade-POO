using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace AtividadePOOHeranca
{
    public class Hospedagem : IContratavel, ICancelavel
    {
        public void Cancelar()
        {
            Console.WriteLine("contrato cancelado");
        }

        public void Contratar()
        {
            Console.WriteLine("Contratado com sucesso");
        }
    }
}