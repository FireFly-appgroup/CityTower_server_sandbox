namespace DataAccessLayer.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class blog_status_list
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public blog_status_list()
        {
            blog_user_table = new HashSet<blog_user_table>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int blog_status_id { get; set; }

        [Required]
        [StringLength(150)]
        public string status { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<blog_user_table> blog_user_table { get; set; }
    }
}
