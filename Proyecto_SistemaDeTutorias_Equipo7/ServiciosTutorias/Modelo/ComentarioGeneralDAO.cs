using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ServiciosTutorias.Modelo
{
    public class ComentarioGeneralDAO
    {
        public static bool registrarComentarioGeneral(ComentarioGeneral comentarioGeneralNuevo)
        {
            try
            {
                DataClassesTutoriasBDDataContext conexionBD = ConexionBaseDatos.getConnection();

                //int idSesionTutoriaActual = SesionTutoriaDAO.obtenerIdSesionTutoriaPorFechaSesion((DateTime)comentarioGeneralNuevo.fecha);

                //if(idSesionTutoriaActual != -1)
                //{
                    var comentarioGeneral = new ComentarioGeneral()
                    {
                        descripcion = comentarioGeneralNuevo.descripcion,
                        fecha = comentarioGeneralNuevo.fecha,
                        idSesionTutoria = 2,
                    };

                    conexionBD.ComentarioGeneral.InsertOnSubmit(comentarioGeneral);
                    conexionBD.SubmitChanges();

                    return true;
                //}
                //else
                //{
                //    resultadoOperacion = false;
                //}
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}