using Ecommerce.API.Model.Interfaces;

namespace Ecommerce.API.Model.Repositories
{
    public class RepositoryCarro : RepositoryBase<CARRO>, ICarro
    {
        public RepositoryCarro(bool SaveChanges = true) : base(SaveChanges)
        {

        }
    }
}