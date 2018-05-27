namespace DataAccessLayer.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ad")]
    public partial class ad
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ad()
        {
            comments_ad = new HashSet<comments_ad>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ad_id { get; set; }

        [Required]
        [StringLength(150)]
        public string ad_tema { get; set; }

        [Required]
        [StringLength(3800)]
        public string ad_body { get; set; }

        public DateTime ad_date { get; set; }

        public int uid { get; set; }

        public int city_id { get; set; }

        public int country_id { get; set; }

        public int ad_category_id { get; set; }

        public virtual users users { get; set; }

        public virtual ad_category_list ad_category_list { get; set; }

        public virtual country_list country_list { get; set; }

        public virtual city_list city_list { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<comments_ad> comments_ad { get; set; }
    }
}
