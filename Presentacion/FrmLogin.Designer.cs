﻿namespace Presentacion
{
    partial class FrmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            this.CbxUsuario = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.Btn1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ChMostrar = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Btn2 = new System.Windows.Forms.Button();
            this.Btn3 = new System.Windows.Forms.Button();
            this.Btn4 = new System.Windows.Forms.Button();
            this.Btn5 = new System.Windows.Forms.Button();
            this.Btn6 = new System.Windows.Forms.Button();
            this.Btn7 = new System.Windows.Forms.Button();
            this.Btn8 = new System.Windows.Forms.Button();
            this.Btn9 = new System.Windows.Forms.Button();
            this.Btn0 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.TxtContra = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dB_CreditosDataSet = new Presentacion.DB_CreditosDataSet();
            this.tblCredencialesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblCredencialesTableAdapter = new Presentacion.DB_CreditosDataSetTableAdapters.TblCredencialesTableAdapter();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_CreditosDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblCredencialesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // CbxUsuario
            // 
            this.CbxUsuario.DataSource = this.tblCredencialesBindingSource;
            this.CbxUsuario.DisplayMember = "PKCorreo";
            this.CbxUsuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbxUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CbxUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbxUsuario.FormattingEnabled = true;
            this.CbxUsuario.Location = new System.Drawing.Point(136, 161);
            this.CbxUsuario.Name = "CbxUsuario";
            this.CbxUsuario.Size = new System.Drawing.Size(345, 33);
            this.CbxUsuario.TabIndex = 0;
            this.CbxUsuario.ValueMember = "PKCorreo";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkCyan;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(136, 133);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(345, 32);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(122, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Usuario";
            // 
            // Btn1
            // 
            this.Btn1.Location = new System.Drawing.Point(188, 313);
            this.Btn1.Name = "Btn1";
            this.Btn1.Size = new System.Drawing.Size(75, 23);
            this.Btn1.TabIndex = 2;
            this.Btn1.Text = "1";
            this.Btn1.UseVisualStyleBackColor = true;
            this.Btn1.Click += new System.EventHandler(this.Btn1_Click);
            this.Btn1.MouseLeave += new System.EventHandler(this.Btn1_MouseLeave);
            this.Btn1.MouseHover += new System.EventHandler(this.Btn1_MouseHover);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkCyan;
            this.panel2.Controls.Add(this.ChMostrar);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(136, 212);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(345, 32);
            this.panel2.TabIndex = 3;
            // 
            // ChMostrar
            // 
            this.ChMostrar.AutoSize = true;
            this.ChMostrar.Location = new System.Drawing.Point(281, 8);
            this.ChMostrar.Name = "ChMostrar";
            this.ChMostrar.Size = new System.Drawing.Size(61, 17);
            this.ChMostrar.TabIndex = 3;
            this.ChMostrar.Text = "Mostrar";
            this.ChMostrar.UseVisualStyleBackColor = true;
            this.ChMostrar.CheckedChanged += new System.EventHandler(this.ChMostrar_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(122, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Contraseña";
            // 
            // Btn2
            // 
            this.Btn2.Location = new System.Drawing.Point(269, 313);
            this.Btn2.Name = "Btn2";
            this.Btn2.Size = new System.Drawing.Size(75, 23);
            this.Btn2.TabIndex = 4;
            this.Btn2.Text = "2";
            this.Btn2.UseVisualStyleBackColor = true;
            this.Btn2.Click += new System.EventHandler(this.Btn2_Click);
            this.Btn2.MouseLeave += new System.EventHandler(this.Btn2_MouseLeave);
            this.Btn2.MouseHover += new System.EventHandler(this.Btn2_MouseHover);
            // 
            // Btn3
            // 
            this.Btn3.Location = new System.Drawing.Point(350, 313);
            this.Btn3.Name = "Btn3";
            this.Btn3.Size = new System.Drawing.Size(75, 23);
            this.Btn3.TabIndex = 5;
            this.Btn3.Text = "3";
            this.Btn3.UseVisualStyleBackColor = true;
            this.Btn3.Click += new System.EventHandler(this.Btn3_Click);
            this.Btn3.MouseLeave += new System.EventHandler(this.Btn3_MouseLeave);
            this.Btn3.MouseHover += new System.EventHandler(this.Btn3_MouseHover);
            // 
            // Btn4
            // 
            this.Btn4.Location = new System.Drawing.Point(188, 342);
            this.Btn4.Name = "Btn4";
            this.Btn4.Size = new System.Drawing.Size(75, 23);
            this.Btn4.TabIndex = 6;
            this.Btn4.Text = "4";
            this.Btn4.UseVisualStyleBackColor = true;
            this.Btn4.Click += new System.EventHandler(this.Btn4_Click);
            this.Btn4.MouseLeave += new System.EventHandler(this.Btn4_MouseLeave);
            this.Btn4.MouseHover += new System.EventHandler(this.Btn4_MouseHover);
            // 
            // Btn5
            // 
            this.Btn5.Location = new System.Drawing.Point(269, 342);
            this.Btn5.Name = "Btn5";
            this.Btn5.Size = new System.Drawing.Size(75, 23);
            this.Btn5.TabIndex = 7;
            this.Btn5.Text = "5";
            this.Btn5.UseVisualStyleBackColor = true;
            this.Btn5.Click += new System.EventHandler(this.Btn5_Click);
            this.Btn5.MouseLeave += new System.EventHandler(this.Btn5_MouseLeave);
            this.Btn5.MouseHover += new System.EventHandler(this.Btn5_MouseHover);
            // 
            // Btn6
            // 
            this.Btn6.Location = new System.Drawing.Point(350, 342);
            this.Btn6.Name = "Btn6";
            this.Btn6.Size = new System.Drawing.Size(75, 23);
            this.Btn6.TabIndex = 8;
            this.Btn6.Text = "6";
            this.Btn6.UseVisualStyleBackColor = true;
            this.Btn6.Click += new System.EventHandler(this.Btn6_Click);
            this.Btn6.MouseLeave += new System.EventHandler(this.Btn6_MouseLeave);
            this.Btn6.MouseHover += new System.EventHandler(this.Btn6_MouseHover);
            // 
            // Btn7
            // 
            this.Btn7.Location = new System.Drawing.Point(188, 372);
            this.Btn7.Name = "Btn7";
            this.Btn7.Size = new System.Drawing.Size(75, 23);
            this.Btn7.TabIndex = 9;
            this.Btn7.Text = "7";
            this.Btn7.UseVisualStyleBackColor = true;
            this.Btn7.Click += new System.EventHandler(this.button7_Click);
            this.Btn7.MouseLeave += new System.EventHandler(this.Btn7_MouseLeave);
            this.Btn7.MouseHover += new System.EventHandler(this.Btn7_MouseHover);
            // 
            // Btn8
            // 
            this.Btn8.Location = new System.Drawing.Point(269, 371);
            this.Btn8.Name = "Btn8";
            this.Btn8.Size = new System.Drawing.Size(75, 23);
            this.Btn8.TabIndex = 10;
            this.Btn8.Text = "8";
            this.Btn8.UseVisualStyleBackColor = true;
            this.Btn8.Click += new System.EventHandler(this.button8_Click);
            this.Btn8.MouseLeave += new System.EventHandler(this.Btn8_MouseLeave);
            this.Btn8.MouseHover += new System.EventHandler(this.Btn8_MouseHover);
            // 
            // Btn9
            // 
            this.Btn9.Location = new System.Drawing.Point(350, 371);
            this.Btn9.Name = "Btn9";
            this.Btn9.Size = new System.Drawing.Size(75, 23);
            this.Btn9.TabIndex = 11;
            this.Btn9.Text = "9";
            this.Btn9.UseVisualStyleBackColor = true;
            this.Btn9.Click += new System.EventHandler(this.button9_Click);
            this.Btn9.MouseLeave += new System.EventHandler(this.Btn9_MouseLeave);
            this.Btn9.MouseHover += new System.EventHandler(this.Btn9_MouseHover);
            // 
            // Btn0
            // 
            this.Btn0.Location = new System.Drawing.Point(269, 400);
            this.Btn0.Name = "Btn0";
            this.Btn0.Size = new System.Drawing.Size(75, 23);
            this.Btn0.TabIndex = 12;
            this.Btn0.Text = "0";
            this.Btn0.UseVisualStyleBackColor = true;
            this.Btn0.Click += new System.EventHandler(this.button10_Click);
            this.Btn0.MouseLeave += new System.EventHandler(this.Btn0_MouseLeave);
            this.Btn0.MouseHover += new System.EventHandler(this.Btn0_MouseHover);
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.Color.Firebrick;
            this.button11.Location = new System.Drawing.Point(188, 400);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(75, 23);
            this.button11.TabIndex = 13;
            this.button11.Text = "Cancelar";
            this.button11.UseVisualStyleBackColor = false;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // button12
            // 
            this.button12.BackColor = System.Drawing.Color.OliveDrab;
            this.button12.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button12.Location = new System.Drawing.Point(350, 400);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(75, 23);
            this.button12.TabIndex = 14;
            this.button12.Text = "Ingresar";
            this.button12.UseVisualStyleBackColor = false;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // TxtContra
            // 
            this.TxtContra.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtContra.Location = new System.Drawing.Point(136, 243);
            this.TxtContra.MaxLength = 4;
            this.TxtContra.Name = "TxtContra";
            this.TxtContra.PasswordChar = '•';
            this.TxtContra.ReadOnly = true;
            this.TxtContra.Size = new System.Drawing.Size(345, 31);
            this.TxtContra.TabIndex = 15;
            this.TxtContra.TextChanged += new System.EventHandler(this.TxtContra_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(278, 63);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(57, 54);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // dB_CreditosDataSet
            // 
            this.dB_CreditosDataSet.DataSetName = "DB_CreditosDataSet";
            this.dB_CreditosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblCredencialesBindingSource
            // 
            this.tblCredencialesBindingSource.DataMember = "TblCredenciales";
            this.tblCredencialesBindingSource.DataSource = this.dB_CreditosDataSet;
            // 
            // tblCredencialesTableAdapter
            // 
            this.tblCredencialesTableAdapter.ClearBeforeFill = true;
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(593, 495);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.TxtContra);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.Btn0);
            this.Controls.Add(this.Btn9);
            this.Controls.Add(this.Btn8);
            this.Controls.Add(this.Btn7);
            this.Controls.Add(this.Btn6);
            this.Controls.Add(this.Btn5);
            this.Controls.Add(this.Btn4);
            this.Controls.Add(this.Btn3);
            this.Controls.Add(this.Btn2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.Btn1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.CbxUsuario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modulo - Credenciales";
            this.Load += new System.EventHandler(this.FrmLogin_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_CreditosDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblCredencialesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CbxUsuario;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Btn1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Btn2;
        private System.Windows.Forms.Button Btn3;
        private System.Windows.Forms.Button Btn4;
        private System.Windows.Forms.Button Btn5;
        private System.Windows.Forms.Button Btn6;
        private System.Windows.Forms.Button Btn7;
        private System.Windows.Forms.Button Btn8;
        private System.Windows.Forms.Button Btn9;
        private System.Windows.Forms.Button Btn0;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.TextBox TxtContra;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckBox ChMostrar;
        private DB_CreditosDataSet dB_CreditosDataSet;
        private System.Windows.Forms.BindingSource tblCredencialesBindingSource;
        private DB_CreditosDataSetTableAdapters.TblCredencialesTableAdapter tblCredencialesTableAdapter;
    }
}