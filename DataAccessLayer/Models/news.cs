namespace DataAccessLayer.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class news
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public news()
        {
            comments_news = new HashSet<comments_news>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int news_id { get; set; }

        [Required]
        [StringLength(150)]
        public string news_teme { get; set; }

        [Required]
        [StringLength(3800)]
        public string news_body { get; set; }

        public DateTime news_date { get; set; }

        public double? news_rating { get; set; }

        public int uid { get; set; }

        public int city_id { get; set; }

        public int country_id { get; set; }

        public int news_category_id { get; set; }

        public int? news_like { get; set; }

        public int? news_dislike { get; set; }

        public virtual city_list city_list { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<comments_news> comments_news { get; set; }

        public virtual country_list country_list { get; set; }

        public virtual users users { get; set; }

        public virtual news_category_list news_category_list { get; set; }
    }
}
