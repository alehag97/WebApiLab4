using KonsumeraWebApi;
using System.Text.Json;

HttpClient client = new()
{
    BaseAddress = new Uri("https://api.github.com/")
};

client.DefaultRequestHeaders.Add("user-agent", "Mozilla/4.0 (compatible; MSIE 6.0; " + "Windows NT 5.2; .NET CLR 1.0.3705;)");

var response = await client.GetAsync("orgs/dotnet/repos");
var content = await response.Content.ReadAsStringAsync();

var repon = JsonSerializer.Deserialize<List<Class1>>(content);

foreach (var repo in repon)
{
    Console.WriteLine($"Name: {repo.Name}");
    Console.WriteLine($"Homepage: {repo.Homepage}");
    Console.WriteLine($"GitHub: {repo.HtmlUrl}");
    Console.WriteLine($"Description: {repo.Description}");
    Console.WriteLine($"Watchers: {repo.Watchers}");
    Console.WriteLine($"Last push: {repo.PuashedAt:yyyy-MM-dd HH:mm:ss}");
    Console.WriteLine();
}