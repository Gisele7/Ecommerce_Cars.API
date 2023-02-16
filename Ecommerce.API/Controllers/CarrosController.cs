using Ecommerce.API.Model;
using Ecommerce.API.Model.Repositories;
using System;
using System.Threading.Tasks;
using System.Web.Helpers;
using System.Web.Http;

namespace Ecommerce.API.Controllers
{
    public class CarrosController : ApiController
    {
        RepositoryCarro _RepositoryCarro = new RepositoryCarro();

        public async Task<IHttpActionResult> GetHttpAsync()
        {
            var lista = _RepositoryCarro.SelecionarTodos();
            return Json(lista);
        }

        [HttpPost]
        public async Task<IHttpActionResult> PostIncluir(CARRO carro)
        {
            try
            {
                _RepositoryCarro.Incluir(carro);
                return Json(carro);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        [HttpPut]
        public async Task<IHttpActionResult> PutAlterar(CARRO carro)
        {
            try
            {
                _RepositoryCarro.Alterar(carro);
                return Json(carro);
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        [HttpGet]
        public async Task<IHttpActionResult> GetBuscar(int codCarro)
        {
            try
            {
                var carro = _RepositoryCarro.SelecionarPk(codCarro);
                return Json(carro);
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        [HttpDelete]
        public async Task<IHttpActionResult> DeleteCarro(int codCarro)
        {
            try
            {
                var carro = _RepositoryCarro.SelecionarPk(codCarro);
                _RepositoryCarro.Excluir(carro);
                return Json(new { mensagem = "Carro excluído com sucesso!" });
            }
            catch (Exception ex)
            {

                throw;
            }
        }
    }
}
