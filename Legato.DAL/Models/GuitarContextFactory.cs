using System.Data.Entity.Infrastructure;


namespace Legato.DAL.Models
{
    class GuitarContextDefaultFactory : IDbContextFactory<GuitarContext>
    {
        public GuitarContext Create()
        {
            return new GuitarContext(Constants.Constants.DefaultConnectionStringName);
        }
    }
}
