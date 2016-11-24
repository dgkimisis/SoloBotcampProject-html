namespace GameShop.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Games
    {
        public int id { get; set; }

        public string Name { get; set; }

        public int? PublishYear { get; set; }

        public string Genre { get; set; }

        [Column("Violence Rating")]
        public int? Violence_Rating { get; set; }

        public string Company { get; set; }
    }
}
