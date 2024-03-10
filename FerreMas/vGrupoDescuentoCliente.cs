using Datos;
using Datos.BaseDatos.Modelos;
using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FerreMas
{
    public partial class vGrupoDescuentoCliente : Form
    {
        private NDescuentoCliente ngrupo;
        public vGrupoDescuentoCliente()
        {
            InitializeComponent();
            ngrupo = new NDescuentoCliente();
        }

        private void CategoriaCliente_Load(object sender, EventArgs e)
        {
            cargarDatos();
        }

        private void cargarDatos()
        {
            dgCategorias.DataSource = ngrupo.TodasLosGrupos();
        }

        private void cbActivos_CheckedChanged(object sender, EventArgs e)
        {
            dgCategorias.DataSource = ngrupo.GruposActivos();
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            var agregar = false;
            var grupoId = txtGrupoId.Text.ToString();
            var codigo = txtCodigo.Text.ToString();
            var descripcion = txtDescripcion.Text.ToString();
            if (string.IsNullOrEmpty(grupoId) || string.IsNullOrWhiteSpace(grupoId))
            {
                agregar = true;
            }
            if (string.IsNullOrEmpty(codigo) || string.IsNullOrWhiteSpace(codigo))
            {
                errorProvider1.SetError(txtCodigo, "Debe ingresar el codigo");
                return;
            }
            if (string.IsNullOrEmpty(descripcion) || string.IsNullOrWhiteSpace(descripcion))
            {
                errorProvider1.SetError(txtDescripcion, "Debe ingresar una descripcion");
                return;
            }

            if (agregar)
            {
                ngrupo.Agregar(new GrupoDescuentoCliente()
                {
                    Codigo = codigo,
                    Descripcion = descripcion,
                    Estado = cbEstado.Checked
                });
            }
            else 
            {
                ngrupo.Editar(new GrupoDescuentoCliente()
                {
                    GrupoDescuentoClienteId = int.Parse(grupoId),
                    Codigo = codigo,
                    Descripcion = descripcion,
                    Estado = cbEstado.Checked
                });
            }
            
            cargarDatos();
            LimpiarDatos();
        }

        private void LimpiarDatos()
        {
            txtGrupoId.Text = "";
            txtCodigo.Text = "";
            txtDescripcion.Text = "";
            cbEstado.Checked = false;
            errorProvider1.Clear();
        }

        private void dgCategorias_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtGrupoId.Text = dgCategorias.CurrentRow.Cells["GrupoDescuentoClienteId"].Value.ToString();
            txtCodigo.Text = dgCategorias.CurrentRow.Cells["Codigo"].Value.ToString();
            txtDescripcion.Text = dgCategorias.CurrentRow.Cells["Descripcion"].Value.ToString();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            var grupoId = txtGrupoId.Text.ToString();
            if (string.IsNullOrEmpty(grupoId) || string.IsNullOrWhiteSpace(grupoId))
            {
                return;
            }
            ngrupo.EliminarCategoria(int.Parse(grupoId));
            cargarDatos();
            LimpiarDatos();
        }
    }
}
