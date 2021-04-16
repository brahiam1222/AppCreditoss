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
    }
}
