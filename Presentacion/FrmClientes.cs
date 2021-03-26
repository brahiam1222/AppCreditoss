﻿using System;
using System.Windows.Forms;
using Negocio;

namespace Presentacion
{
    public partial class FrmClientes : Form
    {
        String var;
        int contador = 0;
        public FrmClientes()
        {
            InitializeComponent();
        }

        private void Btn1_Click(object sender, EventArgs e)
        {
            if (contador == 10)
            {
                return;
            }
            else
            {
                var = var + "1";
                TxtIdentificacion.Text = var;
                contador++;
            }

        }

        private void button11_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (contador == 10)
            {
                return;
            }
            else
            {
                var = var + "0";
                TxtIdentificacion.Text = var;
                contador++;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (contador == 10)
            {
                return;
            }
            else
            {
                var = var + "9";
                TxtIdentificacion.Text = var;
                contador++;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (contador == 10)
            {
                return;
            }
            else
            {
                var = var + "8";
                TxtIdentificacion.Text = var;
                contador++;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (contador == 10)
            {
                return;
            }
            else
            {
                var = var + "7";
                TxtIdentificacion.Text = var;
                contador++;
            }
        }

        private void Btn6_Click(object sender, EventArgs e)
        {
            if (contador == 10)
            {
                return;
            }
            else
            {
                var = var + "6";
                TxtIdentificacion.Text = var;
                contador++;
            }
        }

        private void Btn5_Click(object sender, EventArgs e)
        {
            if (contador ==  10)
            {
                return;
            }
            else
            {
                var = var + "5";
                TxtIdentificacion.Text = var;
                contador++;
            }
        }

        private void Btn4_Click(object sender, EventArgs e)
        {
            if (contador == 10)
            {
                return;
            }
            else
            {
                var = var + "4";
                TxtIdentificacion.Text = var;
                contador++;
            }
        }

        private void Btn3_Click(object sender, EventArgs e)
        {
            if (contador == 10)
            {
                return;
            }
            else
            {
                var = var + "3";
                TxtIdentificacion.Text = var;
                contador++;
            }
        }
        
        private void button12_Click(object sender, EventArgs e)
        {

        }

        private void Btn2_Click(object sender, EventArgs e)
        {
            if (contador == 10)
            {
                return;
            }
            else
            {
                var = var + "2";
                TxtIdentificacion.Text = var;
                contador++;
            }
        }

        private void FrmClientes_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dB_CreditosDataSet3.TblSexo' Puede moverla o quitarla según sea necesario.
            this.tblSexoTableAdapter.Fill(this.dB_CreditosDataSet3.TblSexo);
            // TODO: esta línea de código carga datos en la tabla 'dB_CreditosDataSet2.TblEstadoCivil' Puede moverla o quitarla según sea necesario.
            this.tblEstadoCivilTableAdapter1.Fill(this.dB_CreditosDataSet2.TblEstadoCivil);
            // TODO: esta línea de código carga datos en la tabla 'dB_CreditosDataSet1.TblEstadoCivil' Puede moverla o quitarla según sea necesario.
            this.tblEstadoCivilTableAdapter.Fill(this.dB_CreditosDataSet1.TblEstadoCivil);
            // TODO: esta línea de código carga datos en la tabla 'dB_CreditosDataSet.TblCredenciales' Puede moverla o quitarla según sea necesario.
            this.tblCredencialesTableAdapter.Fill(this.dB_CreditosDataSet.TblCredenciales);

        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void TxtNombres_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
                return;
            }
        }

        private void TxtCorreo_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtCorreo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
                return;
            }
        }

        private void TxtContactoEmpresa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || (e.KeyChar == (char)Keys.Space))
            {
                e.Handled = true;
                return;
            }
        }

        private void TxtIngresos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || (e.KeyChar == (char)Keys.Space))
            {
                e.Handled = true;
                return;
            }
        }

        private void TxtEdad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || (e.KeyChar == (char)Keys.Space))
            {
                e.Handled = true;
                return;
            }
        }

        private void TxtContacto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || (e.KeyChar == (char)Keys.Space))
            {
                e.Handled = true;
                return;
            }
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        protected void Fnt_DevolverCliente()
        {
            FrmLogin ObjLogin = new FrmLogin();
            ObjLogin.Show();
            this.Close();
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Fnt_DevolverCliente();
        }

        private void TxtEdad_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtNombres_TextChanged(object sender, EventArgs e)
        {

        }
        protected void Fnt_ConsultarCliente()
        {
            ClsCliente_Negocio ObjConsultar = new ClsCliente_Negocio();
            ObjConsultar.Fnt_ConsultarCliente(TxtIdentificacion.Text);
        }
        
        protected void Fnt_AgregarCliente()
        {
            ClsCliente_Negocio ObjCliente = new ClsCliente_Negocio();
            ObjCliente.Fnt_AgregarCliente(TxtIdentificacion.Text, TxtNombres.Text, TxtContacto.Text, TxtCorreo.Text, TxtEdad.Text, TxtIngresos.Text, TxtEmpresa.Text, 
            TxtContactoEmpresa.Text, Convert.ToString(CbxSexo.SelectedValue), Convert.ToString(CbxEstadoCivil.SelectedValue));
            LblMensajeC.Text = ObjCliente.msn;               
        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Fnt_AgregarCliente();
        }
    }
}
