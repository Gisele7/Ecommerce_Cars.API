using Ecommerce.API.Model.Interfaces;

namespace Ecommerce.API.Model.Repositories
{
    public class RepositoryMarcaCarro : RepositoryBase<MARCA_CARRO>, IMarcaCarro
    {
        public RepositoryMarcaCarro(bool SaveChanges = true) : base(SaveChanges)
        {

        }
    }
}