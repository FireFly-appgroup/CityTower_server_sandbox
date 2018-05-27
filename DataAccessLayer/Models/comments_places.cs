namespace DataAccessLayer.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class comments_places
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int cplid { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int places_id { get; set; }

        public int uid { get; set; }

        public DateTime cpl_date { get; set; }

        [Required]
        [StringLength(3800)]
        public string cpl_body { get; set; }

        public int? cpl_like { get; set; }

        public int? cpl_dislike { get; set; }

        public virtual places places { get; set; }
    }
}
