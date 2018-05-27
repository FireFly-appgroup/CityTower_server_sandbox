namespace DataAccessLayer.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class blog_blog_id_post_comments
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int bp_id { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int bpc_id { get; set; }

        public int uid { get; set; }

        public DateTime bpc_data { get; set; }

        [Required]
        [StringLength(3800)]
        public string bpc_body { get; set; }

        public int? bpc_like { get; set; }

        public int? bpc_dislike { get; set; }

        public virtual blog_blog_id_post_table blog_blog_id_post_table { get; set; }
    }
}
