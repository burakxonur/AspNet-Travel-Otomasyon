﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrate
{
    public class Testimonial
    {
        [Key]
        public int TestimonialID { get; set; }
        public string Clien { get; set; }
        public string Comment { get; set; }
        public string ClientImage { get; set; }
        public bool Status { get; set; }
    }
}
