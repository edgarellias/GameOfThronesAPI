using GameOfThronesAPI.Models;
using System.Text.Json;

using (HttpClient client = new HttpClient())
{
    Console.WriteLine("Escolha o id de personagem que deseja verificar os dados: ");
    int escolha = Console.Read();
   
        if (escolha != 0)
        {
        try
        {
            string json = await client.GetStringAsync($"https://www.anapioficeandfire.com/api/characters/{escolha}");
            Personagem personagem = JsonSerializer.Deserialize<Personagem>(json);
            personagem.ExibirDetalhes();
        }catch (Exception ex)
        {
            Console.WriteLine($"Ocorreu um erro: {ex.Message}");
        }
        } else
    {
        Console.WriteLine($"Escolha um número válido");
    }
  

}