namespace DomainModel.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Test")]
    public partial class Test
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Test()
        {
            ReceptionDetails = new HashSet<ReceptionDetail>();
            TestRanges = new HashSet<TestRange>();
        }

        public int TestID { get; set; }

        [Required]
        [StringLength(200)]
        public string TestName { get; set; }

        public int UnitID { get; set; }

        public int CategoryID { get; set; }

        public bool AgeHasEffect { get; set; }

        public bool GenderHasEffect { get; set; }

        public long UnitPrice { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ReceptionDetail> ReceptionDetails { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TestRange> TestRanges { get; set; }

        public virtual TestCategory TestCategory { get; set; }

        public virtual Unit Unit { get; set; }
    }
}
