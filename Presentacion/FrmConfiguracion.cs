using System;
using Negocio;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class FrmConfiguracion : Form
    {
        public FrmConfiguracion()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
        public void Fnt_CambiarClave()
        {
            ClsCliente_Negocio ObjCambiarClave = new ClsCliente_Negocio();
            ObjCambiarClave.Fnt_CambiarClave(LblUsuario.Text, TxtClaveAnterior.Text, TxtNuevaClave.Text,TxtConfirmarClave.Text);
            //LblMensaje.Text = ObjCambiarClave.msn;
            MessageBox.Show(ObjCambiarClave.msn);
        }
        private void BtnCambiarClave_Click(object sender, EventArgs e)
        {
            Fnt_CambiarClave();
        }
    }
}
