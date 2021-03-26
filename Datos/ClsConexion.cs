using System;
using System.Data.SqlClient;

namespace Datos
{
    public class ClsConexion
    {
        public SqlConnection connection = new SqlConnection("Data Source=DESKTOP-5QCTL50\\SQLEXPRESS;Initial Catalog=DB_Creditos;integrated security = true");
    }
}
