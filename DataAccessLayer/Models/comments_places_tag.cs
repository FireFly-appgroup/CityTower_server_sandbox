namespace DataAccessLayer.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class comments_places_tag
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int tag_id { get; set; }

        public int cplid { get; set; }

        public virtual tag_list tag_list { get; set; }
    }
}
