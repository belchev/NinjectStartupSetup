using System.Data.Entity;

namespace NinjectStartupSetup.Utils.Data
{
    public interface IDbConfiguration
    {
        void AddConfiguration(DbModelBuilder modelBuilder);
    }
}
