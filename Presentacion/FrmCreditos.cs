using System;
using Negocio;
using System.Windows.Forms;
namespace Presentacion
{
    public partial class FrmCreditos : Form
    {
        public FrmCreditos()
        {
            InitializeComponent();
            CbxInteres.Enabled = false;
        }

        private void FrmCreditos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dB_CreditosDataSet5.TblInteres' Puede moverla o quitarla según sea necesario.
            this.tblInteresTableAdapter.Fill(this.dB_CreditosDataSet5.TblInteres);
            // TODO: esta línea de código carga datos en la tabla 'dB_CreditosDataSet4.TblPlazo' Puede moverla o quitarla según sea necesario.
            this.tblPlazoTableAdapter.Fill(this.dB_CreditosDataSet4.TblPlazo);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
        protected void Fnt_CalcularCuota()
        {
            ClsCliente_Negocio ObjCalcularCuota = new ClsCliente_Negocio();
            ObjCalcularCuota.Fnt_CalcularCuota(TxtMonto.Text, Convert.ToInt32(CbxPlazo.Text));
            TxtCuota.Text = Convert.ToString(ObjCalcularCuota.cuota2);
            TxtTotal.Text = Convert.ToString(ObjCalcularCuota.total);
            CbxInteres.SelectedIndex = Convert.ToInt32(ObjCalcularCuota.pos);
        }

        private void txtMonto(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Enter)
                {
                Fnt_CalcularCuota();
                }
        }

        private void CBXPAXO(object sender, EventArgs e)
        {
            Fnt_CalcularCuota();

        }
        protected void Fnt_ConsultarCliente(String id)
        {
            ClsCliente_Negocio ObjConsultar = new ClsCliente_Negocio();
            ObjConsultar.Fnt_ConsultarCliente(id);
            TxtNombres.Text = ObjConsultar.aux[0];
        }
        private void TxtIdentificacion_KeyUp(object sender, KeyEventArgs e)
        {
        if(e.KeyCode==Keys.Enter)
            {
                Fnt_ConsultarCliente(TxtIdentificacion.Text);
            }
        }

        private void TxtIdentificacion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
                        if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = true;
            }
        }
        protected void Fnt_GuardarCredito(String id,
            String diaPago,
            String valorPrestamo,
            int plazo,
            String cuota,
            int interes,
            String ValorTotal,
            String user)
            {
            ClsCredito_Negocio ObjGuardar = new ClsCredito_Negocio();
            ObjGuardar.Fnt_GuardarCredito(id, diaPago, valorPrestamo, plazo, cuota, interes, ValorTotal, user);
            LblMensajes.Text = ObjGuardar.msn;
            }
        private void BtnGuardarCredito_Click(object sender, EventArgs e)
        {
            Fnt_GuardarCredito(TxtIdentificacion.Text, TxtDiadepago.Text, TxtMonto.Text,
                               CbxPlazo.SelectedIndex, TxtCuota.Text, CbxInteres.SelectedIndex,
                               TxtTotal.Text, LblUsuario.Text);
        }
    }
}
