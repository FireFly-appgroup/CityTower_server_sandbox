namespace DataAccessLayer.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class CityTowerDataBase : DbContext
    {
        public CityTowerDataBase()
            : base("name=CityTowerDataBase")
        {
        }

        public virtual DbSet<ad> ad { get; set; }
        public virtual DbSet<ad_category_list> ad_category_list { get; set; }
        public virtual DbSet<ad_tag> ad_tag { get; set; }
        public virtual DbSet<all_chat> all_chat { get; set; }
        public virtual DbSet<auctioneer> auctioneer { get; set; }
        public virtual DbSet<auctioneer_category_list> auctioneer_category_list { get; set; }
        public virtual DbSet<auctioneer_history> auctioneer_history { get; set; }
        public virtual DbSet<auctioneer_tag> auctioneer_tag { get; set; }
        public virtual DbSet<blog_blog_id_post_comments> blog_blog_id_post_comments { get; set; }
        public virtual DbSet<blog_blog_id_post_table> blog_blog_id_post_table { get; set; }
        public virtual DbSet<blog_category_list> blog_category_list { get; set; }
        public virtual DbSet<blog_list> blog_list { get; set; }
        public virtual DbSet<blog_post_comments_tag> blog_post_comments_tag { get; set; }
        public virtual DbSet<blog_post_tag> blog_post_tag { get; set; }
        public virtual DbSet<blog_status_list> blog_status_list { get; set; }
        public virtual DbSet<blog_user_table> blog_user_table { get; set; }
        public virtual DbSet<chat_tag> chat_tag { get; set; }
        public virtual DbSet<city_list> city_list { get; set; }
        public virtual DbSet<comments_ad> comments_ad { get; set; }
        public virtual DbSet<comments_ad_tag> comments_ad_tag { get; set; }
        public virtual DbSet<comments_eshop> comments_eshop { get; set; }
        public virtual DbSet<comments_news> comments_news { get; set; }
        public virtual DbSet<comments_news_tag> comments_news_tag { get; set; }
        public virtual DbSet<comments_places> comments_places { get; set; }
        public virtual DbSet<comments_places_tag> comments_places_tag { get; set; }
        public virtual DbSet<comments_poster> comments_poster { get; set; }
        public virtual DbSet<comments_poster_tag> comments_poster_tag { get; set; }
        public virtual DbSet<country_list> country_list { get; set; }
        public virtual DbSet<eshop> eshop { get; set; }
        public virtual DbSet<eshop_goods_list> eshop_goods_list { get; set; }
        public virtual DbSet<goods_category_list> goods_category_list { get; set; }
        public virtual DbSet<goods_photo_id> goods_photo_id { get; set; }
        public virtual DbSet<goods_tag> goods_tag { get; set; }
        public virtual DbSet<language_list> language_list { get; set; }
        public virtual DbSet<like_dislike_list> like_dislike_list { get; set; }
        public virtual DbSet<news> news { get; set; }
        public virtual DbSet<news_category_list> news_category_list { get; set; }
        public virtual DbSet<news_tag> news_tag { get; set; }
        public virtual DbSet<online_list> online_list { get; set; }
        public virtual DbSet<places> places { get; set; }
        public virtual DbSet<places_category_list> places_category_list { get; set; }
        public virtual DbSet<places_tag> places_tag { get; set; }
        public virtual DbSet<poster> poster { get; set; }
        public virtual DbSet<poster_category_list> poster_category_list { get; set; }
        public virtual DbSet<poster_tag> poster_tag { get; set; }
        public virtual DbSet<sex_list> sex_list { get; set; }
        public virtual DbSet<skin_list> skin_list { get; set; }
        public virtual DbSet<status_list> status_list { get; set; }
        public virtual DbSet<sys_message> sys_message { get; set; }
        public virtual DbSet<tag_list> tag_list { get; set; }
        public virtual DbSet<user_settings> user_settings { get; set; }
        public virtual DbSet<user_tag> user_tag { get; set; }
        public virtual DbSet<user_use_tag> user_use_tag { get; set; }
        public virtual DbSet<users> users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ad>()
                .Property(e => e.ad_tema)
                .IsFixedLength();

            modelBuilder.Entity<ad>()
                .Property(e => e.ad_body)
                .IsFixedLength();

            modelBuilder.Entity<ad>()
                .HasMany(e => e.comments_ad)
                .WithRequired(e => e.ad)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ad_category_list>()
                .Property(e => e.category)
                .IsFixedLength();

            modelBuilder.Entity<ad_category_list>()
                .HasMany(e => e.ad)
                .WithRequired(e => e.ad_category_list)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<all_chat>()
                .Property(e => e.mess_body)
                .IsFixedLength();

            modelBuilder.Entity<auctioneer>()
                .Property(e => e.auctioneer_name)
                .IsFixedLength();

            modelBuilder.Entity<auctioneer>()
                .Property(e => e.auctioneer_comment)
                .IsFixedLength();

            modelBuilder.Entity<auctioneer>()
                .Property(e => e.auctioneer_direction)
                .IsFixedLength();

            modelBuilder.Entity<auctioneer>()
                .HasOptional(e => e.auctioneer_history)
                .WithRequired(e => e.auctioneer);

            modelBuilder.Entity<auctioneer_category_list>()
                .Property(e => e.category)
                .IsFixedLength();

            modelBuilder.Entity<auctioneer_category_list>()
                .HasMany(e => e.auctioneer)
                .WithRequired(e => e.auctioneer_category_list)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<auctioneer_history>()
                .Property(e => e.act)
                .IsFixedLength();

            modelBuilder.Entity<blog_blog_id_post_comments>()
                .Property(e => e.bpc_body)
                .IsFixedLength();

            modelBuilder.Entity<blog_blog_id_post_table>()
                .Property(e => e.blog_post_tema)
                .IsFixedLength();

            modelBuilder.Entity<blog_blog_id_post_table>()
                .Property(e => e.blog_post_body)
                .IsFixedLength();

            modelBuilder.Entity<blog_blog_id_post_table>()
                .HasMany(e => e.blog_blog_id_post_comments)
                .WithRequired(e => e.blog_blog_id_post_table)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<blog_category_list>()
                .Property(e => e.category)
                .IsFixedLength();

            modelBuilder.Entity<blog_category_list>()
                .HasMany(e => e.blog_list)
                .WithRequired(e => e.blog_category_list)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<blog_list>()
                .Property(e => e.blog_status)
                .IsFixedLength();

            modelBuilder.Entity<blog_list>()
                .Property(e => e.blog_name)
                .IsFixedLength();

            modelBuilder.Entity<blog_list>()
                .Property(e => e.blog_slogon)
                .IsFixedLength();

            modelBuilder.Entity<blog_list>()
                .HasOptional(e => e.blog_user_table)
                .WithRequired(e => e.blog_list);

            modelBuilder.Entity<blog_status_list>()
                .Property(e => e.status)
                .IsFixedLength();

            modelBuilder.Entity<blog_status_list>()
                .HasMany(e => e.blog_user_table)
                .WithRequired(e => e.blog_status_list)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<city_list>()
                .Property(e => e.city)
                .IsFixedLength();

            modelBuilder.Entity<city_list>()
                .HasMany(e => e.ad)
                .WithRequired(e => e.city_list)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<city_list>()
                .HasMany(e => e.all_chat)
                .WithRequired(e => e.city_list)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<city_list>()
                .HasMany(e => e.auctioneer)
                .WithRequired(e => e.city_list)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<city_list>()
                .HasMany(e => e.users)
                .WithRequired(e => e.city_list)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<city_list>()
                .HasMany(e => e.poster)
                .WithRequired(e => e.city_list)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<city_list>()
                .HasMany(e => e.places)
                .WithRequired(e => e.city_list)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<city_list>()
                .HasMany(e => e.news)
                .WithRequired(e => e.city_list)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<comments_ad>()
                .Property(e => e.ca_body)
                .IsFixedLength();

            modelBuilder.Entity<comments_eshop>()
                .Property(e => e.ces_body)
                .IsFixedLength();

            modelBuilder.Entity<comments_news>()
                .Property(e => e.cn_body)
                .IsFixedLength();

            modelBuilder.Entity<comments_places>()
                .Property(e => e.cpl_body)
                .IsFixedLength();

            modelBuilder.Entity<comments_poster>()
                .Property(e => e.cp_body)
                .IsFixedLength();

            modelBuilder.Entity<country_list>()
                .Property(e => e.country)
                .IsFixedLength();

            modelBuilder.Entity<country_list>()
                .HasMany(e => e.ad)
                .WithRequired(e => e.country_list)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<country_list>()
                .HasMany(e => e.auctioneer)
                .WithRequired(e => e.country_list)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<country_list>()
                .HasMany(e => e.users)
                .WithRequired(e => e.country_list)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<country_list>()
                .HasMany(e => e.poster)
                .WithRequired(e => e.country_list)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<country_list>()
                .HasMany(e => e.places)
                .WithRequired(e => e.country_list)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<country_list>()
                .HasMany(e => e.news)
                .WithRequired(e => e.country_list)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<eshop>()
                .Property(e => e.shop_slogon)
                .IsFixedLength();

            modelBuilder.Entity<eshop>()
                .HasMany(e => e.comments_eshop)
                .WithRequired(e => e.eshop)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<eshop>()
                .HasMany(e => e.eshop_goods_list)
                .WithRequired(e => e.eshop)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<eshop_goods_list>()
                .Property(e => e.goods_name)
                .IsFixedLength();

            modelBuilder.Entity<eshop_goods_list>()
                .Property(e => e.goods_description)
                .IsFixedLength();

            modelBuilder.Entity<eshop_goods_list>()
                .HasMany(e => e.goods_photo_id)
                .WithOptional(e => e.eshop_goods_list)
                .HasForeignKey(e => new { e.goods_id, e.shop_id });

            modelBuilder.Entity<goods_category_list>()
                .Property(e => e.category)
                .IsFixedLength();

            modelBuilder.Entity<goods_photo_id>()
                .Property(e => e.photo_path)
                .IsFixedLength();

            modelBuilder.Entity<goods_photo_id>()
                .Property(e => e.photo_comments)
                .IsFixedLength();

            modelBuilder.Entity<language_list>()
                .Property(e => e.language)
                .IsFixedLength();

            modelBuilder.Entity<news>()
                .Property(e => e.news_teme)
                .IsFixedLength();

            modelBuilder.Entity<news>()
                .Property(e => e.news_body)
                .IsFixedLength();

            modelBuilder.Entity<news>()
                .HasMany(e => e.comments_news)
                .WithRequired(e => e.news)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<news_category_list>()
                .Property(e => e.category)
                .IsFixedLength();

            modelBuilder.Entity<news_category_list>()
                .HasMany(e => e.news)
                .WithRequired(e => e.news_category_list)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<places>()
                .Property(e => e.places_tema)
                .IsFixedLength();

            modelBuilder.Entity<places>()
                .Property(e => e.places_body)
                .IsFixedLength();

            modelBuilder.Entity<places>()
                .HasMany(e => e.comments_places)
                .WithRequired(e => e.places)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<places_category_list>()
                .Property(e => e.category)
                .IsFixedLength();

            modelBuilder.Entity<places_category_list>()
                .HasMany(e => e.places)
                .WithRequired(e => e.places_category_list)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<poster>()
                .Property(e => e.poster_tema)
                .IsFixedLength();

            modelBuilder.Entity<poster>()
                .Property(e => e.poster_body)
                .IsFixedLength();

            modelBuilder.Entity<poster>()
                .HasMany(e => e.comments_poster)
                .WithRequired(e => e.poster)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<poster_category_list>()
                .Property(e => e.category)
                .IsFixedLength();

            modelBuilder.Entity<poster_category_list>()
                .HasMany(e => e.poster)
                .WithRequired(e => e.poster_category_list)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<sex_list>()
                .Property(e => e.sex)
                .IsFixedLength();

            modelBuilder.Entity<skin_list>()
                .Property(e => e.skin_name)
                .IsFixedLength();

            modelBuilder.Entity<status_list>()
                .Property(e => e.status)
                .IsFixedLength();

            modelBuilder.Entity<status_list>()
                .HasMany(e => e.online_list)
                .WithRequired(e => e.status_list)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<sys_message>()
                .Property(e => e.message)
                .IsFixedLength();

            modelBuilder.Entity<tag_list>()
                .Property(e => e.tag_name)
                .IsFixedLength();

            modelBuilder.Entity<tag_list>()
                .HasOptional(e => e.ad_tag)
                .WithRequired(e => e.tag_list);

            modelBuilder.Entity<tag_list>()
                .HasOptional(e => e.auctioneer_tag)
                .WithRequired(e => e.tag_list);

            modelBuilder.Entity<tag_list>()
                .HasOptional(e => e.blog_post_comments_tag)
                .WithRequired(e => e.tag_list);

            modelBuilder.Entity<tag_list>()
                .HasOptional(e => e.blog_post_tag)
                .WithRequired(e => e.tag_list);

            modelBuilder.Entity<tag_list>()
                .HasOptional(e => e.chat_tag)
                .WithRequired(e => e.tag_list);

            modelBuilder.Entity<tag_list>()
                .HasOptional(e => e.comments_ad_tag)
                .WithRequired(e => e.tag_list);

            modelBuilder.Entity<tag_list>()
                .HasOptional(e => e.comments_news_tag)
                .WithRequired(e => e.tag_list);

            modelBuilder.Entity<tag_list>()
                .HasOptional(e => e.comments_places_tag)
                .WithRequired(e => e.tag_list);

            modelBuilder.Entity<tag_list>()
                .HasOptional(e => e.comments_poster_tag)
                .WithRequired(e => e.tag_list);

            modelBuilder.Entity<tag_list>()
                .HasOptional(e => e.goods_tag)
                .WithRequired(e => e.tag_list);

            modelBuilder.Entity<tag_list>()
                .HasOptional(e => e.news_tag)
                .WithRequired(e => e.tag_list);

            modelBuilder.Entity<tag_list>()
                .HasOptional(e => e.places_tag)
                .WithRequired(e => e.tag_list);

            modelBuilder.Entity<tag_list>()
                .HasOptional(e => e.poster_tag)
                .WithRequired(e => e.tag_list);

            modelBuilder.Entity<tag_list>()
                .HasOptional(e => e.user_tag)
                .WithRequired(e => e.tag_list);

            modelBuilder.Entity<tag_list>()
                .HasOptional(e => e.user_use_tag)
                .WithRequired(e => e.tag_list);

            modelBuilder.Entity<user_settings>()
                .Property(e => e.user_gps_loc)
                .IsFixedLength();

            modelBuilder.Entity<users>()
                .Property(e => e.user_premium)
                .IsFixedLength();

            modelBuilder.Entity<users>()
                .Property(e => e.user_name)
                .IsFixedLength();

            modelBuilder.Entity<users>()
                .Property(e => e.user_firstname)
                .IsFixedLength();

            modelBuilder.Entity<users>()
                .Property(e => e.user_lastname)
                .IsFixedLength();

            modelBuilder.Entity<users>()
                .Property(e => e.user_tel)
                .IsFixedLength();

            modelBuilder.Entity<users>()
                .Property(e => e.user_nikname)
                .IsFixedLength();

            modelBuilder.Entity<users>()
                .Property(e => e.user_password)
                .IsFixedLength();

            modelBuilder.Entity<users>()
                .Property(e => e.user_email)
                .IsFixedLength();

            modelBuilder.Entity<users>()
                .Property(e => e.user_avator)
                .IsFixedLength();

            modelBuilder.Entity<users>()
                .Property(e => e.user_loc)
                .IsFixedLength();

            modelBuilder.Entity<users>()
                .Property(e => e.user_slogon)
                .IsFixedLength();

            modelBuilder.Entity<users>()
                .HasMany(e => e.ad)
                .WithRequired(e => e.users)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<users>()
                .HasMany(e => e.all_chat)
                .WithRequired(e => e.users)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<users>()
                .HasMany(e => e.auctioneer)
                .WithRequired(e => e.users)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<users>()
                .HasMany(e => e.blog_user_table)
                .WithRequired(e => e.users)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<users>()
                .HasMany(e => e.like_dislike_list)
                .WithRequired(e => e.users)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<users>()
                .HasMany(e => e.news)
                .WithRequired(e => e.users)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<users>()
                .HasOptional(e => e.online_list)
                .WithRequired(e => e.users);

            modelBuilder.Entity<users>()
                .HasMany(e => e.places)
                .WithRequired(e => e.users)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<users>()
                .HasMany(e => e.poster)
                .WithRequired(e => e.users)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<users>()
                .HasOptional(e => e.sys_message)
                .WithRequired(e => e.users);

            modelBuilder.Entity<users>()
                .HasOptional(e => e.user_settings)
                .WithRequired(e => e.users);
        }
    }
}
