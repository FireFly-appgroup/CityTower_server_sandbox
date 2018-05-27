namespace DataAccessLayer.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("poster")]
    public partial class poster
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public poster()
        {
            comments_poster = new HashSet<comments_poster>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int poster_id { get; set; }

        [Required]
        [StringLength(150)]
        public string poster_tema { get; set; }

        [Required]
        [StringLength(3800)]
        public string poster_body { get; set; }

        public DateTime poster_date { get; set; }

        public DateTime poster_start_date { get; set; }

        public double? poster_rating { get; set; }

        public int uid { get; set; }

        public int city_id { get; set; }

        public int country_id { get; set; }

        public int poster_category_id { get; set; }

        public int? poster_like { get; set; }

        public int? poster_dislike { get; set; }

        public virtual city_list city_list { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<comments_poster> comments_poster { get; set; }

        public virtual country_list country_list { get; set; }

        public virtual users users { get; set; }

        public virtual poster_category_list poster_category_list { get; set; }
    }
}
