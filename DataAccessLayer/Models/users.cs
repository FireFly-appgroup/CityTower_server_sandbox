namespace DataAccessLayer.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class users
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public users()
        {
            ad = new HashSet<ad>();
            all_chat = new HashSet<all_chat>();
            auctioneer = new HashSet<auctioneer>();
            blog_user_table = new HashSet<blog_user_table>();
            eshop = new HashSet<eshop>();
            like_dislike_list = new HashSet<like_dislike_list>();
            news = new HashSet<news>();
            places = new HashSet<places>();
            poster = new HashSet<poster>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int uid { get; set; }

        [MaxLength(1)]
        public byte[] user_premium { get; set; }

        public DateTime user_reg_date { get; set; }

        [Required]
        [StringLength(50)]
        public string user_name { get; set; }

        [Required]
        [StringLength(100)]
        public string user_firstname { get; set; }

        [Required]
        [StringLength(100)]
        public string user_lastname { get; set; }

        [Required]
        [StringLength(20)]
        public string user_tel { get; set; }

        [Required]
        [StringLength(100)]
        public string user_nikname { get; set; }

        public DateTime? user_date_of_birth { get; set; }

        [Required]
        [StringLength(100)]
        public string user_password { get; set; }

        [Required]
        [StringLength(100)]
        public string user_email { get; set; }

        [StringLength(100)]
        public string user_avator { get; set; }

        public double? user_rating { get; set; }

        public int? user_like { get; set; }

        public int? user_dislike { get; set; }

        [Column(TypeName = "xml")]
        public string user_password_history { get; set; }

        [Column(TypeName = "xml")]
        public string user_log_file { get; set; }

        [StringLength(20)]
        public string user_loc { get; set; }

        public DateTime? user_last_online { get; set; }

        [StringLength(300)]
        public string user_slogon { get; set; }

        public int? sex_id { get; set; }

        public int city_id { get; set; }

        public int country_id { get; set; }

        public int? user_bonus_count { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ad> ad { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<all_chat> all_chat { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<auctioneer> auctioneer { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<blog_user_table> blog_user_table { get; set; }

        public virtual city_list city_list { get; set; }

        public virtual country_list country_list { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<eshop> eshop { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<like_dislike_list> like_dislike_list { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<news> news { get; set; }

        public virtual online_list online_list { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<places> places { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<poster> poster { get; set; }

        public virtual sex_list sex_list { get; set; }

        public virtual sys_message sys_message { get; set; }

        public virtual user_settings user_settings { get; set; }
    }
}
