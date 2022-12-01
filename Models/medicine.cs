namespace medical.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class medicine
    {
        public int id { get; set; }

        [Column("medicine name")]
        [Required]
        [StringLength(500)]
        public string medicine_name { get; set; }

        [Column("user of medicine")]
        [Required]
        [StringLength(500)]
        public string user_of_medicine { get; set; }

        [Required]
        [StringLength(500)]
        public string price { get; set; }

        [Column("expiration date")]
        [Required]
        [StringLength(500)]
        public string expiration_date { get; set; }
    }
}
