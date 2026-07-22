namespace DomainModel.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("InsuranceType")]
    public partial class InsuranceType
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public InsuranceType()
        {
            ReceptionHeaders = new HashSet<ReceptionHeader>();
        }

        public int InsuranceTypeID { get; set; }

        [Required]
        [StringLength(400)]
        public string InsuranceTypeName { get; set; }

        [StringLength(400)]
        public string Description { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ReceptionHeader> ReceptionHeaders { get; set; }
    }
}
