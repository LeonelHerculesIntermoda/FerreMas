using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.BaseDatos.Modelos
{
    public class CategoriaClientes
    {
        [Key]
        public int CategoriaClienteId { get; set; }

        [Required]
        [MaxLength(10)]
        public string Codigo { get; set; }

        [Required]
        [MaxLength(150)]
        public string Descripcion { get; set; }
        public bool Estado { get; set; }

        [Required]
        public DateTime FechaCreacion { get; set; }

        [Required]
        public DateTime FechaModificacion { get; set; }
    }
}
