namespace DataAccessLayer.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class comments_poster
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int cpid { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int poster_id { get; set; }

        public int uid { get; set; }

        public DateTime cp_date { get; set; }

        [Required]
        [StringLength(3800)]
        public string cp_body { get; set; }

        public int? cp_like { get; set; }

        public int? cp_dislike { get; set; }

        public virtual poster poster { get; set; }
    }
}
