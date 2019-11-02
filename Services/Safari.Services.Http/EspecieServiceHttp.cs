using Safari.Business;
using Safari.Services.Contracts.Request;
using Safari.Services.Contracts.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

namespace Safari.Services.Http
{
    [RoutePrefix("api/Especie")]
    public class EspecieServiceHttp : ApiController
    {
        [HttpPost][Route("Agregar")]
        public AgregarEspecieResponse Agregar(AgregarEspecieRequest request)
        {
            try
            {
                var response = new AgregarEspecieResponse();
                var bc = new EspecieComponent();
                response.Result = bc.Agregar(request.Especie);
                return response;
            }
            catch (Exception ex)
            {
                var httpError = new HttpResponseMessage()
                {
                    StatusCode = (HttpStatusCode)422, // UNPROCESSABLE ENTITY
                    ReasonPhrase = ex.Message
                };
                throw new HttpResponseException(httpError);
            }
        }

        [HttpGet]
        [Route("ListarTodos")]
        public ListarTodosEspecieResponse ListarTodos()
        {
            try
            {
                var response = new ListarTodosEspecieResponse();
                var bc = new EspecieComponent();
                response.Result = bc.ListarTodos();

                return response;
            }
            catch (Exception ex)
            {
                var httpError = new HttpResponseMessage()
                {
                    StatusCode = (HttpStatusCode)422,
                    ReasonPhrase = ex.Message
                };

                throw new HttpResponseException(httpError);
            }
        }

        [HttpGet]
        [Route("Editar")]
        public EditarEspecieResponse Editar(EditarEspecieRequest request)
        {
            try
            {
                var response = new EditarEspecieResponse();
                var bc = new EspecieComponent();
                bc.Editar(request.Especie);

                return response;
            }
            catch (Exception ex)
            {
                var httpError = new HttpResponseMessage()
                {
                    StatusCode = (HttpStatusCode)422,
                    ReasonPhrase = ex.Message
                };

                throw new HttpResponseException(httpError);
            }
        }

        [HttpGet]
        [Route("Borrar")]
        public BorrarEspecieResponse Borrar(BorrarEspecieRequest request)
        {
            try
            {
                var response = new BorrarEspecieResponse();
                var bc = new EspecieComponent();
                bc.Borrar(request.Especie);

                return response;
            }
            catch (Exception ex)
            {
                var httpError = new HttpResponseMessage()
                {
                    StatusCode = (HttpStatusCode)422,
                    ReasonPhrase = ex.Message
                };

                throw new HttpResponseException(httpError);
            }
        }

        [HttpGet]
        [Route("ListarPorId")]
        public ListarEspecieResponse ListarPorId(ListarEspecieRequest request)
        {
            try
            {
                var response = new ListarEspecieResponse();
                var bc = new EspecieComponent();
                bc.ListarPorId(request.Especie.Id);

                return response;
            }
            catch (Exception ex)
            {
                var httpError = new HttpResponseMessage()
                {
                    StatusCode = (HttpStatusCode)422,
                    ReasonPhrase = ex.Message
                };

                throw new HttpResponseException(httpError);
            }
        }
    }
}
