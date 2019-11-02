using Safari.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using Safari.UI.Process;
using System.Text;
using System.Threading.Tasks;
using Safari.Services.Contracts.Response;
using Safari.Services.Contracts.Request;

namespace Safari.UI.Process
{
    public class EspecieProcess : ProcessComponent
    {
        public IList<Especie> Listar()
        {
            var response = HttpGet<ListarTodosEspecieResponse>("api/Especie/ListarTodos", new Dictionary<string, object>(), MediaType.Json);
            return response.Result;
        }

        public Especie ObtenerPorId(Especie especie)
        {
            var objecto = new Dictionary<string, object>();

            var request = new ListarEspecieRequest();
            request.Especie = especie;

            objecto.Add("id", request.Especie.Id);

            var response = HttpGet<ListarEspecieRequest>("api/Especie/ListarPorId", objecto, MediaType.Json);
            return response.Especie;
        }

        public Especie Agregar(Especie especie)
        {
            var request = new AgregarEspecieRequest();
            request.Especie = especie;
            var response = HttpPost<AgregarEspecieRequest>("api/Especie/Agregar", request, MediaType.Json);
            return response.Especie;
        }

        public void Editar(Especie especie)
        {
            var request = new EditarEspecieRequest();
            request.Especie = especie;
            var response = HttpPost<EditarEspecieRequest>("api/Especie/Editar", request, MediaType.Json);
        }

        public void Borrar(Especie especie)
        {
            var request = new BorrarEspecieRequest();
            request.Especie = especie;
            var response = HttpPost<BorrarEspecieRequest>("api/Especie/Borrar", request, MediaType.Json);
        }
    }
}
