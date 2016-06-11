using Microsoft.AspNet.Identity.EntityFramework;
using Project.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using Project.Data.Migrations;

namespace Project.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>, IApplicationDbContext
    {
        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<ApplicationDbContext, Configuration>());
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }

        public IDbSet<BusinessPartner> BusinessPartners { get; set; }

        public IDbSet<ConsoleScaffold> ConsoleScaffold { get; set; }

        public IDbSet<LightScaffoldForm> LightScaffoldForm { get; set; }

        public IDbSet<MaterialConsoleScaffold> MaterialConsoleScaffold { get; set; }

        public IDbSet<PalletScaffoldForm> PalletScaffoldForm { get; set; }

        public IDbSet<ContactQuery> ContactQuery { get; set; }

        public IDbSet<BlogEntry> BlogEntry { get; set; }

        public IDbSet<Image> Image { get; set; }

        public IDbSet<Gallery> Gallery { get; set; }
                
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Employee>()
            //    .HasOptional(e => e.Supervisor)
            //    .WithMany(e => e.EmployeesSupervised)
            //    .HasForeignKey(s => s.SupervisorID);

            //modelBuilder.Entity<Equiptment>().HasMany(x => x.Users)
            //    .WithOptional(x => x.Equiptment)
            //    .WillCascadeOnDelete(false);

            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();

            base.OnModelCreating(modelBuilder);
        }
        //public System.Data.Entity.DbSet<Project.Models.LightScaffoldForm> LightScaffoldForms { get; set; }
    }
}
