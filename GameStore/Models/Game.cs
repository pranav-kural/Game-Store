namespace GameStore.Models
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Game
    {
        [Key]
        public string GameId { get; set; }

        [Required]
        [StringLength(250)]
        [Display(Name="Name")]
        public string Name { get; set; }


        public bool IsMultiplayer { get; set; }

        public DateTime CreateDate { get; set; }

        public DateTime EditDate { get; set; }
        
        public virtual ICollection<GameGenre> Genres { get; set; } = new HashSet<GameGenre>();
    }
}
