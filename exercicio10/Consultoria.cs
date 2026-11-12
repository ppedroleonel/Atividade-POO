using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AtividadePOOHeranca
{
    public class Consultoria : Servico, IContratavel
    {
        public Consultoria(string nome) : base(nome)
        {
        }

        public void Contratar()
        {
            Console.WriteLine($"Serviço de Consultoria '{Nome}' contratado! Reunião inicial agendada.");
        }
    }
}