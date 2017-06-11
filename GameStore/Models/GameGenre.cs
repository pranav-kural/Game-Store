namespace GameStore.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class GameGenre
    {
        public string GameGenreId { get; set; }

        public DateTime CreateDate { get; set; }

        public DateTime EditDate { get; set; }

        [Required]
        [StringLength(128)]
        public string GameId { get; set; }

        [ForeignKey("GameId")]
        public Game Game { get; set; }

        [Required]
        [StringLength(128)]
        public string GenreId { get; set; }

        [ForeignKey("GenreId")]
        public Genre Genre { get; set; }
    }
}
