using System;
using System.Net;
using System.Net.Http;


namespace ConsoletinkeringSuccess
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Making API Call...");
            using (var client = new HttpClient(new HttpClientHandler { AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate }))
            {
                client.BaseAddress = new Uri("https://opentdb.com/api.php");
                HttpResponseMessage response = client.GetAsync("https://opentdb.com/api.php?amount=1").Result;
                response.EnsureSuccessStatusCode();
                string result = response.Content.ReadAsStringAsync().Result;
                Console.WriteLine("Result: " + result);
            }
            Console.ReadLine();
        }
    }
}
