using Safari.Data;
using Safari.Entities;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;


namespace Safari.Business
{
    public partial class EspecieComponent
    {
        public Especie Agregar(Especie especie)
        {
            Especie result = default(Especie);
            var especieDAC = new EspecieDAC();

            result = especieDAC.Create(especie);
            return result;
        }

        public List<Especie> ListarTodos()
        {
            List<Especie> result = default(List<Especie>);

            var especieDAC = new EspecieDAC();
            result = especieDAC.Read();
            return result;
        }

        public Especie ListarPorId(int id)
        {
            Especie result = default(Especie);

            var especieDAC = new EspecieDAC();
            result = especieDAC.ReadBy(id);
            return result;
        }

        public void Editar(Especie especie)
        {
            var especieDAC = new EspecieDAC();
            especieDAC.Update(especie);
        }

        public void Borrar(Especie especie)
        {
            var especieDAC = new EspecieDAC();
            especieDAC.Delete(especie.Id);
        }
    }
}
