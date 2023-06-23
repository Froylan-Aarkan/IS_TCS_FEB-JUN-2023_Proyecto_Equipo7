using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ServiciosTutorias.Modelo
{
    public class ConexionBaseDatos
    {
        public static DataClassesTutoriasBDDataContext getConnection()
        {
            return new DataClassesTutoriasBDDataContext(global::System.Configuration.ConfigurationManager.ConnectionStrings["TutoriasBDConnectionString"].ConnectionString);
        }
    }
}