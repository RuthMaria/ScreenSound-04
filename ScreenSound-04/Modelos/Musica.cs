using System.Text.Json.Serialization;

namespace ScreenSound_04.Modelos;

//Modelar e desserializar a classe música
internal class Musica
{
    private string[] tonalidades = { "C", "C#", "D", "Eb", "E", "F", "F#", "G", "Ab", "A", "Bb", "B" };

    // é uma notação de como a coluna está sendo referenciada na API, se não usar essa notação então tem que nomear a propriedade da classe exatamente como está sendo retornado da API
    [JsonPropertyName("song")]
    public string? Nome { get; set; }
    [JsonPropertyName("artist")]
    public string? Artista { get; set; }
    [JsonPropertyName("duration_ms")]
    public int Duracao { get; set; }
    [JsonPropertyName("genre")]
    public string? Genero { get; set; }
    [JsonPropertyName("year")]
    public string? AnoString { get; set; }
    [JsonPropertyName("key")]
    public int Key { get; set; }
    public string Tonalidade
    {
        get
        {
            return tonalidades[Key];
        }
    }


    public int Ano
    {
        get
        {
            return int.Parse(AnoString!);
        }
    }


    public void ExibirFichaTecnica()
    {
        Console.WriteLine($"Artista: {Artista}");
        Console.WriteLine($"Música: {Nome}");
        Console.WriteLine($"Duração em segundos: {Duracao / 1000}");
        Console.WriteLine($"Gênero musical: {Genero}");
        Console.WriteLine($"Tonalidade: {Tonalidade}");
    }
}
