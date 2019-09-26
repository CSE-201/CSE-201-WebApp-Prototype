using Microsoft.EntityFrameworkCore;

namespace Scholary_Software_Search.Data {
    public class PrototypeContext : DbContext {
        public PrototypeContext(DbContextOptions<PrototypeContext> options)
            : base(options) {
        }

        public DbSet<Scholary_Software_Search.Models.Software> Software { get; set; }

    }
}
