using Ben10AliensApp.Shared.Models;

namespace Ben10AliensApp.Server.Services.AlienService
{
    public interface IAlienService
    {
        Task<List<Alien>> GetAliens();
        Task<Alien?> GetAlienById(int alienId);
        Task<Alien> CreateAlien(Alien alien);
        Task<Alien?> UpdateAlien(int alienId, Alien alien);
        Task<bool> DeleteAlien (int alienId);
    }
}
