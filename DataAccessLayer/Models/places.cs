namespace DataAccessLayer.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class places
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public places()
        {
            comments_places = new HashSet<comments_places>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int places_id { get; set; }

        [Required]
        [StringLength(150)]
        public string places_tema { get; set; }

        [Required]
        [StringLength(3800)]
        public string places_body { get; set; }

        public DateTime places_date { get; set; }

        public DateTime places_start_date { get; set; }

        public double? places_rating { get; set; }

        public int uid { get; set; }

        public int city_id { get; set; }

        public int country_id { get; set; }

        public int places_category_id { get; set; }

        public int? places_like { get; set; }

        public int? places_dislike { get; set; }

        public virtual city_list city_list { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<comments_places> comments_places { get; set; }

        public virtual country_list country_list { get; set; }

        public virtual users users { get; set; }

        public virtual places_category_list places_category_list { get; set; }
    }
}
