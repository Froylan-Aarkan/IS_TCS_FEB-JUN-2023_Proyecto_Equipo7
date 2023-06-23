using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Channels;
using System.Web;
using System.Windows.Forms;

namespace ServiciosTutorias.Modelo
{
    /*///////////////////////////////////////////////////////////////////////////////////////////////////////////
-	Autores: Froylan De Jesus Alvarez Rodriguez, Johan David Solis Hernandez
-	Descripción: Metodos para las operaciones que se realizaran en la base de datos que tengan que ver con los academicos
    ///////////////////////////////////////////////////////////////////////////////////////////////////////////*/
    public class AcademicoDAO
    {
        public static MensajeInicioSesion iniciarSesion(string correoInstitucional, string contrasenia)
        {
            
            DataClassesTutoriasBDDataContext conexionBD = ConexionBaseDatos.getConnection();

            MensajeInicioSesion mensajeInicioSesion = null;

            var academicoBD = (from academicoLogin in conexionBD.Academico where academicoLogin.correoInstitucional == correoInstitucional && academicoLogin.contrasenia == contrasenia select academicoLogin).FirstOrDefault();
           
            if (academicoBD == null) 
            {
                mensajeInicioSesion = new MensajeInicioSesion()
                {
                    error = true,
                    mensaje = "Usuario y/o contraseña incorrectas.",
                    academico = null,
                };                
            }
            else
            {
                mensajeInicioSesion = new MensajeInicioSesion()
                {
                    error = false,
                    academico = new Academico()
                    {
                        idAcademico = academicoBD.idAcademico,
                        numPersonal = academicoBD.numPersonal,
                        nombreCompleto = academicoBD.nombreCompleto,
                        correoInstitucional = academicoBD.correoInstitucional,
                        correoPersonal = academicoBD.correoPersonal,
                        contrasenia = academicoBD.contrasenia,
                        idProgramaEducativo = academicoBD.idProgramaEducativo,

                    },
                    mensaje = "Bienvenido " + academicoBD.nombreCompleto +" al sistema de tutorias.",
                };
            }

            return mensajeInicioSesion;
        }

        public static AcademicoRolAcademico obtenerRolAcademico(int idAcademico)
        {
            DataClassesTutoriasBDDataContext conexionBD = ConexionBaseDatos.getConnection();

            var academicoRolBD = (from academicoRol in conexionBD.AcademicoRolAcademico where academicoRol.idAcademico == idAcademico select academicoRol).FirstOrDefault();

            AcademicoRolAcademico academicoRolAcademico = null;

            if (academicoRolBD != null)
            {
                academicoRolAcademico = new AcademicoRolAcademico()
                {
                    idAcademico = academicoRolBD.idAcademico,
                    idRolAcademico = academicoRolBD.idRolAcademico,
                    idAcademicoRolAcademico = academicoRolBD.idAcademicoRolAcademico,
                };
            }
            else
            {
                academicoRolAcademico = null;
            }

            return academicoRolAcademico;
        }

        public static bool registrarAcademico(Academico academicoNuevo, string rolAcademico)
        {
            try
            {
                DataClassesTutoriasBDDataContext conexionBD = ConexionBaseDatos.getConnection();

                if(academicoNuevo != null)
                {

                    var academico = new Academico()
                    {
                        numPersonal = academicoNuevo.numPersonal,
                        nombreCompleto = academicoNuevo.nombreCompleto,
                        correoInstitucional = academicoNuevo.correoInstitucional,
                        correoPersonal = academicoNuevo.correoPersonal,
                        contrasenia = academicoNuevo.contrasenia,
                        idProgramaEducativo = 1,
                    };
                    
                    conexionBD.Academico.InsertOnSubmit(academico);
                    conexionBD.SubmitChanges();

                    if (!registrarAcademicoRolAcademico(academico.idAcademico, rolAcademico))
                    {
                        return false;
                    }

                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch
            {
                return false;
            }
        }

        public static bool registrarAcademicoRolAcademico(int idAcademicoNuevo, string rolAcademico)
        {
            int idRolAcademicoNuevo;

            if(rolAcademico == "Tutor")
            {
                idRolAcademicoNuevo = 1;
            }else if (rolAcademico == "Coordinador de tutorias")
            {
                idRolAcademicoNuevo = 2;
            }else if(rolAcademico == "Jefe de carrera")
            {
                idRolAcademicoNuevo = 3;
            }else if(rolAcademico == "Administrador")
            {
                idRolAcademicoNuevo = 4;
            }
            else
            {
                return false;
            }

            try
            {
                DataClassesTutoriasBDDataContext conexionBD = ConexionBaseDatos.getConnection();
                AcademicoRolAcademico academicoRolAcademicoNuevo = new AcademicoRolAcademico()
                {
                    idAcademico = idAcademicoNuevo,
                    idRolAcademico = idRolAcademicoNuevo,
                };

                conexionBD.AcademicoRolAcademico.InsertOnSubmit(academicoRolAcademicoNuevo);
                conexionBD.SubmitChanges();

                return true;

            }catch(Exception ex)
            {
                return false;
            }
        }

        public static Academico obtenerAcademicoPorId(int idAcademico)
        {
            DataClassesTutoriasBDDataContext conexionBD = ConexionBaseDatos.getConnection();

            var academicoBD = (from academico in conexionBD.Academico where academico.idAcademico == idAcademico select academico).FirstOrDefault();

            if(academicoBD != null)
            {
                Academico academicoRetorno = new Academico()
                {
                    idAcademico = academicoBD.idAcademico,
                    nombreCompleto = academicoBD.nombreCompleto,
                    correoInstitucional = academicoBD.correoInstitucional,
                    correoPersonal = academicoBD.correoPersonal,
                    contrasenia = academicoBD.contrasenia,
                    numPersonal = academicoBD.numPersonal,
                    idProgramaEducativo = academicoBD.idProgramaEducativo,
                };

                return academicoRetorno;
            }
            else
            {
                return null;
            }     
        }

        public static List<Academico> obtenerAcademicos()
        {
            try
            {
                DataClassesTutoriasBDDataContext conexionBD = ConexionBaseDatos.getConnection();

                IQueryable<Academico> academicosBD = from academicos in conexionBD.Academico
                                                     select academicos;

                List<Academico> academicosLista = new List<Academico>();

                foreach (var academico in academicosBD)
                {
                    Academico academicoSeleccion = new Academico()
                    {
                        idAcademico = academico.idAcademico,
                        nombreCompleto = academico.nombreCompleto,
                        numPersonal = academico.numPersonal,
                        correoInstitucional = academico.correoInstitucional,
                        correoPersonal = academico.correoPersonal,
                        contrasenia = academico.contrasenia,
                        idProgramaEducativo = academico.idProgramaEducativo
                    };
                    academicosLista.Add(academicoSeleccion);
                }
                return academicosLista;
            }
            catch(Exception ex)
            {
                return null;
            }
        }
    }
}