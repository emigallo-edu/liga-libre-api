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

        public Match()
        {
        }

        public int Id { get; set; }
        public int TournamentId { get; set; }

        [Required]
        public DateTime Date { get; set; }

        public int LocalClubId { get; set; }
        public int VisitingClubId { get; set; }

        [Required]
        public Club LocalClub { get; set; }

        [Required]
        public Club VisitingClub { get; set; }
    }
}