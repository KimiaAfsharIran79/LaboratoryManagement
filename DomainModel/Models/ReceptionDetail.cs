namespace DomainModel.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ReceptionDetail")]
    public partial class ReceptionDetail
    {
        [Key]
        public int ReceptionDetailsID { get; set; }

        public int TestID { get; set; }

        public long Price { get; set; }

        public int ReceptionHeaderID { get; set; }

        public double? Result { get; set; }

        public bool? HasStar { get; set; }

        public virtual ReceptionHeader ReceptionHeader { get; set; }

        public virtual Test Test { get; set; }
    }
}
