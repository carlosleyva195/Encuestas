namespace Encuesta
{
    partial class Preguntas
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
            this.btn_salir = new System.Windows.Forms.Button();
            this.btn_Guardar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Pregunta1 = new MetroFramework.Controls.MetroComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Observacion = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.Pregunta2 = new MetroFramework.Controls.MetroComboBox();
            this.Pregunta3 = new MetroFramework.Controls.MetroComboBox();
            this.btn_Contestar = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_salir
            // 
            this.btn_salir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_salir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_salir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_salir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_salir.ForeColor = System.Drawing.Color.White;
            this.btn_salir.Location = new System.Drawing.Point(499, 527);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(114, 35);
            this.btn_salir.TabIndex = 91;
            this.btn_salir.Text = "SALIR";
            this.btn_salir.UseVisualStyleBackColor = false;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // btn_Guardar
            // 
            this.btn_Guardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_Guardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_Guardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Guardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Guardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Guardar.ForeColor = System.Drawing.Color.White;
            this.btn_Guardar.Location = new System.Drawing.Point(93, 527);
            this.btn_Guardar.Name = "btn_Guardar";
            this.btn_Guardar.Size = new System.Drawing.Size(114, 35);
            this.btn_Guardar.TabIndex = 90;
            this.btn_Guardar.Text = "GUARDAR";
            this.btn_Guardar.UseVisualStyleBackColor = false;
            this.btn_Guardar.Click += new System.EventHandler(this.btn_Guardar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Calibri", 22F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(297, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 37);
            this.label1.TabIndex = 92;
            this.label1.Text = "Preguntas";
            // 
            // Pregunta1
            // 
            this.Pregunta1.FormattingEnabled = true;
            this.Pregunta1.ItemHeight = 23;
            this.Pregunta1.Items.AddRange(new object[] {
            "Malo",
            "Regular",
            "Bueno"});
            this.Pregunta1.Location = new System.Drawing.Point(614, 224);
            this.Pregunta1.Name = "Pregunta1";
            this.Pregunta1.Size = new System.Drawing.Size(137, 29);
            this.Pregunta1.TabIndex = 93;
            this.Pregunta1.UseSelectable = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(138, 372);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(438, 23);
            this.label2.TabIndex = 95;
            this.label2.Text = "¿Tienes algún comentario o sugerencia para nosotros?";
            // 
            // Observacion
            // 
            this.Observacion.Location = new System.Drawing.Point(96, 413);
            this.Observacion.Multiline = true;
            this.Observacion.Name = "Observacion";
            this.Observacion.Size = new System.Drawing.Size(520, 88);
            this.Observacion.TabIndex = 96;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(63, 230);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(357, 23);
            this.label3.TabIndex = 97;
            this.label3.Text = "1.- Como lo atendieron en nuestra sucursal?";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(63, 278);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(321, 23);
            this.label4.TabIndex = 98;
            this.label4.Text = "2.- Qué le parecieron nuestros precios?";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(63, 345);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 23);
            this.label5.TabIndex = 99;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(63, 326);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(378, 23);
            this.label6.TabIndex = 100;
            this.label6.Text = "3.- Qué le parecio nuestro servicio en general?";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(63, 390);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 23);
            this.label7.TabIndex = 101;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(141, 157);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 17);
            this.label8.TabIndex = 102;
            this.label8.Text = "label8";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.White;
            this.label9.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(63, 152);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 23);
            this.label9.TabIndex = 103;
            this.label9.Text = "Cliente:";
            // 
            // Pregunta2
            // 
            this.Pregunta2.FormattingEnabled = true;
            this.Pregunta2.ItemHeight = 23;
            this.Pregunta2.Items.AddRange(new object[] {
            "Malo",
            "Regular",
            "Bueno"});
            this.Pregunta2.Location = new System.Drawing.Point(614, 272);
            this.Pregunta2.Name = "Pregunta2";
            this.Pregunta2.Size = new System.Drawing.Size(137, 29);
            this.Pregunta2.TabIndex = 105;
            this.Pregunta2.UseSelectable = true;
            // 
            // Pregunta3
            // 
            this.Pregunta3.FormattingEnabled = true;
            this.Pregunta3.ItemHeight = 23;
            this.Pregunta3.Items.AddRange(new object[] {
            "Malo",
            "Regular",
            "Bueno"});
            this.Pregunta3.Location = new System.Drawing.Point(614, 320);
            this.Pregunta3.Name = "Pregunta3";
            this.Pregunta3.Size = new System.Drawing.Size(137, 29);
            this.Pregunta3.TabIndex = 106;
            this.Pregunta3.UseSelectable = true;
            // 
            // btn_Contestar
            // 
            this.btn_Contestar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_Contestar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_Contestar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Contestar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Contestar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Contestar.ForeColor = System.Drawing.Color.White;
            this.btn_Contestar.Location = new System.Drawing.Point(614, 148);
            this.btn_Contestar.Name = "btn_Contestar";
            this.btn_Contestar.Size = new System.Drawing.Size(114, 35);
            this.btn_Contestar.TabIndex = 109;
            this.btn_Contestar.Text = "NO CONTESTO";
            this.btn_Contestar.UseVisualStyleBackColor = false;
            this.btn_Contestar.Click += new System.EventHandler(this.btn_Contestar_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.White;
            this.label10.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(63, 189);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(81, 23);
            this.label10.TabIndex = 110;
            this.label10.Text = "Sucursal:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(150, 195);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(54, 17);
            this.label11.TabIndex = 111;
            this.label11.Text = "label11";
            // 
            // Preguntas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 654);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btn_Contestar);
            this.Controls.Add(this.Pregunta3);
            this.Controls.Add(this.Pregunta2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Observacion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Pregunta1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.btn_Guardar);
            this.Name = "Preguntas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Preguntas";
            this.Load += new System.EventHandler(this.Preguntas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_salir;
        private System.Windows.Forms.Button btn_Guardar;
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroComboBox Pregunta1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Observacion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private MetroFramework.Controls.MetroComboBox Pregunta2;
        private MetroFramework.Controls.MetroComboBox Pregunta3;
        private System.Windows.Forms.Button btn_Contestar;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
    }
}