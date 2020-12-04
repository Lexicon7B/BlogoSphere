﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BlogoSphere.Models
{
    public class Comment
    {
        public int Id { get; set; }

        [Required]
        [StringLength(1024)]
        public string Body { get; set; }

        [Required]
        [DataType(DataType.DateTime)]
        public DateTime Created { get; set; }
    }
}