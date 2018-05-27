namespace DataAccessLayer.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class goods_photo_id
    {
        [Key]
        [Column("goods_photo_id")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int goods_photo_id1 { get; set; }

        [StringLength(150)]
        public string photo_path { get; set; }

        [StringLength(300)]
        public string photo_comments { get; set; }

        public int? goods_id { get; set; }

        public int? shop_id { get; set; }

        public virtual eshop_goods_list eshop_goods_list { get; set; }
    }
}
