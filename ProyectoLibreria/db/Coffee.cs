namespace ProyectoLibreria.db
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Coffee")]
    public partial class Coffee
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CoffeeId { get; set; }

        [StringLength(250)]
        public string Title { get; set; }

        [StringLength(600)]
        public string Description { get; set; }

        [StringLength(400)]
        public string Img { get; set; }

        public decimal? Price { get; set; }

        public int? BrandId { get; set; }

        public int? TypeId { get; set; }

        public virtual Brand Brand { get; set; }

        public virtual CoffeeType CoffeeType { get; set; }
    }
}
