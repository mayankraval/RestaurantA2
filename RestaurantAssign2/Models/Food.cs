namespace RestaurantAssign2.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Food")]
    public partial class Food
    {
        public int foodID { get; set; }

        [Required]
        [StringLength(50)]
        public string type { get; set; }

        [Required]
        [StringLength(50)]
        public string name { get; set; }

        [Required]
        [StringLength(50)]
        public string description { get; set; }

        public decimal price { get; set; }

        [Required]
        public string image { get; set; }
    }
}
