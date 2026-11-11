namespace AtividadePOOHeranca
{
    public class Veiculo
    {
        // atributo
        public string? Marca {get; set;}
        public string? Modelo {get; set;}

        // construtor

        // metodo

        public void ExibirInformacoes()
        {
            Console.WriteLine($"Marca: {Marca}");
            Console.WriteLine($"Modelo: {Modelo}");
        }
    }
}