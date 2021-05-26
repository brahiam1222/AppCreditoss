namespace Presentacion
{
    partial class FrmAbonos
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.LblUsuario = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtIdCliente = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtNombreAbono = new System.Windows.Forms.TextBox();
            this.dtgCreditos = new System.Windows.Forms.DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtValor = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.LblAprovadoPor = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.LblNcreditos = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.LblPlazo = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.LblDeudaFecha = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.LblAbonos = new System.Windows.Forms.Label();
            this.LblMonto = new System.Windows.Forms.Label();
            this.LblFecha = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.BtnRealizar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgCreditos)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Firebrick;
            this.panel1.Controls.Add(this.LblUsuario);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(4, 1);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1387, 102);
            this.panel1.TabIndex = 3;
            // 
            // LblUsuario
            // 
            this.LblUsuario.AutoSize = true;
            this.LblUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblUsuario.Location = new System.Drawing.Point(833, 79);
            this.LblUsuario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblUsuario.Name = "LblUsuario";
            this.LblUsuario.Size = new System.Drawing.Size(79, 24);
            this.LblUsuario.TabIndex = 54;
            this.LblUsuario.Text = "Usuario:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(28, 38);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 42);
            this.label1.TabIndex = 1;
            this.label1.Text = "ABONOS";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(601, 14);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(271, 38);
            this.button1.TabIndex = 48;
            this.button1.Text = "Regresar a pagina principal";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Firebrick;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(40, 143);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(460, 39);
            this.panel2.TabIndex = 50;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Window;
            this.label2.Location = new System.Drawing.Point(4, 5);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(303, 31);
            this.label2.TabIndex = 2;
            this.label2.Text = "Identificacion del cliente";
            // 
            // TxtIdCliente
            // 
            this.TxtIdCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtIdCliente.Location = new System.Drawing.Point(40, 182);
            this.TxtIdCliente.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TxtIdCliente.MaxLength = 10;
            this.TxtIdCliente.Name = "TxtIdCliente";
            this.TxtIdCliente.Size = new System.Drawing.Size(459, 37);
            this.TxtIdCliente.TabIndex = 49;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Firebrick;
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(508, 143);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(635, 39);
            this.panel3.TabIndex = 52;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Window;
            this.label3.Location = new System.Drawing.Point(4, 5);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 31);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nombre";
            // 
            // TxtNombreAbono
            // 
            this.TxtNombreAbono.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNombreAbono.Location = new System.Drawing.Point(508, 182);
            this.TxtNombreAbono.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TxtNombreAbono.MaxLength = 10;
            this.TxtNombreAbono.Name = "TxtNombreAbono";
            this.TxtNombreAbono.ReadOnly = true;
            this.TxtNombreAbono.Size = new System.Drawing.Size(633, 37);
            this.TxtNombreAbono.TabIndex = 51;
            // 
            // dtgCreditos
            // 
            this.dtgCreditos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgCreditos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtgCreditos.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dtgCreditos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dtgCreditos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgCreditos.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dtgCreditos.Location = new System.Drawing.Point(40, 228);
            this.dtgCreditos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtgCreditos.Name = "dtgCreditos";
            this.dtgCreditos.RowHeadersWidth = 51;
            this.dtgCreditos.Size = new System.Drawing.Size(1103, 185);
            this.dtgCreditos.TabIndex = 53;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Firebrick;
            this.panel4.Controls.Add(this.label4);
            this.panel4.Location = new System.Drawing.Point(40, 437);
            this.panel4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(460, 39);
            this.panel4.TabIndex = 55;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Window;
            this.label4.Location = new System.Drawing.Point(4, 5);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(202, 31);
            this.label4.TabIndex = 2;
            this.label4.Text = "Valor del abono";
            // 
            // TxtValor
            // 
            this.TxtValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtValor.Location = new System.Drawing.Point(40, 476);
            this.TxtValor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TxtValor.MaxLength = 10;
            this.TxtValor.Name = "TxtValor";
            this.TxtValor.Size = new System.Drawing.Size(459, 37);
            this.TxtValor.TabIndex = 54;
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel5.Controls.Add(this.LblAprovadoPor);
            this.panel5.Controls.Add(this.label10);
            this.panel5.Controls.Add(this.LblNcreditos);
            this.panel5.Controls.Add(this.label5);
            this.panel5.Location = new System.Drawing.Point(40, 561);
            this.panel5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(459, 170);
            this.panel5.TabIndex = 56;
            // 
            // LblAprovadoPor
            // 
            this.LblAprovadoPor.AutoSize = true;
            this.LblAprovadoPor.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblAprovadoPor.Location = new System.Drawing.Point(193, 114);
            this.LblAprovadoPor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblAprovadoPor.Name = "LblAprovadoPor";
            this.LblAprovadoPor.Size = new System.Drawing.Size(39, 39);
            this.LblAprovadoPor.TabIndex = 66;
            this.LblAprovadoPor.Text = "--";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(11, 123);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(161, 29);
            this.label10.TabIndex = 65;
            this.label10.Text = "Aprobado por";
            // 
            // LblNcreditos
            // 
            this.LblNcreditos.AutoSize = true;
            this.LblNcreditos.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNcreditos.Location = new System.Drawing.Point(193, 26);
            this.LblNcreditos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblNcreditos.Name = "LblNcreditos";
            this.LblNcreditos.Size = new System.Drawing.Size(39, 39);
            this.LblNcreditos.TabIndex = 58;
            this.LblNcreditos.Text = "--";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(8, 26);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(165, 39);
            this.label5.TabIndex = 57;
            this.label5.Text = "Nº credito";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.LblPlazo);
            this.panel6.Controls.Add(this.label15);
            this.panel6.Controls.Add(this.LblDeudaFecha);
            this.panel6.Controls.Add(this.label13);
            this.panel6.Controls.Add(this.LblAbonos);
            this.panel6.Controls.Add(this.LblMonto);
            this.panel6.Controls.Add(this.LblFecha);
            this.panel6.Controls.Add(this.label9);
            this.panel6.Controls.Add(this.label8);
            this.panel6.Controls.Add(this.label7);
            this.panel6.Controls.Add(this.label6);
            this.panel6.Location = new System.Drawing.Point(519, 437);
            this.panel6.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(624, 295);
            this.panel6.TabIndex = 57;
            // 
            // LblPlazo
            // 
            this.LblPlazo.AutoSize = true;
            this.LblPlazo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPlazo.Location = new System.Drawing.Point(267, 228);
            this.LblPlazo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblPlazo.Name = "LblPlazo";
            this.LblPlazo.Size = new System.Drawing.Size(39, 39);
            this.LblPlazo.TabIndex = 67;
            this.LblPlazo.Text = "--";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(8, 236);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(73, 29);
            this.label15.TabIndex = 66;
            this.label15.Text = "Plazo";
            // 
            // LblDeudaFecha
            // 
            this.LblDeudaFecha.AutoSize = true;
            this.LblDeudaFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDeudaFecha.Location = new System.Drawing.Point(267, 181);
            this.LblDeudaFecha.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblDeudaFecha.Name = "LblDeudaFecha";
            this.LblDeudaFecha.Size = new System.Drawing.Size(39, 39);
            this.LblDeudaFecha.TabIndex = 65;
            this.LblDeudaFecha.Text = "--";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(8, 190);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(192, 29);
            this.label13.TabIndex = 64;
            this.label13.Text = "Deuda a la fecha";
            // 
            // LblAbonos
            // 
            this.LblAbonos.AutoSize = true;
            this.LblAbonos.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblAbonos.Location = new System.Drawing.Point(267, 132);
            this.LblAbonos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblAbonos.Name = "LblAbonos";
            this.LblAbonos.Size = new System.Drawing.Size(39, 39);
            this.LblAbonos.TabIndex = 63;
            this.LblAbonos.Text = "--";
            // 
            // LblMonto
            // 
            this.LblMonto.AutoSize = true;
            this.LblMonto.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMonto.Location = new System.Drawing.Point(267, 87);
            this.LblMonto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblMonto.Name = "LblMonto";
            this.LblMonto.Size = new System.Drawing.Size(39, 39);
            this.LblMonto.TabIndex = 62;
            this.LblMonto.Text = "--";
            // 
            // LblFecha
            // 
            this.LblFecha.AutoSize = true;
            this.LblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFecha.Location = new System.Drawing.Point(267, 43);
            this.LblFecha.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblFecha.Name = "LblFecha";
            this.LblFecha.Size = new System.Drawing.Size(39, 39);
            this.LblFecha.TabIndex = 61;
            this.LblFecha.Text = "--";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(4, 140);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(95, 29);
            this.label9.TabIndex = 60;
            this.label9.Text = "Abonos";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(4, 96);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(190, 29);
            this.label8.TabIndex = 59;
            this.label8.Text = "Monto aprobado";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(4, 48);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(241, 29);
            this.label7.TabIndex = 58;
            this.label7.Text = "Fecha de aprobación";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(171, 5);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(290, 39);
            this.label6.TabIndex = 58;
            this.label6.Text = "Detalle del credito";
            // 
            // BtnRealizar
            // 
            this.BtnRealizar.Location = new System.Drawing.Point(40, 522);
            this.BtnRealizar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnRealizar.Name = "BtnRealizar";
            this.BtnRealizar.Size = new System.Drawing.Size(460, 30);
            this.BtnRealizar.TabIndex = 58;
            this.BtnRealizar.Text = "&Realizar abono";
            this.BtnRealizar.UseVisualStyleBackColor = true;
            // 
            // FrmAbonos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1181, 747);
            this.Controls.Add(this.BtnRealizar);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.TxtValor);
            this.Controls.Add(this.dtgCreditos);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.TxtNombreAbono);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.TxtIdCliente);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmAbonos";
            this.Text = "FrmAbonos";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgCreditos)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Label LblUsuario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtIdCliente;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtNombreAbono;
        private System.Windows.Forms.DataGridView dtgCreditos;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtValor;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label LblNcreditos;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label LblAprovadoPor;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label LblPlazo;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label LblDeudaFecha;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label LblAbonos;
        private System.Windows.Forms.Label LblMonto;
        private System.Windows.Forms.Label LblFecha;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button BtnRealizar;
    }
}