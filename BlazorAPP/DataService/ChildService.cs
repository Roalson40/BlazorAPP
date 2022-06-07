using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using BlazorAPP.Data;

namespace BlazorAPP.DataService
{
    public class ChildService
    {
        public async Task AddChild(Child child)
        {
            using HttpClient client = new HttpClient();
            string adultAsJson = JsonSerializer.Serialize(child, new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true,
            });
            HttpContent content1 = new StringContent(adultAsJson, Encoding.UTF8, "application/json");
            await client.PostAsync( "https://localhost:5005/Child", content1 );
            
            Console.WriteLine("Service");
        }
        
        public async Task<IList<Data.Child>> GetChildren()
        {
            using HttpClient client = new HttpClient();
            Task<string> stringAsync = client.GetStringAsync("https://localhost:5005/Child");
            string message = await stringAsync;
            IList<Child> result = JsonSerializer.Deserialize<IList<Child>>(message, new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            });
            return result;
        }
    }
}