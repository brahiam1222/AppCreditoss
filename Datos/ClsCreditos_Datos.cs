using System;
using System.Data;
using System.Data.SqlClient;

namespace Datos
{
    public class ClsCreditos_Datos
    {
        public void fnt_Guardar(
            String id,
            String diaPago,
            String valorPrestamo,
            int plazo,
            String cuota,
            int interes,
            String ValorTotal,
            String user)
        {
            ClsConexion objconect = new ClsConexion();
            SqlCommand con;
            con = new SqlCommand("SP_NuevoCredito", objconect.connection);
            con.CommandType = CommandType.StoredProcedure;
            con.Parameters.AddWithValue("@id", id);
            con.Parameters.AddWithValue("diaPago", diaPago);
            con.Parameters.AddWithValue("@valorPrestamo", valorPrestamo);
            con.Parameters.AddWithValue("@plazo", plazo);
            con.Parameters.AddWithValue("@cuota", cuota);
            con.Parameters.AddWithValue("@interes", interes);
            con.Parameters.AddWithValue("@ValorTotal", ValorTotal);
            con.Parameters.AddWithValue("@user", user);
            objconect.connection.Open();
            con.ExecuteNonQuery();
            objconect.connection.Close();
        }
    }
    
    
}
