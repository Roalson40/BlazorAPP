using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using BlazorAPP.Data;

namespace BlazorAPP.DataService
{
    public class ToyService
    {
        public async Task AddToy(Toy toy, int Id)
        {
            using HttpClient client = new HttpClient();
            string adultAsJson = JsonSerializer.Serialize(toy, new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true,
            });
            HttpContent content1 = new StringContent(adultAsJson, Encoding.UTF8, "application/json");
            await client.PostAsync($"https://localhost:5001/toy{Id}", content1);
        }
        
        
        public async Task<IList<Toy>> GetToy()
        {
            using HttpClient client = new HttpClient();
            Task<string> stringAsync = client.GetStringAsync("https://localhost:5001/Toy");
            string message = await stringAsync;
            IList<Toy> result = JsonSerializer.Deserialize<List<Toy>>(message, new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            });
            return result;
        }
        
        
        public async Task RemoveToy(int id)
        {
            using HttpClient client = new HttpClient();
            await client.DeleteAsync("https://localhost:5001/Toy" + $"/{id}");
        }  
    }
}