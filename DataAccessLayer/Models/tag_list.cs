namespace DataAccessLayer.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tag_list
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int tag_id { get; set; }

        [Required]
        [StringLength(200)]
        public string tag_name { get; set; }

        public int? ad_count { get; set; }

        public int? comments_ad_count { get; set; }

        public int? auctioneer_count { get; set; }

        public int? news_count { get; set; }

        public int? comments_news_count { get; set; }

        public int? places_count { get; set; }

        public int? comments_places_count { get; set; }

        public int? poster_count { get; set; }

        public int? comments_poster_count { get; set; }

        public int? blog_post_count { get; set; }

        public int? blog_post_comments_count { get; set; }

        public int? chat_count { get; set; }

        public int? user_use_count { get; set; }

        public int? user_count { get; set; }

        public int? goods_count { get; set; }

        public virtual ad_tag ad_tag { get; set; }

        public virtual auctioneer_tag auctioneer_tag { get; set; }

        public virtual blog_post_comments_tag blog_post_comments_tag { get; set; }

        public virtual blog_post_tag blog_post_tag { get; set; }

        public virtual chat_tag chat_tag { get; set; }

        public virtual comments_ad_tag comments_ad_tag { get; set; }

        public virtual comments_news_tag comments_news_tag { get; set; }

        public virtual comments_places_tag comments_places_tag { get; set; }

        public virtual comments_poster_tag comments_poster_tag { get; set; }

        public virtual goods_tag goods_tag { get; set; }

        public virtual news_tag news_tag { get; set; }

        public virtual places_tag places_tag { get; set; }

        public virtual poster_tag poster_tag { get; set; }

        public virtual user_tag user_tag { get; set; }

        public virtual user_use_tag user_use_tag { get; set; }
    }
}
