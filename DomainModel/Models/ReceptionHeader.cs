namespace DomainModel.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ReceptionHeader")]
    public partial class ReceptionHeader
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ReceptionHeader()
        {
            ReceptionDetails = new HashSet<ReceptionDetail>();
        }

        public int ReceptionHeaderID { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime HeaderDate { get; set; }

        public int PatientID { get; set; }

        [Required]
        [StringLength(20)]
        public string NationalCode { get; set; }

        public int EmployeeID { get; set; }

        public int? InsuranceTypeID { get; set; }

        [Required]
        [StringLength(50)]
        public string DrName { get; set; }

        public long? TotalPrice { get; set; }

        [StringLength(400)]
        public string HeaderDescription { get; set; }

        public int Age { get; set; }

        public virtual Employee Employee { get; set; }

        public virtual InsuranceType InsuranceType { get; set; }

        public virtual Patient Patient { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ReceptionDetail> ReceptionDetails { get; set; }
    }
}
