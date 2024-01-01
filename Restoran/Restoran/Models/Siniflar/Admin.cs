using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Restoran.Models.Siniflar
{
    public class Admin
    {   [Key]
        public int ID { get; set; }
        public string Kullanici { get; set; }
        public int Sifre { get; set; }
    }
}