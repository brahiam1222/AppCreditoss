using System;
using Datos;

namespace Negocio
{
    public class ClsCliente_Negocio
    {
        public String[] aux = new  String[9];
        public int pos; public Decimal total, cuota2;
        public String msn;
        public String id_, nombre_, 
                contacto_,  correo_, 
              edad_, ingresos_,  Empresa_, contactoE_,  Sexo_,  estado_;
        public void Fnt_AgregarCliente(String id, String nombre, String contacto, String correo, String edad, String ingresos, String Empresa, String contactoE, String Sexo, String estado)
        {
            if (((((((((id == "") || (nombre == "") || (contacto == "") || (correo == "") || (edad == "") || (ingresos == "") || (Empresa == "" ) || (contactoE == "")))))))))
            {
                msn = "Debe ingresar la informacion que se le pida";
            }
            else
            {
                ClsClientes_Datos ObjClientes = new ClsClientes_Datos();
                ObjClientes.Fnt_AgregarCliente(id, 
                    nombre,
                    contacto,
                    correo,
                    edad,
                    ingresos,
                    Empresa, 
                    contactoE, 
                    Sexo, 
                    estado);
                if(ObjClientes.sw ==0)
                { 
                msn = "El cliente: " + nombre + " ha sido registrado con exito";
                }
                else
                {
                    msn = "La identificacion" + id + "no se puede registrar";
                }
            }
        }
        public void Fnt_ConsultarCliente(String id)
            {
                if(id !="")    
            {
                ClsClientes_Datos ObjConsultar = new ClsClientes_Datos();
                ObjConsultar.Fnt_ConsultarDatos(id);

                if (ObjConsultar.sw == 1)
                {
                    for (int i = 0; i <= 8; i++)
                    {
                        aux[i] = Convert.ToString(ObjConsultar.Lectura[i]);
                    }
                    ObjConsultar.objconect_select.connection.Close();
                    msn = "";
                }
                else
                    {
                        msn = "No se econtraron registros" + id;                   
                    }

                //nombre_ = Convert.ToString(ObjConsultar.Lectura[0]);
                //contacto_ = Convert.ToString(ObjConsultar.Lectura[1]);
                //correo_ = Convert.ToString(ObjConsultar.Lectura[2]);
                //edad_ = Convert.ToString(ObjConsultar.Lectura[3]);
                //ingresos_ = Convert.ToString(ObjConsultar.Lectura[4]);
                //Empresa_ = Convert.ToString(ObjConsultar.Lectura[5]);
                //contactoE_ = Convert.ToString(ObjConsultar.Lectura[6]);
                //Sexo_ = Convert.ToString(ObjConsultar.Lectura[7]);
                //estado_ = Convert.ToString(ObjConsultar.Lectura[8]);
            }
        }
        public void Fnt_Actualizar(
                    String id, String contacto,
                    String correo, String edad, String ingresos, String Empresa, String contactoE, String estado)
                {
                    if (((((((((id == "") || (contacto == "") || (correo == "") || (edad == "") || (ingresos == "") || (Empresa == "") || (contactoE == "")))))))))
                    {
                    msn = "Debe ingresar la informacion que se le pida";
                    }
                    else
                    {
                    ClsClientes_Datos ObjClientes = new ClsClientes_Datos();
                    ObjClientes.Fnt_ActualizarCliente(id,
                    contacto,
                    correo,
                    edad,
                    ingresos,
                    Empresa,
                    contactoE,
                    estado);
                msn = "Se ha actualizado con exito";
            }
        }
        public void Fnt_CalcularCuota(String monto, int cuota)
        {
            ClsClientes_Datos ObjCalcular = new ClsClientes_Datos();
            ObjCalcular.Fnt_ConsultarCuota(monto, cuota);
            cuota2 = Convert.ToDecimal(ObjCalcular.cuota2);
            total = Convert.ToDecimal(ObjCalcular.total);
            pos = Convert.ToInt32(ObjCalcular.pos_interes);
        }
        public void Fnt_CambiarClave(String user, String claveOld, String claveNew, String confirmarPass)
        {
            ClsClientes_Datos ObjCambiarClave = new ClsClientes_Datos();
            ObjCambiarClave.Fnt_CambiarClave(user, claveOld, claveNew, confirmarPass);
            msn = ObjCambiarClave.mensaje;
        }
    }
}
//for (int i = 0; i <= 8; i++)
//{
//    aux[i] = Convert.ToString(ObjConsultar.Lectura[i]);
//}