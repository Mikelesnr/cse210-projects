using System;
using System.Net.Http;
using System.Text.Json;


class Program
{
    public static async Task Main(string[] args)
    {
        Console.WriteLine("Welcome to bible study app!");

        var prompt = new Prompt();
        string book = prompt.GetPromptText("Please enter bible book name");
        string chapter = prompt.GetPromptText("Please enter chapter");
        string verse = prompt.GetPromptText("Please enter start verse");
        string endVerse = prompt.GetPromptText("Please enter end verse");

        var reference = new Reference(book, chapter, verse, endVerse);
        string url = reference.GetUrl();
        var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };

        using (var client = new HttpClient())
        {

            var endpoint = new Uri(url);
            var result = await client.GetStringAsync(endpoint);

            var responseObject = JsonSerializer.Deserialize<BibleResponse>(result, options);
            String text = responseObject.text;
            Console.Write(text);
        }
    }

    public class BibleResponse
    {
        public string text { get; set; }
        // Add other properties as needed
    }
}