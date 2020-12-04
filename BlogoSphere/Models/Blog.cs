﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BlogoSphere.Models
{
    public class Blog
    {
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string Title { get; set; }
        [Required]
        [StringLength(100)]
        public string Body{ get; set; }
          public DateTime Created { get; set; }
    }
}