﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Restoran.Models.Siniflar
{
    public class Slider
    {
        [Key]
        public int ID { get; set; }
        public string FotoUrl { get; set; }
    }
}