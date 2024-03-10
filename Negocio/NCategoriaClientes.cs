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
    public class NCategoriaClientes
    {
        private DCategoriaClientes dCategorias;

        public NCategoriaClientes()
        {
            dCategorias = new DCategoriaClientes();
        }

        public List<CategoriaClientes> TodasLasCategorias() 
        {
            return dCategorias.categoriaClientesTodas();
        }

        public List<CategoriaClientes> CategoriasActivas() 
        {
            return dCategorias .categoriaClientesTodas().Where(c => c.Estado == true).ToList();
        }

        public List<CargarCombos> CargaCombo()
        {
            List<CargarCombos> Datos = new List<CargarCombos>();
            var categorias = CategoriasActivas().Select(c => new 
                                                  { c.Descripcion , 
                                                    c.CategoriaClienteId,  })
                                      .ToList();
            foreach (var item in categorias) 
            {
                Datos.Add(new CargarCombos()
                {
                    Valor = item.CategoriaClienteId,
                    Descripcion = item.Descripcion
                });
            }

            return Datos;
        }

        public int AgregarCategoria(CategoriaClientes categoriaClientes) 
        {
            return dCategorias.GuardarCategoria(categoriaClientes);
        }

        public int EditarCategoria(CategoriaClientes categoriaClientes)
        {
            return dCategorias.GuardarCategoria(categoriaClientes);
        }

        public int EliminarCategoria(int categoriaId)
        {
            return dCategorias.EliminarCategoria(categoriaId);
        }
    }
}
