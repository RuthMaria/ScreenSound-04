
namespace ScreenSound_04.Exercicios;

internal class Livro
{
    public Livro(string titulo, string autor, int anoDePublicacao)
    {
        Titulo = titulo;
        Autor = autor;
        AnoDePublicacao = anoDePublicacao;
    }

    public string Titulo { get; set; }
    public string Autor { get; set; }
    public int AnoDePublicacao { get; set; }

}
