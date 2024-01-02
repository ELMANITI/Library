using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using User.Domain.Entities;

namespace User.Infrastructure
{
    public class DBC : DbContext
    {
        public DBC(DbContextOptions<DBC> options) : base(options)
        {
            
        }
        public DbSet<RoleEntity> Roles { get; set; }
        public DbSet<UserEntity> Users { get; set; }
        public DbSet<UsersRoleEntity> UsersRoles { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<UserEntity>()
               // .HasOne<RoleEntity>(s => s.Roles)
               // .WithMany(r => r.Users)
               // .HasForeignKey(s => s.IdRole);*/
        }
    }
}
