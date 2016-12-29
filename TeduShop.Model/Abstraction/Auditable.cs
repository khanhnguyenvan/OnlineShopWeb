using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeduShop.Model.Abstraction
{
    public class Auditable : IAuditable
    {
        public DateTime? CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
        public string MetaTitle { get; set; }
        public string MetatKeyword { get; set; }
        public bool Status { get; set; }
    }
}
