using NinjectStartupSetup.Utils.Data;
using System.Data.Entity;
using NinjectStartupSetup.Models;

namespace NinjectStartupSetup.Utils
{
    public class DbConfiguration : IDbConfiguration
    {
        public void AddConfiguration(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new UserMap());
        }
    }
}