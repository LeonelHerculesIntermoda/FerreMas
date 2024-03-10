using Datos;
using Datos.BaseDatos.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class NClientes
    {
        private DClientes dClientes;
        public NClientes()
        {
            dClientes = new DClientes();
        }

        public List<Cliente> obtenerClientes() 
        {
            return dClientes.TodosLosClientes();
        }

        public List<Cliente> obtenerClientesInactivos() 
        {
            return dClientes.TodosLosClientes().Where(c => c.Estado == true).ToList();
        }

        public List<Cliente> obtenerClientesGrid() 
        {
            var clientes = dClientes.TodosLosClientes().Select(c => new { c.ClienteId, c.Codigo, c.Nombres, c.Apellidos, c.CategoriaClienteId, c.CategoriaClientes.Descripcion });
            return dClientes.TodosLosClientes().ToList();
        }

        public int Agregar(Cliente cliente) 
        {
            cliente.FechaCreacion = DateTime.Now;
            cliente.FechaModificacion = DateTime.Now;
            cliente.FechaIngreso = DateTime.Now;
            return dClientes.Guardar(cliente);
        }

        public int Editar(Cliente cliente)
        {
            cliente.FechaModificacion = DateTime.Now;
            return dClientes.Guardar(cliente);
        }

        public int Eliminar(int clienteId)
        {
            return dClientes.Eliminar(clienteId);
        }
    }
}
