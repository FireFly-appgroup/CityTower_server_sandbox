namespace DataAccessLayer.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("eshop")]
    public partial class eshop
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public eshop()
        {
            comments_eshop = new HashSet<comments_eshop>();
            eshop_goods_list = new HashSet<eshop_goods_list>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int shop_id { get; set; }

        [Required]
        [StringLength(150)]
        public string shop_name { get; set; }

        [Required]
        [StringLength(300)]
        public string shop_comments { get; set; }

        [StringLength(1000)]
        public string shop_slogon { get; set; }

        public double? shop_rating { get; set; }

        public int? shop_like { get; set; }

        public int? shop_dislike { get; set; }

        public DateTime shop_reg_date { get; set; }

        public int? uid { get; set; }

        public int? city_id { get; set; }

        public int? country_id { get; set; }

        public virtual city_list city_list { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<comments_eshop> comments_eshop { get; set; }

        public virtual country_list country_list { get; set; }

        public virtual users users { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<eshop_goods_list> eshop_goods_list { get; set; }
    }
}
