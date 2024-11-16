using System.Text.Json;

namespace ScreenSound_04.Exercicios;

internal class Pessoa
{
    public string Nome { get; set; }
    public int Idade { get; set; }
    public string Email { get; set; }
    /*
     Criar um programa que permite ao usuário inserir informações de uma 
    pessoa (nome, idade, e e-mail), serializa essas informações em formato 
    JSON e salva em um arquivo.
     */

    public void GerarArquivoJson(Pessoa pessoa)
    {
        string json = JsonSerializer.Serialize(pessoa);

        string nomeDoArquivo = "pessoa.json";

        File.WriteAllText(nomeDoArquivo, json);
        Console.WriteLine($"Os dados foram salvos em {nomeDoArquivo}");
    }

    /*
     Criar um programa que lê um arquivo JSON contendo informações de uma 
     pessoa, desserializa essas informações e exibe na tela.
     */
    public void LeArquivo(string fileName)
    {
        if (File.Exists(fileName))
        {
            // Ler conteúdo do arquivo JSON
            string jsonString = File.ReadAllText(fileName);

            // Desserializar JSON para objeto Pessoa
            Pessoa pessoa = JsonSerializer.Deserialize<Pessoa>(jsonString);

            // Exibir informações da pessoa
            Console.WriteLine($"Nome: {pessoa.Nome}");
            Console.WriteLine($"Idade: {pessoa.Idade}");
            Console.WriteLine($"E-mail: {pessoa.Email}");
        }
        else
        {
            Console.WriteLine($"O arquivo {fileName} não existe.");
        }
    }

    /*
     Criar um programa que permite ao usuário inserir informações de várias 
    pessoas, armazena essas informações em uma lista, serializa a lista em 
    formato JSON e salva em um arquivo.
     */

    public void GerarArquivoJsonPessoas(List<Pessoa> pessoas)
    {
        string json = JsonSerializer.Serialize(pessoas);

        string nomeDoArquivo = "pessoas.json";

        File.WriteAllText(nomeDoArquivo, json);
        Console.WriteLine($"Os dados foram salvos em {nomeDoArquivo}");
    }

    /*
     Criar um programa que lê um arquivo JSON contendo informações de várias 
     pessoas, desserializa essas informações em uma lista e exibe na tela.
     */

    public void LeArquivoPessoas(string fileName)
    {
        if (File.Exists(fileName))
        {
            // Ler conteúdo do arquivo JSON
            string jsonString = File.ReadAllText(fileName);

            // Desserializar JSON para objeto Pessoa
            List<Pessoa> pessoas = JsonSerializer.Deserialize<List<Pessoa>>(jsonString);

            foreach (Pessoa pessoa in pessoas)
            {
                Console.WriteLine($"Nome: {pessoa.Nome}");
                Console.WriteLine($"Idade: {pessoa.Idade}");
                Console.WriteLine($"E-mail: {pessoa.Email}");
            }
        }
        else
        {
            Console.WriteLine($"O arquivo {fileName} não existe.");
        }
    }

    /*
     Criar um programa que lê um arquivo JSON contendo informações de várias 
     pessoas, permite ao usuário inserir uma idade e exibe as pessoas com aquela idade.
     */

    public void PessoasComIdadeInformada(string fileName, int idade)
    {
        if (File.Exists(fileName))
        {
            string jsonString = File.ReadAllText(fileName);

            List<Pessoa> pessoas = JsonSerializer.Deserialize<List<Pessoa>>(jsonString).Where(p => p.Idade == idade).ToList();

            if (pessoas.Any())
            {
                Console.WriteLine($"Pessoas com {idade} anos:");

                foreach (Pessoa pessoa in pessoas)
                {
                    Console.WriteLine($"Nome: {pessoa.Nome}");
                    Console.WriteLine($"Idade: {pessoa.Idade}");
                    Console.WriteLine($"E-mail: {pessoa.Email}");
                }
            }
            else
            {
                Console.WriteLine($"Nenhuma pessoa encontrada com {idade} anos.");
            }
        }
        else
        {
            Console.WriteLine($"O arquivo {fileName} não existe.");
        }
    }
}
