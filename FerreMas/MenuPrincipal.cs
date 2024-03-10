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
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void categoriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CategoriaCliente categoria = new CategoriaCliente();
            categoria.MdiParent = this;
            categoria.Show();
        }

        private void clientesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            vClientes clientes = new vClientes();
            clientes.MdiParent = this;
            clientes.Show();
        }

        private void gruposDeDescuentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            vGrupoDescuentoCliente gclientes = new vGrupoDescuentoCliente();
            gclientes.MdiParent = this;
            gclientes.Show();
        }
    }
}
