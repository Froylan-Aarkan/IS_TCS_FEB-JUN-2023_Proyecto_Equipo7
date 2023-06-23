using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ServiciosTutorias.Modelo
{
    /*///////////////////////////////////////////////////////////////////////////////////////////////////////////
-	Autores: Froylan De Jesus Alvarez Rodriguez, Johan David Solis Hernandez
-	Descripción: Metodos para las operaciones que se realizaran en la base de datos que tengan que ver con los programas educativos
    ///////////////////////////////////////////////////////////////////////////////////////////////////////////*/
    public class ProgramaEducativoDAO
    {
        public static ProgramaEducativo obtenerProgramasEducativosPorId(int idProgramaEducativo)
        {
            DataClassesTutoriasBDDataContext conexionBD = ConexionBaseDatos.getConnection();

            var programasEducativosBD = (from programasEducativos in conexionBD.ProgramaEducativo
                                         where idProgramaEducativo == programasEducativos.idProgramaEducativo
                                         select programasEducativos).FirstOrDefault();

            ProgramaEducativo programaEducativo = new ProgramaEducativo()
            {
                idProgramaEducativo = programasEducativosBD.idProgramaEducativo,
                nombre = programasEducativosBD.nombre
            };

            return programaEducativo;
        }

        public static List<ProgramaEducativo> obtenerProgramasEducativos()
        {
            DataClassesTutoriasBDDataContext conexionBD = ConexionBaseDatos.getConnection();

            var programasEducativosBD = from programasEducativos in conexionBD.ProgramaEducativo
                                        select programasEducativos;

            List<ProgramaEducativo> programasEducativosLista = new List<ProgramaEducativo>();

            foreach (ProgramaEducativo programaEd in programasEducativosBD)
            {
                ProgramaEducativo programaEducativo = new ProgramaEducativo()
                {
                    idProgramaEducativo = programaEd.idProgramaEducativo,
                    nombre = programaEd.nombre
                };
                programasEducativosLista.Add(programaEducativo);
            }

            return programasEducativosLista;
        }

        public static bool registrarProgramaEducativo(ProgramaEducativo programaEducativoNuevo)
        {
            try
            {
                if (programaEducativoNuevo != null)
                {
                    DataClassesTutoriasBDDataContext conexionBD = ConexionBaseDatos.getConnection();

                    var programaEducativo = new ProgramaEducativo()
                    {
                        nombre = programaEducativoNuevo.nombre
                    };

                    ProgramaEducativo programaE = (from programas in conexionBD.ProgramaEducativo
                                                   where programas.nombre == programaEducativoNuevo.nombre
                                                   select programas).FirstOrDefault();
                    if (programaE != null)
                    {
                        return false;
                    }
                    else
                    {
                        conexionBD.ProgramaEducativo.InsertOnSubmit(programaEducativo);
                        conexionBD.SubmitChanges();
                        return true;
                    }
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