using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace CodeFirst.Models
{
    public class Player
    {
        public int PlayerId { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Position { get; set; }
        public DateTime CreatedDate { get; set; }

        public string TeamName { get; set; }
        public Team Team { get; set; }
    }
}
