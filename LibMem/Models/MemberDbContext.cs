using LibMem.Models;
using Microsoft.EntityFrameworkCore;

namespace LibMem.Models
{
    public class MemberDbContext : DbContext
    {
        public MemberDbContext(DbContextOptions<MemberDbContext> options) : base(options)
        {
            
        }
        public DbSet<Member> Members { get; set; }
    }
}
