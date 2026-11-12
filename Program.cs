using AtividadePOOHeranca;

// ? Exibir exercicio 1
// instanciando o carro
// Veiculo carro = new Carro();
// Console.WriteLine("Exercicio 1:");
// pedindo as informacoes
// Console.WriteLine("==============CARRO=============");
// Console.Write("Insira a marca do seu carro: ");
// carro.Marca = Console.ReadLine();

// Console.Write("Insira o modelo do seu carro: ");
// carro.Modelo = Console.ReadLine();
// Console.WriteLine("===========================");

// // exibir as informacoes
// carro.ExibirInformacoes();
// Console.WriteLine("===========================");

// // instanciar a motoca
// Veiculo motoca = new Motocicleta();

// // infos
// Console.WriteLine("============MOTO===============");
// Console.Write("Insira a marca da sua moto: ");
// motoca.Marca = Console.ReadLine();

// Console.Write("Insira o modelo da sua moto: ");
// motoca.Modelo = Console.ReadLine();
// Console.WriteLine("===========================");

// // exibir info
// motoca.ExibirInformacoes();
// Console.WriteLine("===========================");

// Console.WriteLine("Fim do exercicio 1");

// ? Exercicio 2
// Console.WriteLine("===========================");
// Console.WriteLine("Exercicio 2: ");
// Console.WriteLine("===========================");

// Ebook livroOnline = new Ebook("Jogos vorazes", 100m, 200);
// CursoOnline cursoOnline = new CursoOnline("C# raiz do zero", 10m, 40);

// Console.WriteLine("============Livro===============");
// Console.WriteLine($"Nome do livro: {livroOnline.Nome}, Preco: {livroOnline.Preco:C}, Paginas: {livroOnline.QuantidadePaginas}");
// Console.WriteLine("===========================");

// Console.WriteLine("============Curso===============");
// Console.WriteLine($"Nome do curso: {cursoOnline.Nome}, Preco: {cursoOnline.Preco:C}, Carga Horaria: {cursoOnline.CargaHoraria}");
// Console.WriteLine("===========================");

// Console.WriteLine("Fim do exercicio 2");

// ? Exercicio 3
// Console.WriteLine("===========================");
// Console.WriteLine("Exercicio 3: ");
// Console.WriteLine("===========================");

// Console.WriteLine("Jogo Digital: ");
// Jogo jogoOnline = new JogoDigital("CS2", "PC", 60);
// jogoOnline.ExibirInfo();

// Console.WriteLine("===========================");
// Console.WriteLine("Jogo Fisico: ");
// Jogo jogoFisico = new JogoFisico("FIFA 17", "PC, XBOX ONE, PS4", "CD");
// jogoFisico.ExibirInfo();

// Console.WriteLine("===========================");
// Console.WriteLine("Fim do exercicio 3");


// ? Exercicio 4
// Console.WriteLine("===========================");
// Console.WriteLine("Exercicio 4: ");
// Console.WriteLine("===========================");

// string? mensagem;
// Console.Write("Digite a sua mensagem: ");
// mensagem = Console.ReadLine();

// string? meioDaMensagem;

// Console.Write("Qual meio voce quer mandar? ");
// meioDaMensagem = Console.ReadLine().ToUpper();
// Console.WriteLine("===========================");

// if(meioDaMensagem == "SMS")
// {
//     Notificacao notificacaoSMS = new NotificacaoSMS();
//     notificacaoSMS.Mensagem = mensagem;
//     notificacaoSMS.Enviar();
//     Console.WriteLine("===========================");
//     Console.WriteLine("Fim do exercicio 4");
//     return;
// }
// if(meioDaMensagem == "EMAIL")
// {
//     Notificacao notificacaoEmail = new NotificacaoEmail();
//     notificacaoEmail.Mensagem = mensagem;
//     notificacaoEmail.Enviar();
//     Console.WriteLine("===========================");
//     Console.WriteLine("Fim do exercicio 4");
//     return;
// }
// if(meioDaMensagem == "PUSH")
// {
//     Notificacao notificacaoPush = new NotificacaoPush();
//     notificacaoPush.Mensagem = mensagem;
//     notificacaoPush.Enviar();
//     Console.WriteLine("===========================");
//     Console.WriteLine("Fim do exercicio 4");
//     return;
// }
// if(meioDaMensagem != "SMS" && meioDaMensagem != "EMAIL" && meioDaMensagem != "PUSH")
// {
//     Console.WriteLine("Meio de mensagem invalido");
//     Console.WriteLine("===========================");
//     Console.WriteLine("Fim do exercicio 4");
//     return;
// }


// ? exercicio 5
// Console.WriteLine("===========================");
// Console.WriteLine("Exercicio 5: ");
// Console.WriteLine("===========================");
// Console.WriteLine("Insira a distância em km para calcular o frete: ");
// double distanciaKm = Convert.ToDouble(Console.ReadLine()); 
// Console.WriteLine("===========================");
// List<Entrega> entregas = new List<Entrega>
// {
//     new EntregaExpressa(distanciaKm),
//     new EntregaEconomica(distanciaKm),
//     new RetiradaLocal()
// };

// Console.WriteLine("CALCULO DE FRETE");


// foreach (var entrega in entregas)
// {
//     Console.WriteLine($"Modalidade: {entrega.GetType().Name}");
//     Console.WriteLine($"Valor do Frete: {entrega.CalcularFrete():C}");
//     Console.WriteLine("===========================");
// }

// ? exercicio 6
// Console.WriteLine("===========================");
// Console.WriteLine("Exercicio 6: ");
// Console.WriteLine("===========================");

// bool loopContrato = true;

// while (loopContrato)
// {
//     Console.WriteLine("Voce deseja imprimir o contrato? (S/N)");
//     string? respostaContrato = Console.ReadLine()?.ToUpper();
//     if (respostaContrato == "S" || respostaContrato == "SIM")
//     {
//         Contrato contrato = new Contrato();
//         contrato.Imprimir();
//         loopContrato = !loopContrato;
//     }
//     if (respostaContrato == "N" || respostaContrato == "NÃO")
//     {
//         Console.WriteLine("Não imprimimos o contrato");
//         loopContrato = !loopContrato;
//     }
//     if (respostaContrato != "S" && respostaContrato != "N" && respostaContrato != "NÃO" && respostaContrato != "SIM")
//     {
//         Console.WriteLine("Digite uma resposta valida! SIM OU NAO!!");
//     }
// }
// Console.WriteLine("================");

// bool loopRelatorio = true;
// while (loopRelatorio)
// {
//     Console.WriteLine("Voce deseja imprimir o relatorio ou exportar?");
//     string? respostaRelatorio = Console.ReadLine()?.ToUpper();

//     if (respostaRelatorio == "IMPRIMIR")
//     {
//         Relatorio relatorio = new Relatorio();
//         relatorio.Imprimir();
//         loopRelatorio = !loopRelatorio;
//     }
//     else if (respostaRelatorio == "EXPORTAR")
//     {
//         Relatorio relatorio = new Relatorio();
//         relatorio.Exportar();
//         loopRelatorio = !loopRelatorio;
//     }
//     else
//     {
//         Console.WriteLine("Erro! Insira uma opção válida (IMPRIMIR OU EXPORTAR)");
//     }
// }

// ? exercicio 7

// Equipamento note = new Notebook("Gamer", 4070, 16);
// note.ExibirInformacoes();

// Console.WriteLine("================");

// Equipamento celular = new Smartphone("J7", 2010, 500);
// celular.ExibirInformacoes();

// ? Exercicio 8

// List<Animal> animais = new List<Animal>
// {
//     new Cachorro("theo"),
//     new Gato("gatao"),
//     new Passaro("calopsita")
// };

// foreach (var animal in animais)
// {
// Console.WriteLine($"Nome do Animal: {animal.GetType().Name}");
// Console.WriteLine($"Canto: {animal.ExibirSom()}");
// Console.WriteLine("===========================");
// }

// ? Exercicio 9

IArmazenavel txt = new ArquivoTexto();
// txt.Salvar("oiii");
// Console.WriteLine("------------");
// txt.Ler();

// Console.WriteLine("============");

// IArmazenavel sql = new BancoDados();
// sql.Salvar("ID: 201, PRODUTO: carro");
// Console.WriteLine("----------");
// sql.Ler();

// ? exercicio 10

IContratavel servicoContratavel = new Hospedagem("Site da apple");
servicoContratavel.Contratar();

servicoContratavel = new Consultoria("Consultor da apple");
servicoContratavel.Contratar();

ICancelavel servicoCancelavel = new Hospedagem("site do gov");
servicoCancelavel.Cancelar();

