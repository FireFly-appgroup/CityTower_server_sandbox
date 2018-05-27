namespace DataAccessLayer.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class sys_message
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int uid { get; set; }

        [StringLength(200)]
        public string message { get; set; }

        public DateTime? mess_date { get; set; }

        public virtual users users { get; set; }
    }
}
