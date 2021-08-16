namespace Encuesta
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.metroComboBox1 = new MetroFramework.Controls.MetroComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.IdDocumento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sucursal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefono1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefono2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Documento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Folio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Almacen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_Seleccionar = new System.Windows.Forms.Button();
            this.btn_salir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Sucursal:";
            // 
            // metroComboBox1
            // 
            this.metroComboBox1.FormattingEnabled = true;
            this.metroComboBox1.ItemHeight = 23;
            this.metroComboBox1.Location = new System.Drawing.Point(113, 92);
            this.metroComboBox1.Name = "metroComboBox1";
            this.metroComboBox1.Size = new System.Drawing.Size(285, 29);
            this.metroComboBox1.TabIndex = 9;
            this.metroComboBox1.UseSelectable = true;
            this.metroComboBox1.SelectedIndexChanged += new System.EventHandler(this.metroComboBox1_SelectedIndexChanged);
            this.metroComboBox1.DropDownClosed += new System.EventHandler(this.metroComboBox1_DropDownClosed);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdDocumento,
            this.Nombre,
            this.Sucursal,
            this.Telefono1,
            this.Telefono2,
            this.Documento,
            this.Folio,
            this.Almacen,
            this.CodCliente,
            this.Fecha});
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(30, 165);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1217, 399);
            this.dataGridView1.TabIndex = 13;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // IdDocumento
            // 
            this.IdDocumento.DataPropertyName = "CIDDOCUMENTO";
            this.IdDocumento.HeaderText = "IdDocumento";
            this.IdDocumento.Name = "IdDocumento";
            this.IdDocumento.ReadOnly = true;
            this.IdDocumento.Visible = false;
            // 
            // Nombre
            // 
            this.Nombre.DataPropertyName = "CRAZONSOCIAL";
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Width = 200;
            // 
            // Sucursal
            // 
            this.Sucursal.DataPropertyName = "sucnom";
            this.Sucursal.HeaderText = "Sucursal";
            this.Sucursal.Name = "Sucursal";
            this.Sucursal.ReadOnly = true;
            this.Sucursal.Width = 150;
            // 
            // Telefono1
            // 
            this.Telefono1.DataPropertyName = "ctelefono1";
            this.Telefono1.HeaderText = "Teléfono1";
            this.Telefono1.Name = "Telefono1";
            this.Telefono1.ReadOnly = true;
            // 
            // Telefono2
            // 
            this.Telefono2.DataPropertyName = "ctelefono2";
            this.Telefono2.HeaderText = "Teléfono2";
            this.Telefono2.Name = "Telefono2";
            this.Telefono2.ReadOnly = true;
            // 
            // Documento
            // 
            this.Documento.DataPropertyName = "CSERIEDOCUMENTO";
            this.Documento.HeaderText = "Documento";
            this.Documento.Name = "Documento";
            this.Documento.ReadOnly = true;
            // 
            // Folio
            // 
            this.Folio.DataPropertyName = "CFOLIO";
            this.Folio.HeaderText = "Folio";
            this.Folio.Name = "Folio";
            this.Folio.ReadOnly = true;
            // 
            // Almacen
            // 
            this.Almacen.DataPropertyName = "cidalmacen";
            this.Almacen.HeaderText = "Almacén";
            this.Almacen.Name = "Almacen";
            this.Almacen.ReadOnly = true;
            // 
            // CodCliente
            // 
            this.CodCliente.DataPropertyName = "CCODIGOCLIENTE";
            this.CodCliente.HeaderText = "CodCliente";
            this.CodCliente.Name = "CodCliente";
            this.CodCliente.ReadOnly = true;
            // 
            // Fecha
            // 
            this.Fecha.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Fecha.DataPropertyName = "CFECHA";
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.Name = "Fecha";
            this.Fecha.ReadOnly = true;
            // 
            // btn_Seleccionar
            // 
            this.btn_Seleccionar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_Seleccionar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_Seleccionar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Seleccionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Seleccionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Seleccionar.ForeColor = System.Drawing.Color.White;
            this.btn_Seleccionar.Location = new System.Drawing.Point(30, 589);
            this.btn_Seleccionar.Name = "btn_Seleccionar";
            this.btn_Seleccionar.Size = new System.Drawing.Size(114, 35);
            this.btn_Seleccionar.TabIndex = 86;
            this.btn_Seleccionar.Text = "SELECCIONAR";
            this.btn_Seleccionar.UseVisualStyleBackColor = false;
            this.btn_Seleccionar.Click += new System.EventHandler(this.btn_Seleccionar_Click);
            // 
            // btn_salir
            // 
            this.btn_salir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_salir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_salir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_salir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_salir.ForeColor = System.Drawing.Color.White;
            this.btn_salir.Location = new System.Drawing.Point(1123, 589);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(114, 35);
            this.btn_salir.TabIndex = 89;
            this.btn_salir.Text = "SALIR";
            this.btn_salir.UseVisualStyleBackColor = false;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1249, 646);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.btn_Seleccionar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.metroComboBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Encuestas";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroComboBox metroComboBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_Seleccionar;
        private System.Windows.Forms.Button btn_salir;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdDocumento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sucursal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefono1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefono2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Documento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Folio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Almacen;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
    }
}

