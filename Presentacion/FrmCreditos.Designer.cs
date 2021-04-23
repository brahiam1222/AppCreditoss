namespace Presentacion
{
    partial class FrmCreditos
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.LblUsuario = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtIdentificacion = new System.Windows.Forms.TextBox();
            this.TxtNombres = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtMonto = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.tblPlazoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dB_CreditosDataSet4 = new Presentacion.DB_CreditosDataSet4();
            this.tblPlazoTableAdapter = new Presentacion.DB_CreditosDataSet4TableAdapters.TblPlazoTableAdapter();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.CbxInteres = new System.Windows.Forms.ComboBox();
            this.tblInteresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dB_CreditosDataSet5 = new Presentacion.DB_CreditosDataSet5();
            this.tblInteresTableAdapter = new Presentacion.DB_CreditosDataSet5TableAdapters.TblInteresTableAdapter();
            this.TxtCuota = new System.Windows.Forms.TextBox();
            this.panel8 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.TxtTotal = new System.Windows.Forms.TextBox();
            this.panel9 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.BtnGuardarCredito = new System.Windows.Forms.Button();
            this.BtnCancelarCredito = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.CbxPlazo = new System.Windows.Forms.ComboBox();
            this.TxtDiadepago = new System.Windows.Forms.TextBox();
            this.LblMensajes = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblPlazoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_CreditosDataSet4)).BeginInit();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblInteresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_CreditosDataSet5)).BeginInit();
            this.panel8.SuspendLayout();
            this.panel9.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkCyan;
            this.panel1.Controls.Add(this.LblUsuario);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1016, 83);
            this.panel1.TabIndex = 1;
            // 
            // LblUsuario
            // 
            this.LblUsuario.AutoSize = true;
            this.LblUsuario.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblUsuario.Location = new System.Drawing.Point(625, 64);
            this.LblUsuario.Name = "LblUsuario";
            this.LblUsuario.Size = new System.Drawing.Size(72, 19);
            this.LblUsuario.TabIndex = 54;
            this.LblUsuario.Text = "Usuario:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 35);
            this.label1.TabIndex = 1;
            this.label1.Text = "Modulo Credito";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkCyan;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(12, 129);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(345, 32);
            this.panel2.TabIndex = 30;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Identificacion";
            // 
            // TxtIdentificacion
            // 
            this.TxtIdentificacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtIdentificacion.Location = new System.Drawing.Point(12, 161);
            this.TxtIdentificacion.MaxLength = 10;
            this.TxtIdentificacion.Name = "TxtIdentificacion";
            this.TxtIdentificacion.Size = new System.Drawing.Size(345, 31);
            this.TxtIdentificacion.TabIndex = 29;
            this.TxtIdentificacion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtIdentificacion_KeyPress);
            this.TxtIdentificacion.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TxtIdentificacion_KeyUp);
            // 
            // TxtNombres
            // 
            this.TxtNombres.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNombres.Location = new System.Drawing.Point(373, 161);
            this.TxtNombres.MaxLength = 200;
            this.TxtNombres.Name = "TxtNombres";
            this.TxtNombres.ReadOnly = true;
            this.TxtNombres.Size = new System.Drawing.Size(603, 31);
            this.TxtNombres.TabIndex = 32;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DarkCyan;
            this.panel3.Controls.Add(this.label4);
            this.panel3.Location = new System.Drawing.Point(373, 129);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(603, 32);
            this.panel3.TabIndex = 31;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 4);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 25);
            this.label4.TabIndex = 2;
            this.label4.Text = "Nombres";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.DarkCyan;
            this.panel4.Controls.Add(this.label5);
            this.panel4.Location = new System.Drawing.Point(12, 209);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(345, 32);
            this.panel4.TabIndex = 33;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 4);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 25);
            this.label5.TabIndex = 2;
            this.label5.Text = "Día de pago";
            // 
            // TxtMonto
            // 
            this.TxtMonto.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtMonto.Location = new System.Drawing.Point(373, 241);
            this.TxtMonto.MaxLength = 200;
            this.TxtMonto.Name = "TxtMonto";
            this.TxtMonto.Size = new System.Drawing.Size(324, 31);
            this.TxtMonto.TabIndex = 36;
            this.TxtMonto.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtMonto);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.DarkCyan;
            this.panel5.Controls.Add(this.label6);
            this.panel5.Location = new System.Drawing.Point(373, 209);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(324, 32);
            this.panel5.TabIndex = 35;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 4);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(162, 25);
            this.label6.TabIndex = 2;
            this.label6.Text = "Monto prestado";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.DarkCyan;
            this.panel6.Controls.Add(this.label7);
            this.panel6.Location = new System.Drawing.Point(703, 209);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(273, 32);
            this.panel6.TabIndex = 36;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(3, 4);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(150, 25);
            this.label7.TabIndex = 2;
            this.label7.Text = "Plazo de pago";
            // 
            // tblPlazoBindingSource
            // 
            this.tblPlazoBindingSource.DataMember = "TblPlazo";
            this.tblPlazoBindingSource.DataSource = this.dB_CreditosDataSet4;
            // 
            // dB_CreditosDataSet4
            // 
            this.dB_CreditosDataSet4.DataSetName = "DB_CreditosDataSet4";
            this.dB_CreditosDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblPlazoTableAdapter
            // 
            this.tblPlazoTableAdapter.ClearBeforeFill = true;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.DarkCyan;
            this.panel7.Controls.Add(this.label8);
            this.panel7.Location = new System.Drawing.Point(12, 294);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(345, 32);
            this.panel7.TabIndex = 38;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(3, 4);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 25);
            this.label8.TabIndex = 2;
            this.label8.Text = "Interes";
            // 
            // CbxInteres
            // 
            this.CbxInteres.DataSource = this.tblInteresBindingSource;
            this.CbxInteres.DisplayMember = "Descripcion";
            this.CbxInteres.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbxInteres.FormattingEnabled = true;
            this.CbxInteres.Location = new System.Drawing.Point(12, 326);
            this.CbxInteres.Name = "CbxInteres";
            this.CbxInteres.Size = new System.Drawing.Size(345, 33);
            this.CbxInteres.TabIndex = 39;
            this.CbxInteres.ValueMember = "PKId";
            // 
            // tblInteresBindingSource
            // 
            this.tblInteresBindingSource.DataMember = "TblInteres";
            this.tblInteresBindingSource.DataSource = this.dB_CreditosDataSet5;
            // 
            // dB_CreditosDataSet5
            // 
            this.dB_CreditosDataSet5.DataSetName = "DB_CreditosDataSet5";
            this.dB_CreditosDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblInteresTableAdapter
            // 
            this.tblInteresTableAdapter.ClearBeforeFill = true;
            // 
            // TxtCuota
            // 
            this.TxtCuota.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCuota.Location = new System.Drawing.Point(373, 326);
            this.TxtCuota.MaxLength = 200;
            this.TxtCuota.Name = "TxtCuota";
            this.TxtCuota.ReadOnly = true;
            this.TxtCuota.Size = new System.Drawing.Size(324, 31);
            this.TxtCuota.TabIndex = 41;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.DarkCyan;
            this.panel8.Controls.Add(this.label9);
            this.panel8.Location = new System.Drawing.Point(373, 294);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(324, 32);
            this.panel8.TabIndex = 40;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(3, 4);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 25);
            this.label9.TabIndex = 2;
            this.label9.Text = "Cuota";
            // 
            // TxtTotal
            // 
            this.TxtTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtTotal.Location = new System.Drawing.Point(703, 326);
            this.TxtTotal.MaxLength = 200;
            this.TxtTotal.Name = "TxtTotal";
            this.TxtTotal.ReadOnly = true;
            this.TxtTotal.Size = new System.Drawing.Size(273, 31);
            this.TxtTotal.TabIndex = 43;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.DarkCyan;
            this.panel9.Controls.Add(this.label10);
            this.panel9.Location = new System.Drawing.Point(703, 294);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(273, 32);
            this.panel9.TabIndex = 42;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(3, 4);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(215, 25);
            this.label10.TabIndex = 2;
            this.label10.Text = "Valor total del credito";
            // 
            // BtnGuardarCredito
            // 
            this.BtnGuardarCredito.Location = new System.Drawing.Point(12, 380);
            this.BtnGuardarCredito.Name = "BtnGuardarCredito";
            this.BtnGuardarCredito.Size = new System.Drawing.Size(203, 31);
            this.BtnGuardarCredito.TabIndex = 44;
            this.BtnGuardarCredito.Text = "&Guardar Crédito";
            this.BtnGuardarCredito.UseVisualStyleBackColor = true;
            this.BtnGuardarCredito.Click += new System.EventHandler(this.BtnGuardarCredito_Click);
            // 
            // BtnCancelarCredito
            // 
            this.BtnCancelarCredito.Location = new System.Drawing.Point(221, 380);
            this.BtnCancelarCredito.Name = "BtnCancelarCredito";
            this.BtnCancelarCredito.Size = new System.Drawing.Size(203, 31);
            this.BtnCancelarCredito.TabIndex = 45;
            this.BtnCancelarCredito.Text = "&Cancelar ";
            this.BtnCancelarCredito.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(782, 526);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(203, 31);
            this.button1.TabIndex = 46;
            this.button1.Text = "Regresar a pagina principal";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // CbxPlazo
            // 
            this.CbxPlazo.DataSource = this.tblPlazoBindingSource;
            this.CbxPlazo.DisplayMember = "Descripcion";
            this.CbxPlazo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbxPlazo.FormattingEnabled = true;
            this.CbxPlazo.Location = new System.Drawing.Point(703, 241);
            this.CbxPlazo.Name = "CbxPlazo";
            this.CbxPlazo.Size = new System.Drawing.Size(273, 33);
            this.CbxPlazo.TabIndex = 37;
            this.CbxPlazo.ValueMember = "PKId";
            this.CbxPlazo.SelectedIndexChanged += new System.EventHandler(this.CBXPAXO);
            // 
            // TxtDiadepago
            // 
            this.TxtDiadepago.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDiadepago.Location = new System.Drawing.Point(12, 242);
            this.TxtDiadepago.MaxLength = 2;
            this.TxtDiadepago.Name = "TxtDiadepago";
            this.TxtDiadepago.Size = new System.Drawing.Size(345, 31);
            this.TxtDiadepago.TabIndex = 47;
            this.TxtDiadepago.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // LblMensajes
            // 
            this.LblMensajes.AutoSize = true;
            this.LblMensajes.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMensajes.Location = new System.Drawing.Point(50, 500);
            this.LblMensajes.Name = "LblMensajes";
            this.LblMensajes.Size = new System.Drawing.Size(0, 39);
            this.LblMensajes.TabIndex = 48;
            // 
            // FrmCreditos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1013, 580);
            this.Controls.Add(this.LblMensajes);
            this.Controls.Add(this.TxtDiadepago);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BtnCancelarCredito);
            this.Controls.Add(this.BtnGuardarCredito);
            this.Controls.Add(this.TxtTotal);
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.TxtCuota);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.CbxInteres);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.CbxPlazo);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.TxtMonto);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.TxtNombres);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.TxtIdentificacion);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmCreditos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmCreditos";
            this.Load += new System.EventHandler(this.FrmCreditos_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblPlazoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_CreditosDataSet4)).EndInit();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblInteresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_CreditosDataSet5)).EndInit();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtIdentificacion;
        private System.Windows.Forms.TextBox TxtNombres;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtMonto;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label7;
        private DB_CreditosDataSet4 dB_CreditosDataSet4;
        private System.Windows.Forms.BindingSource tblPlazoBindingSource;
        private DB_CreditosDataSet4TableAdapters.TblPlazoTableAdapter tblPlazoTableAdapter;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox CbxInteres;
        private DB_CreditosDataSet5 dB_CreditosDataSet5;
        private System.Windows.Forms.BindingSource tblInteresBindingSource;
        private DB_CreditosDataSet5TableAdapters.TblInteresTableAdapter tblInteresTableAdapter;
        private System.Windows.Forms.TextBox TxtCuota;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TxtTotal;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button BtnGuardarCredito;
        private System.Windows.Forms.Button BtnCancelarCredito;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.Label LblUsuario;
        private System.Windows.Forms.ComboBox CbxPlazo;
        private System.Windows.Forms.TextBox TxtDiadepago;
        private System.Windows.Forms.Label LblMensajes;
    }
}