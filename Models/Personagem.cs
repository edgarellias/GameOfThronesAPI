
using System.Text.Json.Serialization;

namespace GameOfThronesAPI.Models;

internal class Personagem
{

    [JsonPropertyName("name")]
    public string? Nome { get; set; }
    [JsonPropertyName("gender")]
    public string? Genero { get; set; }
    [JsonPropertyName("born")]
    public string? DataNascimento { get; set; }
    [JsonPropertyName("died")]
    public string? DataMorte { get; set; }
    [JsonPropertyName("titles")]
    public List<string>? Titulos { get; set; }


    public void ExibirDetalhes()
    {
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Gênero: {Genero}");
        Console.WriteLine($"Data de nascimento: {DataNascimento}");
        Console.WriteLine($"Data de morte: {DataMorte}");
        Console.WriteLine("Titulos: ");
        foreach ( string item in Titulos)
        {
            Console.WriteLine(item);
        }

    }

}
