using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace FreelancersWeb.Models
{
    public class FreelancersWebContext : DbContext
    {
        public FreelancersWebContext (DbContextOptions<FreelancersWebContext> options)
            : base(options)
        {
        }

        public DbSet<FreelancersWeb.Models.Type_user> Type_user { get; set; }
    }
}
