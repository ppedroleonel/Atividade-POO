using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AtividadePOOHeranca
{
    public class NotificacaoSMS : Notificacao
    {
        public override void Enviar()
        {
            Console.WriteLine("Notificacao enviada por SMS");
            Console.WriteLine($"Conteudo da Mensagem: {Mensagem}");
        }
    }
}