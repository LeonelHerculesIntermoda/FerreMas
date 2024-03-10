using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.BaseDatos.Modelos
{
    public class Proveedor
    {
        [Key]
        public int ProveedorId { get; set; }
    }
}
