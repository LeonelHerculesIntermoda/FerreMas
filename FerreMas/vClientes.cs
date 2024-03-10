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
    public partial class vClientes : Form
    {
        private NClientes nClientes;
        private NCategoriaClientes nCategoriaClientes;
        private NDescuentoCliente ngrupo;
        public vClientes()
        {
            InitializeComponent();
            nClientes = new NClientes();
            nCategoriaClientes = new NCategoriaClientes();
            ngrupo = new NDescuentoCliente();
        }

        private void vClientes_Load(object sender, EventArgs e)
        {
            CargarDatos();
            CargarCombos();
        }

        

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (ValidarDatos()) 
            {
                Cliente Cliente = new Cliente()
                {
                    Codigo = txtCodigo.Text.ToString(),
                    DNI = txtDNI.Text.ToString(),
                    Nombres = txtNombres.Text.ToString(),
                    Apellidos = txtApellidos.Text.ToString(),
                    CategoriaClienteId = int.Parse(cbCategorias.SelectedValue.ToString()),
                    GrupoDescuentoClienteId = int.Parse(cbGrupo.SelectedValue.ToString()),
                    Estado = cbActivo.Checked
                };
                if (!string.IsNullOrEmpty(txtClienteId.Text) || !string.IsNullOrWhiteSpace(txtClienteId.Text))
                {
                    if (int.Parse(txtClienteId.Text.ToString()) != 0)
                    {
                        Cliente.ClienteId = int.Parse(txtClienteId.Text.ToString());
                    }
                }
                nClientes.Agregar(Cliente);
                LimpiarCampos();
                CargarDatos();
            }
        }

        private void CargarDatos()
        {
            var clientes = nClientes.obtenerClientes().Select(c => new { c.ClienteId, c.Codigo, c.DNI, c.Nombres, c.Apellidos, c.Estado, c.CategoriaClienteId, c.CategoriaClientes.Descripcion, c.GrupoDescuentoClienteId});
            //dgClientes.DataSource = nClientes.obtenerClientes();
            dgClientes.DataSource = clientes.ToList();
        }

        private void CargarCombos()
        {
            //nClientes.obtenerClientes().Select(c => new { c.ClienteId, c.Codigo, c.Nombres, c.Apellidos, c.CategoriaClienteId, c.CategoriaClientes.Descripcion });
            //cbCategorias.DataSource = nCategoriaClientes.CategoriasActivas()
                                                   //     .Select(c => new { c.CategoriaClienteId, c.Descripcion })
                                                   //     .ToList();
            //cbCategorias.ValueMember = "CategoriaClienteId";
            //cbCategorias.DisplayMember = "Descripcion";
            cbCategorias.DataSource = nCategoriaClientes.CargaCombo();                              
            cbCategorias.ValueMember = "Valor";
            cbCategorias.DisplayMember = "Descripcion";

            cbGrupo.DataSource = ngrupo.CargaCombo();
            cbGrupo.ValueMember = "Valor";
            cbGrupo.DisplayMember = "Descripcion";
        }

        private bool ValidarDatos() 
        {
            var FormularioValido = true;
            if (string.IsNullOrEmpty(txtCodigo.Text.ToString()) || string.IsNullOrWhiteSpace(txtCodigo.Text.ToString()))
            {
                FormularioValido = false;
                errorProvider1.SetError(txtCodigo, "Debe ingresar el codigo de cliente");
                return FormularioValido;
            }
            if (string.IsNullOrEmpty(txtDNI.Text.ToString()) || string.IsNullOrWhiteSpace(txtDNI.Text.ToString()))
            {
                FormularioValido = false;
                errorProvider1.SetError(txtDNI, "Debe ingresar el DNI del cliente");
                return FormularioValido;
            }
            if (string.IsNullOrEmpty(txtNombres.Text.ToString()) || string.IsNullOrWhiteSpace(txtNombres.Text.ToString()))
            {
                FormularioValido = false;
                errorProvider1.SetError(txtNombres, "Debe ingresar el nombre del cliente");
                return FormularioValido;
            }
            if (string.IsNullOrEmpty(txtApellidos.Text.ToString()) || string.IsNullOrWhiteSpace(txtApellidos.Text.ToString()))
            {
                FormularioValido = false;
                errorProvider1.SetError(txtApellidos, "Debe ingresar los apellidos del cliente");
                return FormularioValido;
            }
            return FormularioValido;
        }
        private void LimpiarCampos() 
        {
            txtCodigo.Text = "";
            txtDNI.Text = "";
            txtNombres.Text = "";
            txtApellidos.Text = "";
            cbActivo.Checked = false;
            errorProvider1.Clear();
        }

        private void cbSoloActivos_CheckedChanged(object sender, EventArgs e)
        {
            if (cbSoloActivos.Checked)
            {
                var clientes = nClientes.obtenerClientes()
                                        .Where(c => c.Estado == true)
                                        .Select(c => new { c.ClienteId, c.Codigo, c.DNI, c.Nombres, c.Apellidos, c.Estado, c.CategoriaClienteId, c.CategoriaClientes.Descripcion });
                dgClientes.DataSource = clientes.ToList();
            }
            else 
            {
                CargarDatos();
                
            }
        }

        private void dgClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgClientes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtClienteId.Text = dgClientes.CurrentRow.Cells["ClienteId"].Value.ToString();
            txtCodigo.Text = dgClientes.CurrentRow.Cells["Codigo"].Value.ToString();
            txtDNI.Text = dgClientes.CurrentRow.Cells["DNI"].Value.ToString();
            txtNombres.Text = dgClientes.CurrentRow.Cells["Nombres"].Value.ToString();
            txtApellidos.Text = dgClientes.CurrentRow.Cells["Apellidos"].Value.ToString();
            var categoria = dgClientes.CurrentRow.Cells["CategoriaClienteId"].Value.ToString();
            cbCategorias.SelectedValue = int.Parse(categoria);
            var grupo = dgClientes.CurrentRow.Cells["GrupoDescuentoClienteId"].Value.ToString();
            cbGrupo.SelectedValue = int.Parse(grupo);
            cbActivo.Checked = bool.Parse(dgClientes.CurrentRow.Cells["Estado"].Value.ToString());
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtClienteId.Text.ToString()) || 
                !string.IsNullOrWhiteSpace(txtClienteId.Text.ToString()))
            {
                if (int.Parse(txtClienteId.Text.ToString()) != 0)
                {
                    var clienteId = int.Parse(txtClienteId.Text.ToString());
                    nClientes.Eliminar(clienteId);
                    CargarDatos();
                }
            }   
        }
    }
}
