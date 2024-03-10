using Datos.BaseDatos.Modelos;
using Datos.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class DGrupoDescuentoCliente
    {
        Repository<GrupoDescuentoCliente> _repository;
        public DGrupoDescuentoCliente()
        {
            //context = new FerreteriaContext();
            _repository = new Repository<GrupoDescuentoCliente>();
        }
        public int GrupoDescuentoClienteId { get; set; }
        public string Codigo { get; set; }
        public string Descripcion { get; set; }
        public bool Estado { get; set; }
        public DateTime FechaCreacion { get; set; }
        public DateTime FechaModificacion { get; set; }

        public List<GrupoDescuentoCliente> todosLosGrupos()
        {
            return _repository.Consulta().ToList();
        }

        public int Guardar(GrupoDescuentoCliente grupo)
        {
            if (grupo.GrupoDescuentoClienteId == 0)
            {
                grupo.FechaCreacion = DateTime.Now;
                grupo.FechaModificacion = DateTime.Now;
                _repository.Agregar(grupo);
                return 1;
            }
            else
            {
                var grupoInDb = _repository.Consulta().FirstOrDefault(c => c.GrupoDescuentoClienteId == grupo.GrupoDescuentoClienteId);

                if (grupoInDb != null)
                {
                    grupoInDb.FechaModificacion = DateTime.Now;
                    grupoInDb.Codigo = grupo.Codigo;
                    grupoInDb.Descripcion = grupo.Descripcion;
                    grupoInDb.Estado = grupo.Estado;
                    _repository.Editar(grupoInDb);
                    return 1;
                }
                return 0;
            }

        }

        public int EliminarCategoria(int grupoId)
        {
            var grupoInDb = _repository.Consulta().FirstOrDefault(c => c.GrupoDescuentoClienteId == grupoId);

            if (grupoInDb != null)
            {
                _repository.Eliminar(grupoInDb);
                return 1;
            }
            return 0;
        }
    }
}
