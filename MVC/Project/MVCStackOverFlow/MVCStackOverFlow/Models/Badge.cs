namespace MVCStackOverFlow.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Badge
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Badge()
        {
            BadgesEarnedByUsers = new HashSet<BadgesEarnedByUser>();
        }

        public int BadgeID { get; set; }

        [StringLength(30)]
        public string BadgeName { get; set; }

        [StringLength(30)]
        public string BadgeCategory { get; set; }

        [StringLength(200)]
        public string BadgeDescription { get; set; }

        [StringLength(20)]
        public string BadgeType { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BadgesEarnedByUser> BadgesEarnedByUsers { get; set; }
    }
}
