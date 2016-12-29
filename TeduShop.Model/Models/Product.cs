using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using TeduShop.Model.Abstraction;

namespace TeduShop.Model.Models
{
    [Table("Products")]
    public class Product : Auditable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public int? Quantity { get; set; }
        public string Alias { get; set; }
        public decimal Price { get; set; }
        
        public string Image { get; set; }
        [ForeignKey("CategoryId")]
        public int CategoryId { get; set; }
        public XElement MoreImages { get; set; }
        public decimal? PromotionPrice { get; set; }
        public int? Warranty { get; set; }
        public string Content { get; set; }
        public bool? HomeFlag { get; set; }
        public bool? HotFlage { get; set; }
        public int? ViewCount { get; set; }
        public virtual ProductCategory ProductCategory { get; set; }
    }
}
