using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AtividadePOOHeranca
{
    public class NotificacaoPush : Notificacao
    {
        public override void Enviar()
        {
            Console.WriteLine("Notificacao enviada por push");
            Console.WriteLine($"Conteudo da Mensagem: {Mensagem}");
        }
    }
}