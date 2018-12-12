namespace GameTracker
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("GAMES")]
    public partial class GAME
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public GAME()
        {
            SYSTEMS = new HashSet<SYSTEM>();
        }

        public int GAMEID { get; set; }

        public int? GENREID { get; set; }

        [StringLength(255)]
        public string GAMENAME { get; set; }

        public DateTime? PUBLISHDATE { get; set; }

        [StringLength(255)]
        public string GAMEDESC { get; set; }

        public virtual GAMEGENRE GAMEGENRE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SYSTEM> SYSTEMS { get; set; }
    }
}
