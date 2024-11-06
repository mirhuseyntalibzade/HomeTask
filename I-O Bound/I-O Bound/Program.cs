using System;
using System.Diagnostics;
using System.Net.Http;
using System.Threading.Tasks;

class Program
{
    static async Task Main()
    {
        #region Task
        /*List<string> links = new List<string>
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
        Console.WriteLine($"Async total time: {stopwatch.ElapsedMilliseconds} ms");*/
        #endregion

        #region Task 2
        // Directories
        Directory.CreateDirectory(@"C:\Users\My Computer\source\repos\DirectoryFile\DirectoryFile\" + "Models");
        Directory.CreateDirectory(@"C:\Users\My Computer\source\repos\DirectoryFile\DirectoryFile\" + "Data");

        // jsonData.json
        string filePath = Path.Combine(@"C:\Users\My Computer\source\repos\DirectoryFile\DirectoryFile\Data", "jsonData.json");
        if (!File.Exists(filePath))
        {
            File.Create(filePath).Close();
        }

        // HttpClient
        using (HttpClient client = new HttpClient())
        {
            string url = "https://jsonplaceholder.typicode.com/posts";
            var response = await client.GetStringAsync(url);

            // GetStringAsync birbaşa string qaytardığı üçün yenidən serialize etmək mənasız olur.
            //string serialized = JsonConvert.SerializeObject(response); 

            using (StreamWriter sw = new StreamWriter(filePath, true))
            {
                sw.WriteLine(response);
            }

            Console.WriteLine("The file created successfully.");
        }
        #endregion
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
