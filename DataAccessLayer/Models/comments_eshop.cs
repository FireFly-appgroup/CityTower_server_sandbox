namespace DataAccessLayer.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class comments_eshop
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ces_id { get; set; }

        public int? uid { get; set; }

        public DateTime? ces_date { get; set; }

        [StringLength(3800)]
        public string ces_body { get; set; }

        public int? ces_like { get; set; }

        public int? ces_dislike { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int shop_id { get; set; }

        public virtual eshop eshop { get; set; }
    }
}
