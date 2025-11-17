using MetroVMS.Entity;
using MetroVMS.Entity.BranchMaster.DTO;
using MetroVMS.Entity.DepartmentMaster.DTO;
using MetroVMS.Entity.EmployeeManagement.DTO;
using MetroVMS.Entity.Identity.DTO;
using MetroVMS.Entity.ItemMaster.DTO;
using MetroVMS.Entity.ItemRequestMasterData.DTO;
using MetroVMS.Entity.Localization.DTO;
using MetroVMS.Entity.RoleData.DTO;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;

namespace MetroVMS.DataAccess
{
    public class MetroVMSDBContext : DbContext
    {

        private readonly IHttpContextAccessor _Context;
        long? loggedInUser = null;

        public MetroVMSDBContext(DbContextOptions<MetroVMSDBContext> options, IHttpContextAccessor httpContextAccessor) : base(options)
        {
            _Context = httpContextAccessor;

            var claimsIdentity = _Context?.HttpContext?.User?.Identity as ClaimsIdentity;
            // _Logger = logger;
            var userIdentity = claimsIdentity?.Name;
            if (userIdentity != null)
            {
                long userid = 0;
                Int64.TryParse(userIdentity, out userid);
                if (userid > 0)
                {
                    loggedInUser = userid;
                }
            }
        }

        public DbSet<Users> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<RoleGroupClaim> RoleGroupClaims { get; set; }
        public DbSet<UserSession> UserSessions { get; set; }
        public DbSet<LocalizationResource> LocalizationResources { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Designation> Designations { get; set; }
        public DbSet<Branch> Branches { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<ItemRequestMaster> ItemRequestMasters { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        public override int SaveChanges()
        {
            var entries = ChangeTracker
            .Entries()
            .Where(e => e.Entity is BaseEntity && (
            e.State == EntityState.Added
            || e.State == EntityState.Modified));

            foreach (var entityEntry in entries)
            {

                if (loggedInUser > 0)
                {
                    if (entityEntry.State == EntityState.Added)
                    {
                        ((BaseEntity)entityEntry.Entity).CreatedDate = DateTime.Now;
                        ((BaseEntity)entityEntry.Entity).CreatedBy = loggedInUser;
                    }
                    else
                    {
                        ((BaseEntity)entityEntry.Entity).UpdatedDate = DateTime.Now;
                        ((BaseEntity)entityEntry.Entity).UpdatedBy = loggedInUser;
                    }

                }

            }
            var result = base.SaveChanges();
            return result;
        }

        public override async Task<int> SaveChangesAsync(bool acceptAllChangesOnSuccess, CancellationToken cancellationToken = default(CancellationToken))
        {

            var entries = ChangeTracker
            .Entries()
            .Where(e => e.Entity is BaseEntity && (
            e.State == EntityState.Added
            || e.State == EntityState.Modified));

            foreach (var entityEntry in entries)
            {

                if (loggedInUser > 0)
                {
                    if (entityEntry.State == EntityState.Added)
                    {
                        ((BaseEntity)entityEntry.Entity).CreatedDate = DateTime.Now;
                        ((BaseEntity)entityEntry.Entity).CreatedBy = loggedInUser;
                    }
                    else
                    {
                        ((BaseEntity)entityEntry.Entity).UpdatedBy = loggedInUser;
                        ((BaseEntity)entityEntry.Entity).UpdatedDate = DateTime.Now;
                    }

                }


            }
            var result = await base.SaveChangesAsync(acceptAllChangesOnSuccess, cancellationToken);
            return result;
        }
    }
}

