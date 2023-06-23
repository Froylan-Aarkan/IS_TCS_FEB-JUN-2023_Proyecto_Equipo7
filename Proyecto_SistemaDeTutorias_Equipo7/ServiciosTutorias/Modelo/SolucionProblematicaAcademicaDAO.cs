using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ServiciosTutorias.Modelo
{
    /*///////////////////////////////////////////////////////////////////////////////////////////////////////////
-	Autores: Froylan De Jesus Alvarez Rodriguez, Johan David Solis Hernandez
-	Descripción: Metodos para las operaciones que se realizaran en la base de datos que tengan que ver con las soluciones de problematicas académicas
    ///////////////////////////////////////////////////////////////////////////////////////////////////////////*/
    public class SolucionProblematicaAcademicaDAO
    {
        public static bool registrarSolucionProblematicaAcademica(SolucionProblematicaAcademica solucionProblematicaAcademica, int idProblematica)
        {
            DataClassesTutoriasBDDataContext conexionBD = ConexionBaseDatos.getConnection();

            try
            {
                var solucionProblematicaAcademicaNueva = new SolucionProblematicaAcademica()
                {
                    descripcion = solucionProblematicaAcademica.descripcion,
                    fecha = solucionProblematicaAcademica.fecha,
                    idProblematicaAcademica = idProblematica,
                };

                conexionBD.SolucionProblematicaAcademica.InsertOnSubmit(solucionProblematicaAcademicaNueva);
                conexionBD.SubmitChanges();

                if (agregarSolucionAProblematica(idProblematica, solucionProblematicaAcademicaNueva.idSolucion))
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

        public static bool agregarSolucionAProblematica(int idProblematica, int idSolucion)
        {
            DataClassesTutoriasBDDataContext conexionBD = ConexionBaseDatos.getConnection();

            try
            {
                var problematicaBD = (from problematica in conexionBD.ProblematicaAcademica where problematica.idProblematicaACademica == idProblematica select problematica).FirstOrDefault();

                if (problematicaBD != null)
                {
                    problematicaBD.idSolucion = idSolucion;

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
    }
}