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
        string _reference = reference.GetScripture();
        var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };

        using (var client = new HttpClient())
        {

            var endpoint = new Uri(url);
            var result = await client.GetStringAsync(endpoint);

            var responseObject = JsonSerializer.Deserialize<BibleResponse>(result, options);
            String text = responseObject.text;
            var scripture = new Scripture(_reference, text);
            // Console.WriteLine(scripture.GetDisplayText());
            bool loop = true;
            while (loop)
            {
                Console.Write("Please press Enter to continue or Q to quit: ");
                ConsoleKeyInfo keyInfo = Console.ReadKey(intercept: true);
                char keyChar = keyInfo.KeyChar;

                if (keyChar == 'q' || keyChar == 'Q')
                {
                    loop = false;
                }
                if (scripture.IsCompletelyHidden())
                {
                    loop = false;
                }

                scripture.HideRandomWords();
                Console.Clear();
                Console.WriteLine(scripture.GetDisplayText());

            }

        }
    }

    public class BibleResponse
    {
        public string text { get; set; }
        // Add other properties as needed
    }
}