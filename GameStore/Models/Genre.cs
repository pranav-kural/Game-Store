namespace GameStore.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Genre
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Genre()
        {
            Games = new HashSet<GameGenre>();
        }

        [Key]
        public string GenreId { get; set; }

        [Required]
        [StringLength(250)]
        public string Name { get; set; }

        public DateTime CreateDate { get; set; }

        public DateTime EditDate { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GameGenre> Games { get; set; }
    }
}
