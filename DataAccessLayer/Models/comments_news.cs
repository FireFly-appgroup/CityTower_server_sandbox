namespace DataAccessLayer.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class comments_news
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int cnid { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int news_id { get; set; }

        public int uid { get; set; }

        public DateTime cn_date { get; set; }

        [Required]
        [StringLength(3800)]
        public string cn_body { get; set; }

        public int? cn_like { get; set; }

        public int? cn_dislike { get; set; }

        public virtual news news { get; set; }
    }
}
