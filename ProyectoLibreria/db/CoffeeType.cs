namespace ProyectoLibreria.db
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CoffeeType")]
    public partial class CoffeeType
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CoffeeType()
        {
            Coffee = new HashSet<Coffee>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CoffeeTypeId { get; set; }

        [StringLength(50)]
        public string Name { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Coffee> Coffee { get; set; }
    }
}
