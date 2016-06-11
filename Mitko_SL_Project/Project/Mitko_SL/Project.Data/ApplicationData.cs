using Project.Data.Repositories;
using Project.Models;
using System;
using System.Collections.Generic;

namespace Project.Data
{
    public class ApplicationData : IApplicationData
    {
        private IApplicationDbContext context;
        private IDictionary<Type, object> repositories;

        public ApplicationData(IApplicationDbContext context)
        {
            this.context = context;
            this.repositories = new Dictionary<Type, object>();
        }

        public IRepository<ApplicationUser> Users
        {
            get { return this.GetRepository<ApplicationUser>(); }
        }

        public IRepository<ConsoleScaffold> ConsoleScaffold
        {
            get { return this.GetRepository<ConsoleScaffold>(); }
        }

        public IRepository<LightScaffoldForm> LightScaffoldForm 
        {
            get { return this.GetRepository<LightScaffoldForm>(); }
        }

        public IRepository<MaterialConsoleScaffold> MaterialConsoleScaffold
        {
            get { return this.GetRepository<MaterialConsoleScaffold>(); }
        }

        public IRepository<PalletScaffoldForm> PalletScaffoldForm
        {
            get { return this.GetRepository<PalletScaffoldForm>(); }
        }

        public IRepository<BusinessPartner> BusinessPartners
        {
            get { return this.GetRepository<BusinessPartner>(); }
        }

        public IRepository<ContactQuery> ContactQuery 
        {
            get { return this.GetRepository<ContactQuery>(); }
        }

        public IRepository<BlogEntry> BlogEntry 
        {
            get { return this.GetRepository<BlogEntry>(); }
        }

        public IRepository<Image> Image
        {
            get { return this.GetRepository<Image>(); }
        }

        public IRepository<Gallery> Gallery
        {
            get { return this.GetRepository<Gallery>(); }
        }

        public int SaveChanges()
        {
            return this.context.SaveChanges();
        }

        private IRepository<T> GetRepository<T>() where T : class
        {
            var type = typeof(T);
            if (!this.repositories.ContainsKey(type))
            {
                var typeOfRepository = typeof(GenericRepository<T>);
                var repository = Activator.CreateInstance(typeOfRepository, this.context);
                this.repositories.Add(type, repository);
            }

            return (IRepository<T>)this.repositories[type];
        }
    }
}
