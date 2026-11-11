using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AtividadePOOHeranca
{
    public class Notificacao
    {
        public string? Mensagem {get; set;}

        public virtual void Enviar()
        {
            Console.WriteLine(Mensagem);
        }
    }
}