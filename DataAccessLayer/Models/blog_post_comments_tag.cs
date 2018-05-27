namespace DataAccessLayer.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class blog_post_comments_tag
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int tag_id { get; set; }

        public int bpc_id { get; set; }

        public int bid { get; set; }

        public virtual tag_list tag_list { get; set; }
    }
}
