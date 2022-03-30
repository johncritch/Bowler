using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Bowler.Models
{
    public class Teams
    {
        [Key]
        [Required]
        public int TeamID { get; set; }

        public int CaptainID { get; set; }

        public string TeamName { get; set; }

        public List<Bowlers> Bowlers { get; set; }
    }
}
