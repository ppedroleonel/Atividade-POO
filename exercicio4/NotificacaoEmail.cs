using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AtividadePOOHeranca
{
    public class NotificacaoEmail : Notificacao
    {
        public override void Enviar()
        {
            Console.WriteLine("Notificação enviada por email");
            Console.WriteLine($"Conteudo da Mensagem: {Mensagem}");
        }
    }
}