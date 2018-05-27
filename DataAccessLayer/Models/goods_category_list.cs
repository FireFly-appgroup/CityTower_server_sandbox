namespace DataAccessLayer.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class goods_category_list
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public goods_category_list()
        {
            eshop_goods_list = new HashSet<eshop_goods_list>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int goods_category_id { get; set; }

        [StringLength(150)]
        public string category { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<eshop_goods_list> eshop_goods_list { get; set; }
    }
}
