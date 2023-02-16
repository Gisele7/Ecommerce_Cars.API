using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.API.Model.Interfaces
{
    internal interface InterfaceModel<T> where T : class
    {
        List<T> SelecionarTodos();
        T SelecionarPk(params object[] variavel);
        T Incluir(T objeto);
        T Alterar(T objeto);
        void Excluir(T objeto);
        void Excluir(params object[] variavel);
        void SaveChanges();
    }
}
