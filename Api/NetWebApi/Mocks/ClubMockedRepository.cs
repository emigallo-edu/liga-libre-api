using Model.Entities;
using Model.Repositories;

namespace NetWebApi.Mocks
{
    public class ClubMockedRepository : IClubRepository
    {
        public Task ChangeName(int cludId, string newName)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Club>> GetAllAsync()
        {
            List<Club> result = new List<Club>();
            result.Add(new Club() { Name = "Club1" });
            result.Add(new Club() { Name = "Club2" });
            result.Add(new Club() { Name = "Club3" });
            return result;
        }

        public Task<List<ShortClub>> GetAllShortAsync()
        {
            throw new NotImplementedException();
        }

        public Task<int> InsertAsync(Club club)
        {
            throw new NotImplementedException();
        }
    }
}
