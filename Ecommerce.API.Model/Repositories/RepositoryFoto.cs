using Ecommerce.API.Model.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace Ecommerce.API.Model.Repositories
{
    public class RepositoryFoto : RepositoryBase<FOTO>, IFoto
    {
        public RepositoryFoto(bool SaveChanges = true) : base(SaveChanges)
        {

        }

        public FOTO SelecionaPorCarro(int codCarro) 
        {
            return _DataContext.FOTO.FirstOrDefault(x => x.FOCodCarro == codCarro);
        }

        public List<FOTO> ListaFotoPorCarro (int codCarro)
        {
            List<FOTO> listaFotos = _DataContext.FOTO.Where(x => x.FOCodCarro == codCarro).ToList();
            return listaFotos;

        }
    }
}