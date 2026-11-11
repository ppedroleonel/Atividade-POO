using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace AtividadePOOHeranca
{
    public class Smartphone : Equipamento
    {   
        public int Armazenamento {get; set;}
        public Smartphone(string modelo, int numeroserie, int armazenamento) : base(modelo, numeroserie)
        {
            Armazenamento = armazenamento;
        }

        public override void ExibirInformacoes()
        {
            base.ExibirInformacoes();
            Console.WriteLine($"Armazenamento: {Armazenamento}gb");
        }
    }
}