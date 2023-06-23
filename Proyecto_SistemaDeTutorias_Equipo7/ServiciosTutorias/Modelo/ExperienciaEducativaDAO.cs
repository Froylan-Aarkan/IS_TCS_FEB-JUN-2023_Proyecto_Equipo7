using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ServiciosTutorias.Modelo
{
    /*///////////////////////////////////////////////////////////////////////////////////////////////////////////
-	Autores: Froylan De Jesus Alvarez Rodriguez, Johan David Solis Hernandez
-	Descripción: Metodos para las operaciones que se realizaran en la base de datos que tengan que ver con las experiencias educativas
    ///////////////////////////////////////////////////////////////////////////////////////////////////////////*/
    public class ExperienciaEducativaDAO
    {
        public static List<ExperienciaEducativa> obtenerExperienciasEducativasPorIdPeriodoEscolar(int idPeriodoEscolar)
        {
            DataClassesTutoriasBDDataContext conexionBD = ConexionBaseDatos.getConnection();

            var listaExperienciaEducativasBD = from experienciaEducativa in conexionBD.ExperienciaEducativa where experienciaEducativa.idPeriodoEscolar == idPeriodoEscolar select experienciaEducativa;

            List<ExperienciaEducativa> experienciasEducativas = new List<ExperienciaEducativa>();

            foreach(ExperienciaEducativa experiencia in listaExperienciaEducativasBD)
            {
                ExperienciaEducativa experienciaEducativa = new ExperienciaEducativa()
                {
                    nombre = experiencia.nombre,
                    idAcademico = experiencia.idAcademico,
                    nrc = experiencia.nrc,
                    idEE = experiencia.idEE,
                    idPeriodoEscolar = experiencia.idPeriodoEscolar,
                    idProgramaEducativo = experiencia.idProgramaEducativo,
                };

                experienciasEducativas.Add(experienciaEducativa);
            }

            return experienciasEducativas;
        }

        public static ExperienciaEducativa obtenerExperienciaEducativaPorId(int idExperiencia)
        {
            DataClassesTutoriasBDDataContext conexionBD = ConexionBaseDatos.getConnection();

            var experienciaBD = (from experienciaEducativa in conexionBD.ExperienciaEducativa where experienciaEducativa.idEE == idExperiencia select experienciaEducativa).FirstOrDefault();

            ExperienciaEducativa experienciaRetorno = new ExperienciaEducativa()
            {
                idEE = experienciaBD.idEE,
                nrc = experienciaBD.nrc,
                nombre = experienciaBD.nombre,
                idPeriodoEscolar = experienciaBD.idPeriodoEscolar,
                idAcademico = experienciaBD.idAcademico,
                idProgramaEducativo = experienciaBD.idProgramaEducativo,
            };
            
            return experienciaRetorno;
        }

        public static bool registrarExperienciaEducativa(ExperienciaEducativa experienciaEducativa, int idProgramaEducativo, int idPeriodoEscolar)
        {
            try
            {
                DataClassesTutoriasBDDataContext conexionBD = ConexionBaseDatos.getConnection();

                PeriodoEscolar periodoEscolarBD = (from periodosEscolares in conexionBD.PeriodoEscolar
                                                   where periodosEscolares.idPeriodoEscolar == idPeriodoEscolar
                                                   select periodosEscolares).FirstOrDefault();

                ProgramaEducativo programaEducativoBD = (from programasEducativos in conexionBD.ProgramaEducativo
                                                         where programasEducativos.idProgramaEducativo == idProgramaEducativo
                                                         select programasEducativos).FirstOrDefault();

                var experienciaEducativaNueva = new ExperienciaEducativa
                {
                    nombre = experienciaEducativa.nombre,
                    nrc = experienciaEducativa.nrc,
                    idPeriodoEscolar = periodoEscolarBD.idPeriodoEscolar,
                    idProgramaEducativo = programaEducativoBD.idProgramaEducativo
                };

                ExperienciaEducativa experienciaComprobacion = (from experiencias in conexionBD.ExperienciaEducativa
                                                                where experiencias.nombre == experienciaEducativaNueva.nombre
                                                                && experiencias.nrc == experienciaEducativaNueva.nrc
                                                                && experiencias.idPeriodoEscolar == experienciaEducativaNueva.idPeriodoEscolar
                                                                select experiencias).FirstOrDefault();

                if (experienciaComprobacion != null)
                {
                    return false;
                }

                conexionBD.ExperienciaEducativa.InsertOnSubmit(experienciaEducativaNueva);
                conexionBD.SubmitChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public static List<ExperienciaEducativa> obtenerExperienciasEducativasPorIdProgramaEducativo(int idProgramaEducativo)
        {
            try
            {
                DataClassesTutoriasBDDataContext conexionBD = ConexionBaseDatos.getConnection();

                IQueryable<ExperienciaEducativa> listaExperienciaEducativasBD = from experienciaEducativa in conexionBD.ExperienciaEducativa
                                                                                where experienciaEducativa.idProgramaEducativo == idProgramaEducativo
                                                                                select experienciaEducativa;

                List<ExperienciaEducativa> experienciasEducativas = new List<ExperienciaEducativa>();

                foreach (ExperienciaEducativa experiencia in listaExperienciaEducativasBD)
                {
                    ExperienciaEducativa experienciaEducativa = new ExperienciaEducativa()
                    {
                        nombre = experiencia.nombre,
                        idAcademico = experiencia.idAcademico,
                        nrc = experiencia.nrc,
                        idEE = experiencia.idEE,
                        idPeriodoEscolar = experiencia.idPeriodoEscolar,
                        idProgramaEducativo = experiencia.idProgramaEducativo,
                    };

                    experienciasEducativas.Add(experienciaEducativa);
                }

                return experienciasEducativas;
            }
            catch(Exception ex)
            {
                return null;
            }            
        }
    }
}