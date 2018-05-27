namespace DataAccessLayer.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("auctioneer")]
    public partial class auctioneer
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int auctioneer_id { get; set; }

        [Required]
        [StringLength(300)]
        public string auctioneer_name { get; set; }

        [StringLength(400)]
        public string auctioneer_comment { get; set; }

        public int auctioneer_start_price { get; set; }

        [MaxLength(1)]
        public byte[] auctioneer_direction { get; set; }

        public double? auctioneer_price_step { get; set; }

        public int? auctioneer_price { get; set; }

        public int? auctioneer_price_uid { get; set; }

        public int? auctioneer_ransom_price { get; set; }

        public DateTime auctioneer_date { get; set; }

        public DateTime auctioneer_end_date { get; set; }

        public int uid { get; set; }

        public int city_id { get; set; }

        public int country_id { get; set; }

        public int auctioneer_category_id { get; set; }

        public virtual users users { get; set; }

        public virtual auctioneer_category_list auctioneer_category_list { get; set; }

        public virtual country_list country_list { get; set; }

        public virtual city_list city_list { get; set; }

        public virtual auctioneer_history auctioneer_history { get; set; }
    }
}
