using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace GameShop.Models
{
    public class Game
    {
        [Key]
        public int GameId { get; set; }
        public string Name { get; set; }
        public int PublishYear { get; set; }
        public string Genre { get; set; }
        public int ViolenceRating { get; set; }
        public int Cost { get; set; }
        public string Company { get; set; }
    }
}