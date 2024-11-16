using ScreenSound_04.Modelos;

namespace ScreenSound_04.Filtros;

internal class LinkOrder
{
    public static void ExibirListaDeArtistasOrdenadas(List<Musica> musicas)
    {
        var artistasOrdenados = musicas.OrderBy(musica => musica.Artista)
            .Select(musica => musica.Artista).Distinct().ToList();

        Console.WriteLine("Lista de artistas ordenados\n");
        foreach (var artista in artistasOrdenados)
        {
            Console.WriteLine($"- {artista}");
        }
    }
}
