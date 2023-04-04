using Ben10AliensApp.Shared.Models;

namespace Ben10AliensApp.Client.Services.AlienService
{
    public interface IAlienService
    {
        List<Alien> Aliens { get; set; }

        Task GetAliens();
        Task<Alien?> GetAlienById (int id);
        Task CreateAlien(Alien alien);
        Task UpdateAliens(int id, Alien alien);
        Task DeleteAlien(int id);

    }
}
