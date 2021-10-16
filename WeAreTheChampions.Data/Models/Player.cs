using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeAreTheChampions.Data
{
    public class Player
    {
        public int Id { get; set; }

        [Required, MaxLength(50)]
        public string PlayerName { get; set; }

        public int? TeamId { get; set; }
        public virtual Team Team { get; set; }
    }
}
