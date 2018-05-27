namespace DataAccessLayer.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class online_list
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int uid { get; set; }

        public int status_id { get; set; }

        public int user_guid { get; set; }

        public virtual users users { get; set; }

        public virtual status_list status_list { get; set; }
    }
}
