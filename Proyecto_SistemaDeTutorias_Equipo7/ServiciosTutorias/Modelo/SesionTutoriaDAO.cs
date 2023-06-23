using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ServiciosTutorias.Modelo
{
    public class SesionTutoriaDAO
    {
        public static int obtenerIdSesionTutoriaPorFechaSesion(DateTime fechaSesionActual)
        {
            DataClassesTutoriasBDDataContext conexionBD = ConexionBaseDatos.getConnection();

            var sesionTutoria = from sesionBD in conexionBD.SesionTutoria where sesionBD.fechaSesion == fechaSesionActual select sesionBD;

            if(sesionTutoria != null )
            {
                SesionTutoria sesion = sesionTutoria.FirstOrDefault();
                return sesion.idSesionTutoria;
            }
            else
            {
                return -1;
            }
        }

        public static SesionTutoria obtenerSesionTutoriaPorId(int idSesionTutoria)
        {
            DataClassesTutoriasBDDataContext conexionBD = ConexionBaseDatos.getConnection();

            var sesionTutoria = (from sesionBD in conexionBD.SesionTutoria where sesionBD.idSesionTutoria == idSesionTutoria select sesionBD).FirstOrDefault();

            SesionTutoria sesionRetorno = new SesionTutoria()
            {
                idSesionTutoria = sesionTutoria.idSesionTutoria,
                numSesion = sesionTutoria.numSesion,
                fechaSesion = sesionTutoria.fechaSesion,
                idPeriodoEscolar = sesionTutoria.idPeriodoEscolar,
            };

            return sesionRetorno;
        }

        public static bool registrarFechasSesionTutoria(SesionTutoria[] sesionesTutoria, int idPeriodoEscolar)
        {
            try
            {
                DataClassesTutoriasBDDataContext conexionBD = ConexionBaseDatos.getConnection();

                IQueryable<Estudiante> estudianteBD = from estudiantes in conexionBD.Estudiante
                                                      select estudiantes;

                if (sesionesTutoria != null && estudianteBD.Count() > 0)
                {
                    foreach (SesionTutoria sesion in sesionesTutoria)
                    {
                        var sesionTemporal = new SesionTutoria()
                        {
                            numSesion = sesion.numSesion,
                            fechaSesion = sesion.fechaSesion,
                            idPeriodoEscolar = idPeriodoEscolar
                        };

                        bool existeSesion = conexionBD.SesionTutoria.Any(sesionComprobacion =>
                        sesionComprobacion.idPeriodoEscolar == sesionTemporal.idPeriodoEscolar);

                        if (existeSesion)
                        {
                            return false;
                        }

                        conexionBD.SesionTutoria.InsertOnSubmit(sesionTemporal);
                    }
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

        public static bool registrarFechasCierreParaEntrega(SesionTutoria[] sesionesTutoria, int idPeriodoEscolar)
        {
            try
            {
                DataClassesTutoriasBDDataContext conexionBD = ConexionBaseDatos.getConnection();
                if (sesionesTutoria != null)
                {
                    IQueryable<SesionTutoria> sesionTutoriaBD = from sesionesTutorias in conexionBD.SesionTutoria
                                                                where idPeriodoEscolar == sesionesTutorias.idPeriodoEscolar
                                                                select sesionesTutorias;

                    if (sesionTutoriaBD != null)
                    {
                        int i = 0;
                        List<SesionTutoria> listaSesiones = new List<SesionTutoria>();
                        foreach (var sesionTemporal in sesionTutoriaBD)
                        {
                            if (sesionTemporal.numSesion == sesionesTutoria[i].numSesion)
                            {
                                sesionTemporal.fechaLimite = sesionesTutoria[i].fechaLimite;
                                i++;
                                conexionBD.SubmitChanges();
                            }
                            else
                            {
                                return false;
                            }
                        }
                        return true;
                    }
                    else { return false; }
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

        public static bool modificarFechasCierreParaEntrega(SesionTutoria[] sesionesTutoria, int idPeriodoEscolar)
        {
            try
            {
                DataClassesTutoriasBDDataContext conexionBD = ConexionBaseDatos.getConnection();
                if (sesionesTutoria != null)
                {
                    PeriodoEscolar periodoEscolarBD = (from periodosEscolares in conexionBD.PeriodoEscolar
                                                       where periodosEscolares.idPeriodoEscolar == idPeriodoEscolar
                                                       select periodosEscolares).FirstOrDefault();

                    IQueryable<SesionTutoria> sesionTutoriaBD = from sesionesTutorias in conexionBD.SesionTutoria
                                                                where periodoEscolarBD.idPeriodoEscolar == sesionesTutorias.idPeriodoEscolar
                                                                select sesionesTutorias;

                    if (sesionTutoriaBD != null)
                    {
                        int i = 0;
                        List<SesionTutoria> listaSesiones = new List<SesionTutoria>();
                        foreach (SesionTutoria sesionTemporal in sesionTutoriaBD)
                        {
                            if (sesionTemporal.numSesion == sesionesTutoria[i].numSesion)
                            {
                                sesionTemporal.fechaLimite = sesionesTutoria[i].fechaLimite;
                                i++;
                                conexionBD.SubmitChanges();
                            }
                            else
                            {
                                return false;
                            }

                        }
                        return true;
                    }
                    else { return false; }
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

        public static List<SesionTutoria> obtenerSesionTutoriaPorIdPeriodoEscolar(int idPeriodoEscolar)
        {
            try
            {
                DataClassesTutoriasBDDataContext conexionBD = ConexionBaseDatos.getConnection();

                IQueryable<SesionTutoria> sesionTutoriaBD = from sesionesTutoria in conexionBD.SesionTutoria
                                                            where idPeriodoEscolar == sesionesTutoria.idPeriodoEscolar
                                                            select sesionesTutoria;

                List<SesionTutoria> sesionesTutoriaLista = new List<SesionTutoria>();

                foreach (SesionTutoria sesiones in sesionTutoriaBD)
                {
                    SesionTutoria sesionTutoria = new SesionTutoria()
                    {
                        idSesionTutoria = sesiones.idSesionTutoria,
                        fechaLimite = sesiones.fechaLimite,
                        fechaSesion = sesiones.fechaSesion,
                        idPeriodoEscolar = sesiones.idPeriodoEscolar
                    };
                    sesionesTutoriaLista.Add(sesionTutoria);
                }

                return sesionesTutoriaLista;
            }
            catch(Exception ex)
            {
                return null;
            }           
        }
    }
}