namespace DataAccessLayer.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class eshop_goods_list
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public eshop_goods_list()
        {
            goods_photo_id = new HashSet<goods_photo_id>();
        }

        [StringLength(300)]
        public string goods_name { get; set; }

        [StringLength(300)]
        public string goods_description { get; set; }

        public double? goods_price { get; set; }

        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int goods_id { get; set; }

        public int? goods_category_id { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int shop_id { get; set; }

        public virtual eshop eshop { get; set; }

        public virtual goods_category_list goods_category_list { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<goods_photo_id> goods_photo_id { get; set; }
    }
}
