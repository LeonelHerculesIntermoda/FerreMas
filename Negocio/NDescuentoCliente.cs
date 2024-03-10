using Datos;
using Datos.BaseDatos.Modelos;
using Negocio.Comun;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class NDescuentoCliente
    {
        private DGrupoDescuentoCliente dgrupos;

        public NDescuentoCliente()
        {
            dgrupos = new DGrupoDescuentoCliente();
        }

        public List<GrupoDescuentoCliente> TodasLosGrupos()
        {
            return dgrupos.todosLosGrupos();
        }

        public List<GrupoDescuentoCliente> GruposActivos()
        {
            return dgrupos.todosLosGrupos().Where(c => c.Estado == true).ToList();
        }

        public List<CargarCombos> CargaCombo()
        {
            List<CargarCombos> Datos = new List<CargarCombos>();
            var categorias = GruposActivos().Select(c => new
            {
                c.Descripcion,
                c.GrupoDescuentoClienteId,
            })
                                      .ToList();
            foreach (var item in categorias)
            {
                Datos.Add(new CargarCombos()
                {
                    Valor = item.GrupoDescuentoClienteId,
                    Descripcion = item.Descripcion
                });
            }

            return Datos;
        }

        public int Agregar(GrupoDescuentoCliente grupoDescuentoCliente)
        {
            return dgrupos.Guardar(grupoDescuentoCliente);
        }

        public int Editar(GrupoDescuentoCliente grupoDescuentoCliente)
        {
            return dgrupos.Guardar(grupoDescuentoCliente);
        }

        public int EliminarCategoria(int grupoId)
        {
            return dgrupos.EliminarCategoria(grupoId);
        }
    }
}
