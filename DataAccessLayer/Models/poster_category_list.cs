namespace DataAccessLayer.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class poster_category_list
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public poster_category_list()
        {
            poster = new HashSet<poster>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int poster_category_id { get; set; }

        [Required]
        [StringLength(150)]
        public string category { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<poster> poster { get; set; }
    }
}
