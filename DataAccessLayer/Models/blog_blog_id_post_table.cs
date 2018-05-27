namespace DataAccessLayer.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class blog_blog_id_post_table
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public blog_blog_id_post_table()
        {
            blog_blog_id_post_comments = new HashSet<blog_blog_id_post_comments>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int bp_id { get; set; }

        [Required]
        [StringLength(200)]
        public string blog_post_tema { get; set; }

        [Required]
        [StringLength(3800)]
        public string blog_post_body { get; set; }

        public DateTime blog_post_data { get; set; }

        public double? blog_post_rating { get; set; }

        public int? blog_post_like { get; set; }

        public int? blog_post_dislike { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<blog_blog_id_post_comments> blog_blog_id_post_comments { get; set; }
    }
}
