using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using UserPortal.Model;

namespace UserPortal.Data
{
    public class UserPortalContext : DbContext
    {
        public UserPortalContext (DbContextOptions<UserPortalContext> options)
            : base(options)
        {
        }

        public DbSet<UserPortal.Model.User> User { get; set; } = default!;
    }
}
