namespace DataAccessLayer.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class comments_ad
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int caid { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ad_id { get; set; }

        public int uid { get; set; }

        public DateTime ca_date { get; set; }

        [Required]
        [StringLength(3800)]
        public string ca_body { get; set; }

        public int? ca_like { get; set; }

        public int? ca_dislike { get; set; }

        public virtual ad ad { get; set; }
    }
}
