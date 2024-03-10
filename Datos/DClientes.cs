using Datos.BaseDatos;
using Datos.BaseDatos.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Datos.Core;

namespace Datos
{
    public class DClientes
    {
        //private FerreteriaContext context;
        Repository<Cliente> _repository;

        public DClientes()
        {
            //context = new FerreteriaContext();
            _repository = new Repository<Cliente>();
        }
        public int ClienteId { get; set; }
        public string Codigo { get; set; }
        public string DNI { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public DateTime FechaIngreso { get; set; }
        public int CategoriaClienteId { get; set; }
        public int GrupoDescuentoClienteId { get; set; }

        public bool Estado { get; set; }

        public List<Cliente> TodosLosClientes() 
        {
            //return context.Clientes.Include(c => c.CategoriaClientes)
            //                       .ToList();
            return _repository.Consulta().Include(c => c.CategoriaClientes)
                                         .Include(c=> c.GrupoDescuentoCliente)
                                         .ToList();

        }
        public int Guardar(Cliente cliente) 
        {
            if (cliente.ClienteId == 0)
            {
                _repository.Agregar(cliente);
                return 1;
            }
            else 
            {
                var clienteInDb = _repository.Consulta().FirstOrDefault(c=>c.ClienteId == cliente.ClienteId);
                if (clienteInDb != null) 
                {
                    clienteInDb.Codigo = cliente.Codigo;
                    clienteInDb.DNI = cliente.DNI;
                    clienteInDb.Nombres = cliente.Nombres;
                    clienteInDb.Apellidos = cliente.Apellidos;
                    clienteInDb.Estado = cliente.Estado;
                    clienteInDb.FechaModificacion = cliente.FechaModificacion;
                    clienteInDb.GrupoDescuentoClienteId = cliente.GrupoDescuentoClienteId;
                    clienteInDb.CategoriaClienteId = cliente.CategoriaClienteId;
                    _repository.Editar(clienteInDb);
                    return 1;
                }

                return 0;
            }
        }
        public int Eliminar(int clienteId) 
        {
            var clienteInDb = _repository.Consulta().FirstOrDefault(c => c.ClienteId == clienteId);
            if (clienteInDb != null) 
            {
                _repository.Eliminar(clienteInDb);
                return 1;
            }
            return 0;
        }
    }
}
