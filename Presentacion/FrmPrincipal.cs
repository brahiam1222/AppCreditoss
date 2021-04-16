using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }
        protected void Fnt_ModuloClientes()
        {
            FrmClientes ObjClientes = new FrmClientes();
            ObjClientes.LblUsuario.Text = LblUsuario.Text;
            ObjClientes.ShowDialog();
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Fnt_ModuloClientes();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            FrmLogin ObjLogin = new FrmLogin();
            ObjLogin.Show();
            this.Close();
        }
        protected void Fnt_ModuloCreditos()
        {
            FrmCreditos ObjCreditos = new FrmCreditos();
            ObjCreditos.LblUsuario.Text = LblUsuario.Text;
            ObjCreditos.ShowDialog();
        }
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Fnt_ModuloCreditos();
        }
    }
}
