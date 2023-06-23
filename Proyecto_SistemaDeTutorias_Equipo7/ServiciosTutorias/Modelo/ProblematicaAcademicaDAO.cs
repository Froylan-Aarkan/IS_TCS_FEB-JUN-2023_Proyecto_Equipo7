using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ServiciosTutorias.Modelo
{
    /*///////////////////////////////////////////////////////////////////////////////////////////////////////////
-	Autores: Froylan De Jesus Alvarez Rodriguez, Johan David Solis Hernandez
-	Descripción: Metodos para las operaciones que se realizaran en la base de datos que tengan que ver con las problematicas académicas
    ///////////////////////////////////////////////////////////////////////////////////////////////////////////*/
    public class ProblematicaAcademicaDAO
    {
        public static bool registrarProblematicaAcademica(ProblematicaAcademica problematicaAcademicaNueva, int idCategoria, int idExperienciaEducativa)
        {
            DataClassesTutoriasBDDataContext conexionBD = ConexionBaseDatos.getConnection();

            try 
            {
                var problematicaAcademica = new ProblematicaAcademica()
                {
                    descripcion = problematicaAcademicaNueva.descripcion,
                    fecha = problematicaAcademicaNueva.fecha,
                    idCategoria = idCategoria,
                    idEE = idExperienciaEducativa,
                };

                conexionBD.ProblematicaAcademica.InsertOnSubmit(problematicaAcademica);
                conexionBD.SubmitChanges();

                return true;
            }catch(Exception ex)
            {
                return false;
            }
        }

        public static List<ProblematicaAcademica> obtenerProblematicasAcademicas()
        {
            DataClassesTutoriasBDDataContext conexionBD = ConexionBaseDatos.getConnection();

            try
            {
                IQueryable<ProblematicaAcademica> problematicasBD = from problematicaBD in conexionBD.ProblematicaAcademica where problematicaBD.idSolucion == null select problematicaBD;

                List<ProblematicaAcademica> problematicas = new List<ProblematicaAcademica>();

                foreach(ProblematicaAcademica problematica in problematicasBD)
                {
                    ProblematicaAcademica problematicaTemporal = new ProblematicaAcademica()
                    {
                        idProblematicaACademica = problematica.idProblematicaACademica,
                        descripcion = problematica.descripcion,
                        fecha = problematica.fecha,
                        idSolucion = problematica.idSolucion,
                        idCategoria = problematica.idCategoria,
                        idEE = problematica.idEE
                    };

                    problematicas.Add(problematicaTemporal);
                }

                return problematicas;

            }catch(Exception ex)
            {
                return null;
            }
        }

        public static ProblematicaAcademica problematicaConSolucion(int idProblematica)
        {
            DataClassesTutoriasBDDataContext conexionBD = ConexionBaseDatos.getConnection();

            try
            {
                var problematicaConSolucion = (from problematicaBD in conexionBD.ProblematicaAcademica where problematicaBD.idProblematicaACademica == idProblematica && problematicaBD.idSolucion != null select problematicaBD).FirstOrDefault();

                if(problematicaConSolucion != null)
                {
                    ProblematicaAcademica problematicaAcademicaRegreso = new ProblematicaAcademica()
                    {
                        idProblematicaACademica = problematicaConSolucion.idProblematicaACademica,
                        idSolucion = problematicaConSolucion.idSolucion,
                    };

                    return problematicaAcademicaRegreso;
                }
                else
                {
                    return null;
                }
            }catch(Exception ex)
            {
                return null;
            }
        }
    }
}