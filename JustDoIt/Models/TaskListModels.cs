using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace JustDoIt.Models
{
    public class TaskListModels
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        [Required]
        public string Name { get; set; }

        public virtual ICollection<UserModels> Users { get; set; }
        public virtual ICollection<ColumnModels> Columns { get; set; }
    }
}