using Project.Data.Repositories;
using Project.Models;
using System.Text.RegularExpressions;

namespace Project.Data
{   
    public interface IApplicationData
    {
        IRepository<ApplicationUser> Users { get; }

        IRepository<BusinessPartner> BusinessPartners { get; }

        IRepository<ConsoleScaffold> ConsoleScaffold { get; }

        IRepository<LightScaffoldForm> LightScaffoldForm { get; }

        IRepository<MaterialConsoleScaffold> MaterialConsoleScaffold { get; }

        IRepository<PalletScaffoldForm> PalletScaffoldForm { get; }

        IRepository<ContactQuery> ContactQuery { get; }

        IRepository<BlogEntry> BlogEntry { get; }

        IRepository<Image> Image { get; }

        IRepository<Gallery> Gallery { get; }

        int SaveChanges();
    }
}
