
namespace ScreenSound_04.Exercicios;

/*
 o uso do LINQ no C# oferece uma sintaxe elegante e eficaz para consultas e 
manipulação de dados, tornando o código mais legível, conciso e fácil de manter
 */
internal class LinkConsult
{
    /*
     Dada uma lista de números, criar uma consulta LINQ para retornar apenas 
     os elementos únicos da lista.
     */
    public static void NumerosUnicos(List<int> numeros)
    {
        var numerosUnicos = numeros.Distinct();

        Console.WriteLine("\nNúmeros únicos na lista:");
        foreach (var numero in numerosUnicos)
        {
            Console.WriteLine($"- {numero}");
        }
    }

    /*
     Dadas duas listas de números, criar uma consulta LINQ para retornar uma 
     lista que contenha apenas os números que estão presentes em ambas as listas.
     */
    public static void NumerosComuns(List<int> lista1, List<int> lista2)
    {
        var numerosComuns = lista1.Intersect(lista2);

        Console.WriteLine("\nNúmeros presentes em ambas as listas:");
        foreach (var numero in numerosComuns)
        {
            Console.WriteLine($"- {numero}");
        }
    }

    /*
     Dada uma lista de livros com título, autor e ano de publicação, criar 
    uma consulta LINQ para retornar uma lista com os títulos dos livros 
    publicados após o ano 2000, ordenados alfabeticamente.
     */
    public static void TitulosLivros(List<Livro> livros)
    {
        var titulosLivros = livros
             .Where(l => l.AnoDePublicacao > 2000)
             .OrderBy(l => l.Titulo)
             .Select(l => l.Titulo);


        Console.WriteLine("\nTítulos de livros publicados após 2000, ordenados alfabeticamente:");
        foreach (var livro in titulosLivros)
        {
            Console.WriteLine($"- {livro}");
        }
    }

    /*
    Dada uma lista de produtos com nome e preço, criar uma consulta LINQ para
    calcular o preço médio dos produtos.
     */
    public static void precoMedioProdutos(List<Produto> produtos)
    {
        var precoMedioProdutos = produtos.Average(p => p.Preco);

        Console.WriteLine("\nPreço médio dos produtos: " + precoMedioProdutos);
    }

    /*
     Dada uma lista de strings, criar uma consulta LINQ para ordenar as 
     palavras por comprimento e retornar apenas aquelas que têm mais de 3 caracteres.
     */

    public static void PalavrasFiltradas(List<string> palavras)
    {
        var palavrasFiltradas = palavras
                                .Where(p => p.Length > 3)
                                .OrderBy(p => p.Length);


        Console.WriteLine("\nPalavras com mais de 3 caracteres, ordenadas por comprimento:");
        foreach (var palavra in palavrasFiltradas)
        {
            Console.WriteLine($"- {palavra}");
        }
    }

    /*
     Dada uma lista de inteiros, criar uma consulta LINQ para retornar apenas
     os números pares.
     */

    public static void NumerosPares(List<int> numeros)
    {
        var numerosPares = numeros.Where(n => n%2 == 0);


        Console.WriteLine("\nNúmeros pares:");
        foreach (var numero in numerosPares)
        {
            Console.WriteLine($"- {numero}");
        }
    }
}
