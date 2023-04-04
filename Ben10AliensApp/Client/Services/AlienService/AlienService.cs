using Ben10AliensApp.Shared.Models;
using System.Net.Http.Json;

namespace Ben10AliensApp.Client.Services.AlienService
{
    public class AlienService : IAlienService
    {
        private readonly HttpClient http;

        public AlienService(HttpClient http)
        {
            this.http = http;
        }

        public List<Alien> Aliens { get; set; } = new List<Alien>();

        public Task CreateAlien(Alien alien)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAlien(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Alien?> GetAlienById(int id)
        {
            throw new NotImplementedException();
        }

        public async Task GetAliens()
        {
            var result = await http.GetFromJsonAsync<List<Alien>>("api/aliens");
        }

        public Task UpdateAliens(int id, Alien alien)
        {
            throw new NotImplementedException();
        }
    }
}
