using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace AtividadePOOHeranca
{
    public class Hospedagem : Servico, IContratavel, ICancelavel
    {
        public Hospedagem(string nome) : base(nome)
        {
        }

        public void Cancelar()
        {
            Console.WriteLine($"Serviço de Hospedagem '{Nome}' cancelado. Estorno em processamento.");
        }

        public void Contratar()
        {
            Console.WriteLine($"Serviço de Hospedagem '{Nome}' contratado com sucesso! Reserva confirmada.");
        }
    }
}