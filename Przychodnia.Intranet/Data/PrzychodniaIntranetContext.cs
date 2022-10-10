using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Przychodnia.Intranet.Models.CMS;

namespace Przychodnia.Intranet.Data
{
    public class PrzychodniaIntranetContext : DbContext
    {
        public PrzychodniaIntranetContext (DbContextOptions<PrzychodniaIntranetContext> options)
            : base(options)
        {
        }

        public DbSet<Przychodnia.Intranet.Models.CMS.Aktualnosc> Aktualnosc { get; set; }

        public DbSet<Przychodnia.Intranet.Models.CMS.Strona> Strona { get; set; }

        public DbSet<Przychodnia.Intranet.Models.CMS.Parametr> Parametr { get; set; }
    }
}
