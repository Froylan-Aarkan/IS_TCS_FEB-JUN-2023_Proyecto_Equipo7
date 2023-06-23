using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ServiciosTutorias.Modelo
{
    public class EstudianteDAO
    {
        public static List<Estudiante> obtenerEstudiantesPorIdAcademico(int idAcademico)
        {
            DataClassesTutoriasBDDataContext conexionBD = ConexionBaseDatos.getConnection();

            var listaEstudiantesBD = from estudianteBD in conexionBD.Estudiante where estudianteBD.idAcademico == idAcademico select estudianteBD;

            List<Estudiante> listaEstudiantes = new List<Estudiante>();

            foreach(Estudiante estudianteLista in listaEstudiantesBD)
            {
                Estudiante estudiante = new Estudiante()
                {
                    idEstudiante = estudianteLista.idEstudiante,
                    matricula = estudianteLista.matricula,
                    nombreCompleto = estudianteLista.nombreCompleto,
                    correoPersonal = estudianteLista.correoPersonal,
                    correoInstucional = estudianteLista.correoInstucional,
                    idAcademico = estudianteLista.idAcademico,
                };

                listaEstudiantes.Add(estudiante);
            }        

            return listaEstudiantes;
        }

        public static bool registrarEstudiante(Estudiante estudiante)
        {
            try
            {
                DataClassesTutoriasBDDataContext conexionBD = ConexionBaseDatos.getConnection();
                if (estudiante != null)
                {
                    var estudianteNuevo = new Estudiante
                    {
                        nombreCompleto = estudiante.nombreCompleto,
                        matricula = estudiante.matricula,
                        correoPersonal = estudiante.correoPersonal,
                        correoInstucional = estudiante.correoInstucional,
                    };
                    conexionBD.Estudiante.InsertOnSubmit(estudianteNuevo);
                    conexionBD.SubmitChanges();
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

        public static List<Estudiante> obtenerEstudiantesSinTutor()
        {
            try
            {
                DataClassesTutoriasBDDataContext conexionBD = ConexionBaseDatos.getConnection();

                IQueryable<Estudiante> estudiantesBD = from estudianteBD in conexionBD.Estudiante where estudianteBD.idAcademico == null select estudianteBD;

                List<Estudiante> estudiantesRetorno = new List<Estudiante>();

                foreach(Estudiante estudiante in estudiantesBD)
                {
                    Estudiante estudianteTemporal = new Estudiante()
                    {
                        idEstudiante = estudiante.idEstudiante,
                        matricula = estudiante.matricula,
                        nombreCompleto = estudiante.nombreCompleto,
                        correoPersonal = estudiante.correoPersonal,
                        correoInstucional = estudiante.correoInstucional,
                    };

                    estudiantesRetorno.Add(estudianteTemporal);
                }

                return estudiantesRetorno;
            }
            catch(Exception ex)
            {
                return null;
            }
        }

        public static bool asignarAcademicoAEstudiante(int idAcademico, int idEstudiante)
        {
            try
            {
                DataClassesTutoriasBDDataContext conexionBD = ConexionBaseDatos.getConnection();

                Estudiante estudianteBD = (from estudiantes in conexionBD.Estudiante
                                           where estudiantes.idEstudiante == idEstudiante
                                           select estudiantes).FirstOrDefault();

                if (estudianteBD != null)
                {
                    estudianteBD.idAcademico = idAcademico;
                    conexionBD.SubmitChanges();
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

        public static List<Estudiante> obtenerEstudiantesConTutor()
        {
            try
            {
                DataClassesTutoriasBDDataContext conexionBD = ConexionBaseDatos.getConnection();

                IQueryable<Estudiante> estudiantesBD = from estudiantes in conexionBD.Estudiante
                                                       where estudiantes.idAcademico != null
                                                       select estudiantes;

                List<Estudiante> estudiantesLista = new List<Estudiante>();

                foreach (var estudiante in estudiantesBD)
                {
                    Estudiante estudianteSeleccion = new Estudiante()
                    {
                        idEstudiante = estudiante.idEstudiante,
                        nombreCompleto = estudiante.nombreCompleto,
                        matricula = estudiante.matricula,
                        correoInstucional = estudiante.correoInstucional,
                        correoPersonal = estudiante.correoPersonal,
                        idAcademico = estudiante.idAcademico,
                    };
                    estudiantesLista.Add(estudianteSeleccion);
                }
                return estudiantesLista;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}