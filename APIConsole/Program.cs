using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace APIConsole
{
    class Program
    {
        static async Task Main(string[] args)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri( "https://zoo-animal-api.herokuapp.com/");
            string response = await client.GetStringAsync("animals/rand/3");
            Console.WriteLine(response);
        }
    }
}
