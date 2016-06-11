using Project.Models;
using System.Data.Entity;

namespace Project.Data
{
    public interface IApplicationDbContext
    {
        IDbSet<ApplicationUser> Users { get; set; }

        IDbSet<BusinessPartner> BusinessPartners { get; set; }

        IDbSet<ConsoleScaffold> ConsoleScaffold { get; }

        IDbSet<LightScaffoldForm> LightScaffoldForm { get; }

        IDbSet<MaterialConsoleScaffold> MaterialConsoleScaffold { get; }

        IDbSet<PalletScaffoldForm> PalletScaffoldForm { get; }

        IDbSet<ContactQuery> ContactQuery { get; }

        IDbSet<BlogEntry> BlogEntry { get; }

        IDbSet<Image> Image { get; }

        IDbSet<Gallery> Gallery { get; }

        int SaveChanges();
    }
}
