using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeAreTheChampions.Data
{
    public class Match
    {
        public int Id { get; set; }

        public DateTime MatchTime { get; set; }

        public int Team1Id { get; set; }

        public int Team2Id { get; set; }

        public byte Score1 { get; set; }

        public byte Score2 { get; set; }

        public Result ResultId { get; set; }
    }
}
