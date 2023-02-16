using Ecommerce.API.Model.Interfaces;

namespace Ecommerce.API.Model.Repositories
{
    public class RepositoryCaracteristica : RepositoryBase<CARACTERISTICA>, ICaracteriscas
    {
        public RepositoryCaracteristica(bool SaveChanges = true) : base(SaveChanges)
        {

        }
    }
}