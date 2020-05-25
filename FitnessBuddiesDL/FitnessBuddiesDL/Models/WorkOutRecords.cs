using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace AppManagerDL.Models
{
  public  class WorkOutRecords
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int Id { get; set; }

        public string Description { get; set; }


        public Guid TennantId { get; set; }
    }
}
