using System;
using Datos;

namespace Negocio
{
    public class ClsCredito_Negocio
    {
        public String msn = "";
        public void Fnt_GuardarCredito(String id,
            String diaPago,
            String valorPrestamo,
            int plazo,
            String cuota,
            int interes,
            String ValorTotal,
            String user)
        {
            if (id == "" || valorPrestamo == "" || diaPago == "")
            {
                msn = "Debe diligenciar toda la informacion";
            }
            else
            {
                ClsCreditos_Datos ObjGuardar = new ClsCreditos_Datos();
                ObjGuardar.fnt_Guardar(id, diaPago, valorPrestamo, plazo, cuota, interes, ValorTotal, user);
                msn = "Se ha creado el credito con exito";
            }
        }
    }
}
