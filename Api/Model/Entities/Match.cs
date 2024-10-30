using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;

namespace Model.Entities
{
    public class Match
    {
        /* CREATE TABLE Matches
         *  ( Id NUMERIC NOT NULL,
         *    TournamentId NUMERIC NOT NULL,
         *    Date SMALLDATETIME NULL,
         *    LocalClubId NUMERIC NOT NULL,
         *    VisitingClubId NUMERIC NOT NULL,
         *    PRIMARY KEY (Id)
         *  )
         * */
        /*CREATE TABLE Clubes
         * ( Id INT PRIMARY KEY,
         *  Name VARCHAR(50) NOT NULL
         *  PRIMARY KEY (Id)
         * )
         */

        /* CREATE TABLE Matches
         * ( Id INT PRIMARY KEY,
         *  TournamentId INT NOT NULL,
         *  Date DATETIME NOT NULL,
         *  LocalClubId INT NOT NULL,
         *  visitingClubId INT NOT NULL
         *  primary key (Id),
         *  foreign key (LocalClubId) references Clubes(Id),
         *  foreign key (visitingClubId) references Clubes(Id)
         * )
         * 
         */

        public Match()
        {
        }

        public int Id { get; set; }
        public int TournamentId { get; set; }

        [Required]
        public DateTime Date { get; set; }

        public int LocalClubId { get; set; }
        [Required]
        public Club LocalClub { get; set; }

        public int VisitingClubId { get; set; }
        [Required]
        public Club VisitingClub { get; set; }
    }
}