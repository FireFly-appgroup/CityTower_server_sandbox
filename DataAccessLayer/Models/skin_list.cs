namespace DataAccessLayer.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class skin_list
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public skin_list()
        {
            user_settings = new HashSet<user_settings>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int skin_id { get; set; }

        [Required]
        [StringLength(150)]
        public string skin_name { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<user_settings> user_settings { get; set; }
    }
}
