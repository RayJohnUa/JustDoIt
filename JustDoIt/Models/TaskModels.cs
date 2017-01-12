using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace JustDoIt.Models
{
    public class TaskModels
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        public int Rang { get; set; }
        [Required]
        public DateTime Created { get; set; }

        public int UserID { get; set; }
        [ForeignKey("UserID")]
        public virtual UserModels User { get; set; }

        public virtual ICollection<ContentTaskModels> Contents { get; set; }
    
    }
}