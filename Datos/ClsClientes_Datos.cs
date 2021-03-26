using System;
using System.Data;
using System.Data.SqlClient;

namespace Datos
{
    public class ClsClientes_Datos
    {
        public SqlDataReader Lectura;
        public void Fnt_AgregarCliente(String id, String nombre, String contacto, String correo, String edad, String ingresos, String Empresa, String contactoE, String Sexo, String estado)
        {
            Fnt_Agregar(id, nombre, contacto, correo, edad, ingresos, Empresa, contactoE, Sexo, estado);
        }
        protected void Fnt_Agregar(String id,
            String nombre,
            String contacto,
            String correo,
            String edad,
            String Ingresos,
            String Empresa, String contactoE, String Sexo, String estado)
        {
            ClsConexion objconect = new ClsConexion();
            SqlCommand con = new SqlCommand("SP_AgregarCliente", objconect.connection);
            con.CommandType = CommandType.StoredProcedure;
            con.Parameters.AddWithValue("@id", id);
            con.Parameters.AddWithValue("@nombres", nombre);
            con.Parameters.AddWithValue("@contacto", contacto);
            con.Parameters.AddWithValue("@correo", correo);
            con.Parameters.AddWithValue("@edad", edad);
            con.Parameters.AddWithValue("@ingresos", Ingresos);
            con.Parameters.AddWithValue("@empresa", Empresa);
            con.Parameters.AddWithValue("@contactoE", contactoE);
            con.Parameters.AddWithValue("@sexo", Sexo);
            con.Parameters.AddWithValue("@estado", estado);
            objconect.connection.Open();
            con.ExecuteNonQuery();
            objconect.connection.Close();
        }

        public void Fnt_ConsultarDatos(String id)
        {
            ClsConexion objconect = new ClsConexion();
            SqlCommand con; 
            con = new SqlCommand("SP_Ingresar", objconect.connection);
            con.CommandType = CommandType.StoredProcedure;
            con.Parameters.AddWithValue("@correo", id);
            objconect.connection.Open();
            Lectura = con.ExecuteReader();
                if (Lectura.Read() == true)
            {
                nombre = Convert.ToString(Lectura[0]);
                sw = 1;
            }
            objconect.connection.Close();
           
        }
    }    
}
