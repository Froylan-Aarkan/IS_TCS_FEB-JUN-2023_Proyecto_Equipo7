using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ServiciosTutorias.Modelo
{
    /*///////////////////////////////////////////////////////////////////////////////////////////////////////////
-	Autores: Froylan De Jesus Alvarez Rodriguez, Johan David Solis Hernandez
-	Descripción: Metodos para las operaciones que se realizaran en la base de datos que tengan que ver con los comentarios generales
    ///////////////////////////////////////////////////////////////////////////////////////////////////////////*/
    public class ComentarioGeneralDAO
    {
        public static bool registrarComentarioGeneral(ComentarioGeneral comentarioGeneralNuevo)
        {
            try
            {
                DataClassesTutoriasBDDataContext conexionBD = ConexionBaseDatos.getConnection();

                    var comentarioGeneral = new ComentarioGeneral()
                    {
                        descripcion = comentarioGeneralNuevo.descripcion,
                        fecha = comentarioGeneralNuevo.fecha,
                        idSesionTutoria = 2,
                    };

                    conexionBD.ComentarioGeneral.InsertOnSubmit(comentarioGeneral);
                    conexionBD.SubmitChanges();

                    return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}