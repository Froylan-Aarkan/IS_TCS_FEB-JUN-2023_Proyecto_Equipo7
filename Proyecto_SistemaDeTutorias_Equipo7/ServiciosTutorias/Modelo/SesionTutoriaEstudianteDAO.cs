using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ServiciosTutorias.Modelo
{
    /*///////////////////////////////////////////////////////////////////////////////////////////////////////////
-	Autores: Froylan De Jesus Alvarez Rodriguez, Johan David Solis Hernandez
-	Descripción: Metodos para las operaciones que se realizaran para asignar horario de sesion a los estuidantes
    ///////////////////////////////////////////////////////////////////////////////////////////////////////////*/
    public class SesionTutoriaEstudianteDAO
    {
        public static bool registrarHorarioSesion(SesionTutoria sesionTutoria, Estudiante estudiante, DateTime fechaHora)
        {
            DataClassesTutoriasBDDataContext conexionBD = ConexionBaseDatos.getConnection();

            try
            {
                TimeSpan hora = fechaHora.TimeOfDay;

                SesionTutoriaEstudiante sesionTutoriaEstudiante = new SesionTutoriaEstudiante()
                {
                    idSesionTutoria = sesionTutoria.idSesionTutoria,
                    idEstudiante = estudiante.idEstudiante,
                    horario = hora,
                };

                conexionBD.SesionTutoriaEstudiante.InsertOnSubmit(sesionTutoriaEstudiante);
                conexionBD.SubmitChanges();

                return true;

            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public static bool horarioOcupado(int idSesionTutoria, TimeSpan hora)
        {
            DataClassesTutoriasBDDataContext conexionBD = ConexionBaseDatos.getConnection();

            try
            {
                var horarioBD = (from horario in conexionBD.SesionTutoriaEstudiante where horario.horario == hora && horario.idSesionTutoria == idSesionTutoria select horario).FirstOrDefault();

                if(horarioBD != null)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public static bool estudianteConHorario(int idEstudiante)
        {
            DataClassesTutoriasBDDataContext conexionBD = ConexionBaseDatos.getConnection();

            try
            {
                var horarioBD = (from horario in conexionBD.SesionTutoriaEstudiante where horario.idEstudiante == idEstudiante select horario).FirstOrDefault();
                
                if (horarioBD != null)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }catch(Exception ex)
            {
                return false;
            }
        }
    }
}