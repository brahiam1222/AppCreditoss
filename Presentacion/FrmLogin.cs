using System;
using System.Windows.Forms;
using Negocio;
namespace Presentacion
{
    public partial class FrmLogin : Form
    {
        String var;
        int contador = 0;
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void Btn1_Click(object sender, EventArgs e)
        {
            if (contador == 4)
            {
                return;
            }
            else
            {
                var = var + "1";
                TxtContra.Text = var;
                contador++;
            }

        }

        private void Btn2_Click(object sender, EventArgs e)
        {
            if (contador == 4)
            {
                return;
            }
            else
            {
                var = var + "2";
                TxtContra.Text = var;
                contador++;
            }
        }

        private void Btn3_Click(object sender, EventArgs e)
        {
            if (contador == 4)
            {
                return;
            }
            else
            {
                var = var + "3";
                TxtContra.Text = var;
                contador++;
            }
        }

        private void Btn4_Click(object sender, EventArgs e)
        {
            if (contador == 4)
            {
                return;
            }
            else
            {
                var = var + "4";
                TxtContra.Text = var;
                contador++;
            }
        }

        private void Btn5_Click(object sender, EventArgs e)
        {
            if (contador == 4)
            {
                return;
            }
            else
            {
                var = var + "5";
                TxtContra.Text = var;
                contador++;
            }
        }

        private void Btn6_Click(object sender, EventArgs e)
        {
            if (contador == 4)
            {
                return;
            }
            else
            {
                var = var + "6";
                TxtContra.Text = var;
                contador++;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (contador == 4)
            {
                return;
            }
            else
            {
                var = var + "7";
                TxtContra.Text = var;
                contador++;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (contador == 4)
            {
                return;
            }
            else
            {
                var = var + "8";
                TxtContra.Text = var;
                contador++;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (contador == 4)
            {
                return;
            }
            else
            {
                var = var + "9";
                TxtContra.Text = var;
                contador++;
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (contador == 4)
            {
                return;
            }
            else
            {
                var = var + "0";
                TxtContra.Text = var;
                contador++;
            }
        }

        private void ChMostrar_CheckedChanged(object sender, EventArgs e)
        {
            if (ChMostrar.Checked == true)
            {
                TxtContra.PasswordChar = '\0';
            }
            else
            {
                TxtContra.PasswordChar = '•';
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            TxtContra.Clear();
            contador = 0;
            var = "";
        }

        private void Btn1_MouseHover(object sender, EventArgs e)
        {
            Btn1.Text = "*";
            Btn2.Text = "*";
            Btn3.Text = "*";
            Btn4.Text = "*";
            Btn5.Text = "*";
            Btn6.Text = "*";
            Btn7.Text = "*";
            Btn8.Text = "*";
            Btn9.Text = "*";
            Btn0.Text = "*";
        }

        private void Btn1_MouseLeave(object sender, EventArgs e)
        {
            Btn1.Text = "1";
            Btn2.Text = "2";
            Btn3.Text = "3";
            Btn4.Text = "4";
            Btn5.Text = "5";
            Btn6.Text = "6";
            Btn7.Text = "7";
            Btn8.Text = "8";
            Btn9.Text = "9";
            Btn0.Text = "0";
        }

        private void Btn2_MouseHover(object sender, EventArgs e)
        {
            Btn1.Text = "*";
            Btn2.Text = "*";
            Btn3.Text = "*";
            Btn4.Text = "*";
            Btn5.Text = "*";
            Btn6.Text = "*";
            Btn7.Text = "*";
            Btn8.Text = "*";
            Btn9.Text = "*";
            Btn0.Text = "*";
        }

        private void Btn2_MouseLeave(object sender, EventArgs e)
        {
            Btn1.Text = "1";
            Btn2.Text = "2";
            Btn3.Text = "3";
            Btn4.Text = "4";
            Btn5.Text = "5";
            Btn6.Text = "6";
            Btn7.Text = "7";
            Btn8.Text = "8";
            Btn9.Text = "9";
            Btn0.Text = "0";
        }

        private void Btn3_MouseHover(object sender, EventArgs e)
        {
            Btn1.Text = "*";
            Btn2.Text = "*";
            Btn3.Text = "*";
            Btn4.Text = "*";
            Btn5.Text = "*";
            Btn6.Text = "*";
            Btn7.Text = "*";
            Btn8.Text = "*";
            Btn9.Text = "*";
            Btn0.Text = "*";
        }

        private void Btn3_MouseLeave(object sender, EventArgs e)
        {
            Btn1.Text = "1";
            Btn2.Text = "2";
            Btn3.Text = "3";
            Btn4.Text = "4";
            Btn5.Text = "5";
            Btn6.Text = "6";
            Btn7.Text = "7";
            Btn8.Text = "8";
            Btn9.Text = "9";
            Btn0.Text = "0";
        }

        private void Btn4_MouseHover(object sender, EventArgs e)
        {
            Btn1.Text = "*";
            Btn2.Text = "*";
            Btn3.Text = "*";
            Btn4.Text = "*";
            Btn5.Text = "*";
            Btn6.Text = "*";
            Btn7.Text = "*";
            Btn8.Text = "*";
            Btn9.Text = "*";
            Btn0.Text = "*";
        }

        private void Btn4_MouseLeave(object sender, EventArgs e)
        {
            Btn1.Text = "1";
            Btn2.Text = "2";
            Btn3.Text = "3";
            Btn4.Text = "4";
            Btn5.Text = "5";
            Btn6.Text = "6";
            Btn7.Text = "7";
            Btn8.Text = "8";
            Btn9.Text = "9";
            Btn0.Text = "0";
        }

        private void Btn5_MouseHover(object sender, EventArgs e)
        {
            Btn1.Text = "*";
            Btn2.Text = "*";
            Btn3.Text = "*";
            Btn4.Text = "*";
            Btn5.Text = "*";
            Btn6.Text = "*";
            Btn7.Text = "*";
            Btn8.Text = "*";
            Btn9.Text = "*";
            Btn0.Text = "*";
        }

        private void Btn5_MouseLeave(object sender, EventArgs e)
        {
            Btn1.Text = "1";
            Btn2.Text = "2";
            Btn3.Text = "3";
            Btn4.Text = "4";
            Btn5.Text = "5";
            Btn6.Text = "6";
            Btn7.Text = "7";
            Btn8.Text = "8";
            Btn9.Text = "9";
            Btn0.Text = "0";
        }

        private void Btn6_MouseHover(object sender, EventArgs e)
        {
            Btn1.Text = "*";
            Btn2.Text = "*";
            Btn3.Text = "*";
            Btn4.Text = "*";
            Btn5.Text = "*";
            Btn6.Text = "*";
            Btn7.Text = "*";
            Btn8.Text = "*";
            Btn9.Text = "*";
            Btn0.Text = "*";
        }

        private void Btn6_MouseLeave(object sender, EventArgs e)
        {
            Btn1.Text = "1";
            Btn2.Text = "2";
            Btn3.Text = "3";
            Btn4.Text = "4";
            Btn5.Text = "5";
            Btn6.Text = "6";
            Btn7.Text = "7";
            Btn8.Text = "8";
            Btn9.Text = "9";
            Btn0.Text = "0";
        }

        private void Btn7_MouseHover(object sender, EventArgs e)
        {
            Btn1.Text = "*";
            Btn2.Text = "*";
            Btn3.Text = "*";
            Btn4.Text = "*";
            Btn5.Text = "*";
            Btn6.Text = "*";
            Btn7.Text = "*";
            Btn8.Text = "*";
            Btn9.Text = "*";
            Btn0.Text = "*";
        }

        private void Btn7_MouseLeave(object sender, EventArgs e)
        {
            Btn1.Text = "1";
            Btn2.Text = "2";
            Btn3.Text = "3";
            Btn4.Text = "4";
            Btn5.Text = "5";
            Btn6.Text = "6";
            Btn7.Text = "7";
            Btn8.Text = "8";
            Btn9.Text = "9";
            Btn0.Text = "0";
        }

        private void Btn8_MouseHover(object sender, EventArgs e)
        {
            Btn1.Text = "*";
            Btn2.Text = "*";
            Btn3.Text = "*";
            Btn4.Text = "*";
            Btn5.Text = "*";
            Btn6.Text = "*";
            Btn7.Text = "*";
            Btn8.Text = "*";
            Btn9.Text = "*";
            Btn0.Text = "*";
        }

        private void Btn8_MouseLeave(object sender, EventArgs e)
        {
            Btn1.Text = "1";
            Btn2.Text = "2";
            Btn3.Text = "3";
            Btn4.Text = "4";
            Btn5.Text = "5";
            Btn6.Text = "6";
            Btn7.Text = "7";
            Btn8.Text = "8";
            Btn9.Text = "9";
            Btn0.Text = "0";
        }

        private void Btn9_MouseHover(object sender, EventArgs e)
        {
            Btn1.Text = "*";
            Btn2.Text = "*";
            Btn3.Text = "*";
            Btn4.Text = "*";
            Btn5.Text = "*";
            Btn6.Text = "*";
            Btn7.Text = "*";
            Btn8.Text = "*";
            Btn9.Text = "*";
            Btn0.Text = "*";
        }

        private void Btn9_MouseLeave(object sender, EventArgs e)
        {
            Btn1.Text = "1";
            Btn2.Text = "2";
            Btn3.Text = "3";
            Btn4.Text = "4";
            Btn5.Text = "5";
            Btn6.Text = "6";
            Btn7.Text = "7";
            Btn8.Text = "8";
            Btn9.Text = "9";
            Btn0.Text = "0";
        }

        private void Btn0_MouseHover(object sender, EventArgs e)
        {
            Btn1.Text = "*";
            Btn2.Text = "*";
            Btn3.Text = "*";
            Btn4.Text = "*";
            Btn5.Text = "*";
            Btn6.Text = "*";
            Btn7.Text = "*";
            Btn8.Text = "*";
            Btn9.Text = "*";
            Btn0.Text = "*";
        }

        private void Btn0_MouseLeave(object sender, EventArgs e)
        {
            Btn1.Text = "1";
            Btn2.Text = "2";
            Btn3.Text = "3";
            Btn4.Text = "4";
            Btn5.Text = "5";
            Btn6.Text = "6";
            Btn7.Text = "7";
            Btn8.Text = "8";
            Btn9.Text = "9";
            Btn0.Text = "0";
        }

        private void TxtContra_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Fnt_EnviarParametros()
        {
            ClsLogin_Negocio ObjEnviar = new ClsLogin_Negocio();
            ObjEnviar.Fnt_Ingresar(CbxUsuario.Text, TxtContra.Text);
            if (ObjEnviar.sw == 1)
            {
                FrmPrincipal ObjPrincipal = new FrmPrincipal();
                ObjPrincipal.LblUsuario.Text = ObjEnviar.nombre;
                ObjPrincipal.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Clave y/o Estado Inactivo, consulte con el Amistrador");
            }
        }
        private void button12_Click(object sender, EventArgs e)
        {
            Fnt_EnviarParametros();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dB_CreditosDataSet.TblCredenciales' Puede moverla o quitarla según sea necesario.
            this.tblCredencialesTableAdapter.Fill(this.dB_CreditosDataSet.TblCredenciales);

        }
    }
}
