using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace AppManagerDL.Models
{
    public class WorkOuts
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int Id { get; set; }

        [Column(TypeName = "decimal(18,4)")]
        public decimal Distance { get; set; }

        [Column(TypeName = "decimal(18,4)")]
        public decimal Pace { get; set; }
        public TimeSpan Time { get; set; }

        public int Kudos { get; set; }

        public Guid KudosId { get; set; }
        public List<WorkOutRecords> WorkOutRecords { get; set; }

    }
}
