namespace DataAccessLayer.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class auctioneer_history
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int auctioneer_id { get; set; }

        public DateTime date_time { get; set; }

        [Required]
        [StringLength(250)]
        public string act { get; set; }

        public int uid { get; set; }

        public virtual auctioneer auctioneer { get; set; }
    }
}
