
namespace FerreMas
{
    partial class vClientes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dgClientes = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.Codigo = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.txtClienteId = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtDNI = new System.Windows.Forms.TextBox();
            this.txtNombres = new System.Windows.Forms.TextBox();
            this.txtApellidos = new System.Windows.Forms.TextBox();
            this.cbCategorias = new System.Windows.Forms.ComboBox();
            this.cbActivo = new System.Windows.Forms.CheckBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.cbSoloActivos = new System.Windows.Forms.CheckBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.cbGrupo = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgClientes
            // 
            this.dgClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgClientes.Location = new System.Drawing.Point(12, 370);
            this.dgClientes.Name = "dgClientes";
            this.dgClientes.RowHeadersWidth = 51;
            this.dgClientes.RowTemplate.Height = 24;
            this.dgClientes.Size = new System.Drawing.Size(1074, 357);
            this.dgClientes.TabIndex = 0;
            this.dgClientes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgClientes_CellContentClick);
            this.dgClientes.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgClientes_CellDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cliente Id";
            // 
            // Codigo
            // 
            this.Codigo.AutoSize = true;
            this.Codigo.Location = new System.Drawing.Point(12, 88);
            this.Codigo.Name = "Codigo";
            this.Codigo.Size = new System.Drawing.Size(52, 17);
            this.Codigo.TabIndex = 2;
            this.Codigo.Text = "Codigo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "DNI";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nombres";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Apellidos";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 208);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "Categoria";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 277);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 17);
            this.label6.TabIndex = 7;
            this.label6.Text = "Estado";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(85, 304);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(83, 28);
            this.btnGuardar.TabIndex = 8;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // txtClienteId
            // 
            this.txtClienteId.Location = new System.Drawing.Point(85, 50);
            this.txtClienteId.Name = "txtClienteId";
            this.txtClienteId.ReadOnly = true;
            this.txtClienteId.Size = new System.Drawing.Size(100, 22);
            this.txtClienteId.TabIndex = 9;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(85, 85);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(100, 22);
            this.txtCodigo.TabIndex = 10;
            // 
            // txtDNI
            // 
            this.txtDNI.Location = new System.Drawing.Point(85, 113);
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.Size = new System.Drawing.Size(167, 22);
            this.txtDNI.TabIndex = 11;
            // 
            // txtNombres
            // 
            this.txtNombres.Location = new System.Drawing.Point(85, 140);
            this.txtNombres.Name = "txtNombres";
            this.txtNombres.Size = new System.Drawing.Size(262, 22);
            this.txtNombres.TabIndex = 12;
            // 
            // txtApellidos
            // 
            this.txtApellidos.Location = new System.Drawing.Point(85, 176);
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.Size = new System.Drawing.Size(262, 22);
            this.txtApellidos.TabIndex = 13;
            // 
            // cbCategorias
            // 
            this.cbCategorias.FormattingEnabled = true;
            this.cbCategorias.Location = new System.Drawing.Point(85, 204);
            this.cbCategorias.Name = "cbCategorias";
            this.cbCategorias.Size = new System.Drawing.Size(167, 24);
            this.cbCategorias.TabIndex = 14;
            // 
            // cbActivo
            // 
            this.cbActivo.AutoSize = true;
            this.cbActivo.Location = new System.Drawing.Point(85, 273);
            this.cbActivo.Name = "cbActivo";
            this.cbActivo.Size = new System.Drawing.Size(68, 21);
            this.cbActivo.TabIndex = 15;
            this.cbActivo.Text = "Activo";
            this.cbActivo.UseVisualStyleBackColor = true;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // cbSoloActivos
            // 
            this.cbSoloActivos.AutoSize = true;
            this.cbSoloActivos.Location = new System.Drawing.Point(12, 343);
            this.cbSoloActivos.Name = "cbSoloActivos";
            this.cbSoloActivos.Size = new System.Drawing.Size(156, 21);
            this.cbSoloActivos.TabIndex = 16;
            this.cbSoloActivos.Text = "Mostrar solo activos";
            this.cbSoloActivos.UseVisualStyleBackColor = true;
            this.cbSoloActivos.CheckedChanged += new System.EventHandler(this.cbSoloActivos_CheckedChanged);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(174, 304);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(72, 28);
            this.btnEliminar.TabIndex = 17;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // cbGrupo
            // 
            this.cbGrupo.FormattingEnabled = true;
            this.cbGrupo.Location = new System.Drawing.Point(85, 237);
            this.cbGrupo.Name = "cbGrupo";
            this.cbGrupo.Size = new System.Drawing.Size(167, 24);
            this.cbGrupo.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 241);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 17);
            this.label7.TabIndex = 18;
            this.label7.Text = "Grupo";
            // 
            // vClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1098, 739);
            this.Controls.Add(this.cbGrupo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.cbSoloActivos);
            this.Controls.Add(this.cbActivo);
            this.Controls.Add(this.cbCategorias);
            this.Controls.Add(this.txtApellidos);
            this.Controls.Add(this.txtNombres);
            this.Controls.Add(this.txtDNI);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.txtClienteId);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Codigo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgClientes);
            this.Name = "vClientes";
            this.Text = "vClientes";
            this.Load += new System.EventHandler(this.vClientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgClientes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Codigo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TextBox txtClienteId;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtDNI;
        private System.Windows.Forms.TextBox txtNombres;
        private System.Windows.Forms.TextBox txtApellidos;
        private System.Windows.Forms.ComboBox cbCategorias;
        private System.Windows.Forms.CheckBox cbActivo;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.CheckBox cbSoloActivos;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.ComboBox cbGrupo;
        private System.Windows.Forms.Label label7;
    }
}