using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace JustDoIt.Models
{
    public class ColumnModels
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }

        public int TaskListId { get; set; }
        [ForeignKey("TaskListId")]
        public virtual TaskListModels TaskList { get; set; }

        public virtual ICollection<TaskModels> Tasks { get; set; }
    }
}