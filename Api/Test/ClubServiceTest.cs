using Model.Entities;
using Model.Repositories;
using Model.Services;
using Test.Repositories;

namespace Test
{
    [TestClass]
    public class ClubServiceTest
    {
        [TestMethod]
        public async Task Given_AValidClub_When_Create_Then_Should_CreateIt()
        {
            IClubRepository clubRepository = new ClubMockRepository();
            IStadiumRepository stadiumRepository = new StadiumMockRepository();
            var sut = new CreateClubService(clubRepository, stadiumRepository);

            int clubId = await sut.ExecuteAsync(new Club
            {
                Name = "Argentinos Jr",
                Birthday = DateTime.Now,
                Email = "mail@mail.com",
                StadiumName = "Estadio Diego Armando Maradona"
            });

            Club clubCreated = await clubRepository.GetByIdAsync(clubId);
            Assert.IsNotNull(clubCreated);
        }

        [TestMethod]
        public async Task Given_AClubWithoutEmail_When_Create_Then_Should_NotCreateIt()
        {
            IClubRepository clubRepository = new ClubMockRepository();
            IStadiumRepository stadiumRepository = new StadiumMockRepository();
            var sut = new CreateClubService(clubRepository, stadiumRepository);
            try
            {
                int clubId = await sut.ExecuteAsync(new Club
                {
                    Name = "Argentinos Jr",
                    Birthday = DateTime.Now,
                    StadiumName = "Estadio Diego Armando Maradona"
                });
                Assert.Fail();
            }
            catch (NullReferenceException)
            {

            }
            catch (Exception)
            {
                Assert.Fail();
            }
        }
    }
}