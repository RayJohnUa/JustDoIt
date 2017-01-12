using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace JustDoIt.Models
{
    public class UserModels
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        public string Mail { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Password { get; set; }

        [NotMapped]
        public string Token { get; set; }

        public virtual ICollection<TaskModels> Tasks { get; set; }
        public virtual ICollection<TaskListModels> TaskList { get; set; }
    }
}