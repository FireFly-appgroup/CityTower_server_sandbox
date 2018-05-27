namespace DataAccessLayer.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class like_dislike_list
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ld_id { get; set; }

        public int? comments_ad_ad { get; set; }

        public int? auctioneer_id { get; set; }

        public int? news_id { get; set; }

        public int? comments_news_id { get; set; }

        public int? places_id { get; set; }

        public int? comments_places_id { get; set; }

        public int? poster_id { get; set; }

        public int? comments_poster_id { get; set; }

        public int? blog_post_id { get; set; }

        public int? blog_post_comments_id { get; set; }

        public int? chat_id { get; set; }

        public int? user_use_id { get; set; }

        public int? user_id { get; set; }

        public int? goods_id { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int uid { get; set; }

        public virtual users users { get; set; }
    }
}
