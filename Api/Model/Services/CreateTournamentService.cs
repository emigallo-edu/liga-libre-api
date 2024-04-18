using Model.Entities;
using Model.Repositories;

namespace Model.Services
{
    public class CreateTournamentService
    {
        private readonly IClubRepository _clubRepository;
        private readonly ITournamentRepository _tournamentRepository;

        public CreateTournamentService(IClubRepository clubRepository, ITournamentRepository tournamentRepository)
        {
            this._clubRepository = clubRepository;
            this._tournamentRepository = tournamentRepository;
        }
        public async Task ExecuteAsync()
        {
            List<Club> clubs = await this._clubRepository.GetAllAsync();
            clubs = clubs.Take(4).ToList();
            List<Match> matches = this.GetDayMatchs(clubs);

            var tournament = new Tournament()
            {
                Start = matches.Min(x => x.Date),
                Standings = new List<Standing>(),
                Matches = matches,
                End = matches.Max(x => x.Date)
            };

            foreach (Club club in clubs)
            {
                tournament.Standings.Add(new Standing()
                {
                    Tournament = tournament,
                    ClubId = club.Id
                });
            }

            await this._tournamentRepository.InsertAsync(tournament);
        }

        private List<Match> GetDayMatchs(List<Club> clubs)
        {
            List<Match> matches = new List<Match>();

            DateTime matchDay1 = DateTime.Now;
            DateTime matchDay2 = DateTime.Now.AddDays(7);
            DateTime matchDay3 = DateTime.Now.AddDays(14);

            matches.Add(new Match()
            {
                LocalClubId = clubs.First().Id,
                VisitingClubId = clubs.Skip(1).First().Id,
                Date = matchDay1
            });

            matches.Add(new Match()
            {
                LocalClubId = clubs.Skip(2).First().Id,
                VisitingClubId = clubs.Skip(3).First().Id,
                Date = matchDay1
            });

            matches.Add(new Match()
            {
                LocalClubId = clubs.First().Id,
                VisitingClubId = clubs.Skip(2).First().Id,
                Date = matchDay2
            });

            matches.Add(new Match()
            {
                LocalClubId = clubs.Skip(1).First().Id,
                VisitingClubId = clubs.Skip(3).First().Id,
                Date = matchDay2
            });

            matches.Add(new Match()
            {
                LocalClubId = clubs.First().Id,
                VisitingClubId = clubs.Skip(3).First().Id,
                Date = matchDay3
            });

            matches.Add(new Match()
            {
                LocalClubId = clubs.Skip(1).First().Id,
                VisitingClubId = clubs.Skip(2).First().Id,
                Date = matchDay3
            });

            return matches;
        }
    }
}