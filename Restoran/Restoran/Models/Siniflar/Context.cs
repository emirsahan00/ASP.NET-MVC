using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Restoran.Models.Siniflar
{
    public class Context : DbContext
    {
        public DbSet<Admin> Admins { get; set; }
        public DbSet<iletisim> iletisims { get; set; }
        public DbSet<Slider> Sliders { get; set; }
        public DbSet<Menu> Menus { get; set; }
    }

}