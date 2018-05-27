namespace DataAccessLayer.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class language_list
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public language_list()
        {
            user_settings = new HashSet<user_settings>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int language_id { get; set; }

        [Required]
        [StringLength(150)]
        public string language { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<user_settings> user_settings { get; set; }
    }
}
