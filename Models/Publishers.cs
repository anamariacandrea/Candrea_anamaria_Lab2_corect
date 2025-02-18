﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Candrea_anamaria_Lab2.Models
{
    public class Publishers
    {
        public int ID { get; set; }
        [Required]
        [Display(Name = "Publisher Name")]
        [StringLength(50)]
        public string PublisherName { get; set; }
        [StringLength(70)]
        public string Adress { get; set; }
        public ICollection<PublishedBook> PublishedBooks { get; set; }
    }
}
