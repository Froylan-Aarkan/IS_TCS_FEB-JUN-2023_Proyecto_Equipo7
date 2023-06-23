using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ServiciosTutorias.Modelo
{
    public class ConexionBaseDatos
    {
    /*///////////////////////////////////////////////////////////////////////////////////////////////////////////
-	Autor: Froylan De Jesus Alvarez Rodriguez
-	Descripción: Metodo para realizar la conexión a base de datos para evitar codigo duplicado.
    ///////////////////////////////////////////////////////////////////////////////////////////////////////////*/
        public static DataClassesTutoriasBDDataContext getConnection()
        {
            return new DataClassesTutoriasBDDataContext(global::System.Configuration.ConfigurationManager.ConnectionStrings["TutoriasBDConnectionString"].ConnectionString);
        }
    }
}