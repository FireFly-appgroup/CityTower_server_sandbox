namespace DataAccessLayer.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class user_settings
    {
        [MaxLength(1)]
        public byte[] user_gps_loc { get; set; }

        public int? skin_id { get; set; }

        public int? language_id { get; set; }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int uid { get; set; }

        public virtual language_list language_list { get; set; }

        public virtual skin_list skin_list { get; set; }

        public virtual users users { get; set; }
    }
}
