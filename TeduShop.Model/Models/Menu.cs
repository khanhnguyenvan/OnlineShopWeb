using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeduShop.Model.Models
{
    [Table("Menus")]
    public class Menu
    {
        [Key]
        public  int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Url { get; set; }
        public int ? DisplayOrder { get; set; }
        public string Target { get; set; }
        [Required]
        [ForeignKey("GroupId")]
        public int GroupId { get; set; }
        [Required]
        public bool Status { get; set; }
        public virtual MenuGroup MenuGroup { get; set; }
    }
}
