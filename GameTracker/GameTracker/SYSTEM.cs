namespace GameTracker
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SYSTEMS")]
    public partial class SYSTEM
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SYSTEM()
        {
            GAMES = new HashSet<GAME>();
        }

        [Key]
        public int SYSID { get; set; }

        [StringLength(255)]
        public string SYSTEMNAME { get; set; }

        public DateTime? SYSTEMRELEASE { get; set; }

        [StringLength(255)]
        public string SYSMANUFACTURE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GAME> GAMES { get; set; }
    }
}
