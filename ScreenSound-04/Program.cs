using ScreenSound_04.Modelos;
using ScreenSound_04.Filtros;
using System.Text.Json;
using ScreenSound_04.Exercicios;

using (HttpClient client = new HttpClient())
{
    try
    {
        string respostaJson = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");
        var musicas = JsonSerializer.Deserialize<List<Musica>>(respostaJson)!; // o JSON será capturado e convertido em um objeto manipulável no C#
        musicas[0].ExibirFichaTecnica();
        LinqFilter.FiltrarMusicasEmCSharp(musicas);
        LinqFilter.FiltrarTodosOsGenerosMusicais(musicas);
        LinqFilter.FiltrarArtistasPorGeneroMusical(musicas, "rock");
        LinqFilter.FiltrarMusicasDeUmArtista(musicas, "Michel Teló");
        LinkOrder.ExibirListaDeArtistasOrdenadas(musicas);
        LinqFilter.FiltrarMusicasPeloAno(musicas, 2012);

        var musicasPreferidasDoDaniel = new MusicasPreferidas("Daniel");
        musicasPreferidasDoDaniel.AdicionarMusicasFavoritas(musicas[1]);
        musicasPreferidasDoDaniel.AdicionarMusicasFavoritas(musicas[377]);
        musicasPreferidasDoDaniel.AdicionarMusicasFavoritas(musicas[4]);
        musicasPreferidasDoDaniel.AdicionarMusicasFavoritas(musicas[6]);
        musicasPreferidasDoDaniel.AdicionarMusicasFavoritas(musicas[1467]);

        musicasPreferidasDoDaniel.ExibirMusicasFavoritas();
        musicasPreferidasDoDaniel.GerarArquivoJson();
        musicasPreferidasDoDaniel.GerarDocumentoTXTComAsMusicasFavoritas();


    }
    catch (Exception ex)
    {
        Console.WriteLine($"Temos um problema: {ex.Message}");
    }
}

//EXERCÍCIOS

List<int> lista1 = new List<int> { 1, 2, 2, 3, 4, 5, 1 };
List<int> lista2 = new List<int> { 3, 4, 5, 6, 7 };

LinkConsult.NumerosUnicos(lista1);
LinkConsult.NumerosComuns(lista1, lista2);

List<Livro> livros = new List<Livro>();
livros.Add(new Livro("Aprendendo LINQ", "João Silva", 2005));
livros.Add(new Livro("Programação em C#", "Ana Oliveira", 2010));
livros.Add(new Livro("Algoritmos e Estruturas de Dados", "Carlos Santos", 1998));
livros.Add(new Livro("Introdução à Inteligência Artificial", "Mariana Costa", 2021));
livros.Add(new Livro("Design Patterns", "Paulo Rocha", 2002));

LinkConsult.TitulosLivros(livros);

List<Produto> produtos = new List<Produto>
{
   new Produto { Nome = "Laptop", Preco = 1200 },
   new Produto { Nome = "Smartphone", Preco = 800 },
   new Produto { Nome = "Tablet", Preco = 500 },
   new Produto { Nome = "Câmera", Preco = 300 }
};

LinkConsult.precoMedioProdutos(produtos);

List<string> palavras = new List<string> { "cachorro", "gato", "elefante", "leão", "cobra" };

LinkConsult.PalavrasFiltradas(palavras);

LinkConsult.NumerosPares(lista2);

Pessoa pessoa = new Pessoa();
Console.Write("Nome: ");
pessoa.Nome = Console.ReadLine();
Console.Write("Idade: ");
pessoa.Idade = int.Parse(Console.ReadLine());
Console.Write("E-mail: ");
pessoa.Email = Console.ReadLine();

pessoa.GerarArquivoJson(pessoa);

List<Pessoa> pessoas = new List<Pessoa>();

while (true)
{
    Pessoa novaPessoa = new Pessoa();
    Console.Write("Digite o nome (ou 'sair' para encerrar): ");
    string nome = Console.ReadLine();

    if (nome.ToLower() == "sair")
        break;

    novaPessoa.Nome = nome;

    Console.Write("Digite a idade: ");
    novaPessoa.Idade = int.Parse(Console.ReadLine());

    Console.Write("Digite o e-mail: ");
    novaPessoa.Email = Console.ReadLine();

    pessoas.Add(novaPessoa);
}

pessoa.GerarArquivoJsonPessoas(pessoas);

/*
Código         Descrição
 200       OK - Requisição bem-sucedida
 201	   Created - Recurso criado com sucesso
 204	   No Content - Sem conteúdo para retornar
 400	   Bad Request - Requisição inválida
 401	   Unauthorized - Não autorizado
 403	   Forbidden - Acesso proibido
 404	   Not Found - Recurso não encontrado
 500	   Internal Server Error - Erro interno do servidor
 502	   Bad Gateway - Gateway inválido
 503	   Service Unavailable - Serviço indisponível

mais códigos aqui https://developer.mozilla.org/pt-BR/docs/Web/HTTP/Status

Desserializamos os dados recebidos em um formato adequado para manipulação em
nosso código. A serialização nos permite converter os dados recebidos em um 
formato como JSON em objetos que podemos trabalhar em nosso programa, 
facilitando a manipulação e extração das informações relevantes.
 */