using System;
using System.Diagnostics;
using System.Net.Http;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        List<string> links = new List<string>
        {
            "https://learn.microsoft.com/en-us/dotnet/csharp/",
            "https://www.w3schools.com/",
            "https://www.geeksforgeeks.org/",
            "https://blog.submain.com/c-documentation-start-finish-guide/"
        };

        // Non-async
        var stopwatch = Stopwatch.StartNew();
        RetrieveData(links);
        stopwatch.Stop();
        Console.WriteLine($"Non-async total time: {stopwatch.ElapsedMilliseconds} ms");

        // Async
        stopwatch.Restart();
        RetrieveDataAsync(links);
        stopwatch.Stop();
        Console.WriteLine($"Async total time: {stopwatch.ElapsedMilliseconds} ms");
    }

    public static void RetrieveData(List<string> links)
    {
        HttpClient client = new HttpClient();
        foreach (var link in links)
        {
            client.GetStringAsync(link).Wait();
        }
    }
    public static async Task RetrieveDataAsync(List<string> links)
    {
        HttpClient client = new HttpClient();
        List<Task<string>> tasks = new List<Task<string>>();
        foreach (string link in links)
        {
            tasks.Add(client.GetStringAsync(link));
        }
        await Task.WhenAll(tasks);
    }

}
