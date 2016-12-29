﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeduShop.Model.Models
{
    [Table(" VisitorStatistics")]
    public class VisitorStatistic
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        public DateTime VisitedDate { get; set; }
        [MaxLength(50)]
        public string IpAddress { get; set; }
    }
}
