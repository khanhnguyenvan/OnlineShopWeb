using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace TeduShop.Model.Abstraction
{
    interface IAuditable
    {
        DateTime? CreatedDate { get; set; }
        DateTime? UpdatedDate { get; set; }
        [MaxLength(256)]
        string CreatedBy { get; set; }
        [MaxLength(256)]
        string UpdatedBy { get; set; }
        string MetaTitle { get; set; }
        string MetatKeyword { get; set; }
        bool Status { get; set; }
    }
}
