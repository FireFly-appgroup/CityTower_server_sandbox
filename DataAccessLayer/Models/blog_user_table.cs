namespace DataAccessLayer.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class blog_user_table
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int blog_id { get; set; }

        public int uid { get; set; }

        public int blog_status_id { get; set; }

        public virtual blog_list blog_list { get; set; }

        public virtual blog_status_list blog_status_list { get; set; }

        public virtual users users { get; set; }
    }
}
