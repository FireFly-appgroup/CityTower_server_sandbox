namespace DataAccessLayer.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class all_chat
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int mess_id { get; set; }

        [Required]
        [StringLength(300)]
        public string mess_body { get; set; }

        public DateTime mess_date { get; set; }

        public int uid { get; set; }

        public int city_id { get; set; }

        public virtual users users { get; set; }

        public virtual city_list city_list { get; set; }
    }
}
