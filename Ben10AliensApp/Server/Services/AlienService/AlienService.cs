using Ben10AliensApp.Shared.Models;

namespace Ben10AliensApp.Server.Services.AlienService
{
    public class AlienService : IAlienService
    {
        public Task<Alien> CreateAlien(Alien alien)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteAlien(int alienId)
        {
            throw new NotImplementedException();
        }

        public Task<Alien?> GetAlienById(int alienId)
        {
            throw new NotImplementedException();
        }

        public Task<List<Alien>> GetAliens()
        {
            throw new NotImplementedException();
        }

        public Task<Alien?> UpdateAlien(int alienId, Alien alien)
        {
            throw new NotImplementedException();
        }
    }
}
