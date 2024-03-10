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
    public partial class CategoriaCliente : Form
    {
        private NCategoriaClientes nCategoriaClientes;
        public CategoriaCliente()
        {
            InitializeComponent();
            nCategoriaClientes = new NCategoriaClientes();
        }

        private void CategoriaCliente_Load(object sender, EventArgs e)
        {
            cargarDatos();
        }

        private void cargarDatos()
        {
            dgCategorias.DataSource = nCategoriaClientes.TodasLasCategorias();
        }

        private void cbActivos_CheckedChanged(object sender, EventArgs e)
        {
            dgCategorias.DataSource = nCategoriaClientes.CategoriasActivas();
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            var agregar = false;
            var categoriaId = txtCategoriaId.Text.ToString();
            var codigo = txtCodigo.Text.ToString();
            var descripcion = txtDescripcion.Text.ToString();
            if (string.IsNullOrEmpty(categoriaId) || string.IsNullOrWhiteSpace(categoriaId))
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
                nCategoriaClientes.AgregarCategoria(new CategoriaClientes()
                {
                    Codigo = codigo,
                    Descripcion = descripcion,
                    Estado = cbEstado.Checked
                });
            }
            else 
            {
                nCategoriaClientes.EditarCategoria(new CategoriaClientes()
                {
                    CategoriaClienteId = int.Parse(categoriaId),
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
            txtCategoriaId.Text = "";
            txtCodigo.Text = "";
            txtDescripcion.Text = "";
            cbEstado.Checked = false;
            errorProvider1.Clear();
        }

        private void dgCategorias_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCategoriaId.Text = dgCategorias.CurrentRow.Cells["CategoriaClienteId"].Value.ToString();
            txtCodigo.Text = dgCategorias.CurrentRow.Cells["Codigo"].Value.ToString();
            txtDescripcion.Text = dgCategorias.CurrentRow.Cells["Descripcion"].Value.ToString();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            var categoriaId = txtCategoriaId.Text.ToString();
            if (string.IsNullOrEmpty(categoriaId) || string.IsNullOrWhiteSpace(categoriaId))
            {
                return;
            }
            nCategoriaClientes.EliminarCategoria(int.Parse(categoriaId));
            cargarDatos();
            LimpiarDatos();
        }
    }
}
