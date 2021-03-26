using System;
using Datos;

namespace Negocio
{
    public class ClsCliente_Negocio
    {
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
                msn = "El cliente: " + nombre + " ha sido registrado con exito";
            }
        }
        public void Fnt_ConsultarCliente(String id)
            {
                if(id !="")
                {
                ClsClientes_Datos ObjConsultar = new ClsClientes_Datos();
                ObjConsultar.Fnt_ConsultarDatos(id);
                nombre_ = Convert.ToString(ObjConsultar.Lectura[0]);
                contacto_ = Convert.ToString(ObjConsultar.Lectura[1]);
                correo_ = Convert.ToString(ObjConsultar.Lectura[2]);
                edad_ = Convert.ToString(ObjConsultar.Lectura[3]);
                ingresos_ = Convert.ToString(ObjConsultar.Lectura[4]);
                Empresa_ = Convert.ToString(ObjConsultar.Lectura[5]);
                contactoE_ = Convert.ToString(ObjConsultar.Lectura[6]);
                Sexo_ = Convert.ToString(ObjConsultar.Lectura[7]);
                estado_ = Convert.ToString(ObjConsultar.Lectura[8]);
                }
            }
    }
}
