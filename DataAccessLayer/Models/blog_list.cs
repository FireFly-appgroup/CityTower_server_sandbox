namespace DataAccessLayer.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class blog_list
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int blog_id { get; set; }

        [Required]
        [StringLength(20)]
        public string blog_status { get; set; }

        [Required]
        [StringLength(100)]
        public string blog_name { get; set; }

        [StringLength(250)]
        public string blog_slogon { get; set; }

        [StringLength(128)]
        public string blog_avator { get; set; }

        public double? blog_rating { get; set; }

        public int? blog_like { get; set; }

        public int? blog_dislike { get; set; }

        public int? blog_subscribers_num { get; set; }

        public int blog_category_id { get; set; }

        public virtual blog_category_list blog_category_list { get; set; }

        public virtual blog_user_table blog_user_table { get; set; }
    }
}
