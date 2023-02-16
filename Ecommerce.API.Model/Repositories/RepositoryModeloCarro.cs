using Ecommerce.API.Model.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace Ecommerce.API.Model.Repositories
{
    public class RepositoryModeloCarro : RepositoryBase<MODELO_CARRO>, IModeloCarro
    {
        public RepositoryModeloCarro(bool SaveChanges = true) : base(SaveChanges)
        {

        }

        public List<MODELO_CARRO> ListaModeloPorMarca(int codMarca)
        {
            return _DataContext.MODELO_CARRO.AsNoTracking().Where(x=> x.MOCodMarca == codMarca).ToList();
        }
    }
}