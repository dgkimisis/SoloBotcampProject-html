namespace GameShop.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Games
    {
        public int Id { get; set; }

        [StringLength(50)]
        public string Name { get; set; }

        public int? PublishYear { get; set; }

        [StringLength(50)]
        public string Genre { get; set; }

        [Column("Violence Rating")]
        public int? Violence_Rating { get; set; }

        public string Company { get; set; }
    }
}
