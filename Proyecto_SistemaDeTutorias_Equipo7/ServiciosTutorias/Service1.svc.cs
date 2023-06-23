using ServiciosTutorias.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace ServiciosTutorias
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Service1" en el código, en svc y en el archivo de configuración.
    // NOTE: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione Service1.svc o Service1.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class Service1 : IService1
    {
        public MensajeInicioSesion iniciarSesion(string correoInstitucional, string contrasenia)
        {
            return AcademicoDAO.iniciarSesion(correoInstitucional, contrasenia);
        }

        public Academico obtenerAcademicoPorId(int idAcademico)
        {
            return AcademicoDAO.obtenerAcademicoPorId(idAcademico);
        }

        public List<CategoriaProblematica> obtenerCategoriasProblematicas()
        {
            return CategoriaProblematicaDAO.obtenerCategoriasProblematicas();
        }

        public List<Estudiante> obtenerEstudiantesPorIdAcademico(int idAcademico)
        {
            return EstudianteDAO.obtenerEstudiantesPorIdAcademico(idAcademico);
        }

        public List<ExperienciaEducativa> obtenerExperienciasEducativasPorIdPeriodoEscolar(int idPeriodoEscolar)
        {
            return ExperienciaEducativaDAO.obtenerExperienciasEducativasPorIdPeriodoEscolar(idPeriodoEscolar);
        }

        public int obtenerIdSesionTutoriaPorFechaSesion(DateTime fechaSesion)
        {
            return SesionTutoriaDAO.obtenerIdSesionTutoriaPorFechaSesion(fechaSesion);
        }

        public AcademicoRolAcademico obtenerRolAcademico(int idAcademico)
        {
            return AcademicoDAO.obtenerRolAcademico(idAcademico);
        }

        public bool registrarAcademico(Academico academicoNuevo, string rolAcademico)
        {
            return AcademicoDAO.registrarAcademico(academicoNuevo, rolAcademico);
        }

        public bool registrarAcademicoRolAcademico(int idAcademicoNuevo, string rolAcademico)
        {
            return AcademicoDAO.registrarAcademicoRolAcademico(idAcademicoNuevo, rolAcademico);
        }

        public bool registrarComentarioGeneral(ComentarioGeneral comentarioGeneralNuevo)
        {
            return ComentarioGeneralDAO.registrarComentarioGeneral(comentarioGeneralNuevo);
        }

        public bool registrarProblematicaAcademica(ProblematicaAcademica problematicaAcademicaNueva, int idCategoriaProblematica, int idExperienciaEducativa)
        {
            return ProblematicaAcademicaDAO.registrarProblematicaAcademica(problematicaAcademicaNueva, idCategoriaProblematica, idExperienciaEducativa);
        }

        public CategoriaProblematica obtenerCategoriaProblematicaPorId(int idCategoria)
        {
            return CategoriaProblematicaDAO.obtenerCategoriaProblematicaPorId(idCategoria);
        }

        public ExperienciaEducativa obtenerExperienciaEducativaPorId(int idExperiencia)
        {
            return ExperienciaEducativaDAO.obtenerExperienciaEducativaPorId(idExperiencia);
        }

        public SesionTutoria obtenerSesionTutoriaPorId(int idSesionTutoria)
        {
            return SesionTutoriaDAO.obtenerSesionTutoriaPorId(idSesionTutoria);
        }

        public PeriodoEscolar obtenerPeriodoEscolarPorId(int idPeriodoEscolar)
        {
            return PeriodoEscolarDAO.obtenerPeriodoEscolarPorId(idPeriodoEscolar);
        }

        public bool registrarHorarioSesion(SesionTutoria sesionTutoria, Estudiante estudiante, DateTime fechaHora)
        {
            return SesionTutoriaEstudianteDAO.registrarHorarioSesion(sesionTutoria, estudiante, fechaHora);
        }

        public bool horarioOcupado(int idSesionTutoria, TimeSpan hora)
        {
            return SesionTutoriaEstudianteDAO.horarioOcupado(idSesionTutoria, hora);
        }

        public bool estudianteConHorario(int idEstudiante)
        {
            return SesionTutoriaEstudianteDAO.estudianteConHorario(idEstudiante);
        }

        public List<ProblematicaAcademica> obtenerProblematicasAcademicas()
        {
            return ProblematicaAcademicaDAO.obtenerProblematicasAcademicas();
        }

        public bool registrarSolucionProblematicaAcademica(SolucionProblematicaAcademica solucionProblematicaAcademica, int idProblematica)
        {
            return SolucionProblematicaAcademicaDAO.registrarSolucionProblematicaAcademica(solucionProblematicaAcademica, idProblematica);
        }

        public bool agregarSolucionAProblematica(int idProblematica, int idSolucion)
        {
            return SolucionProblematicaAcademicaDAO.agregarSolucionAProblematica(idProblematica, idSolucion);
        }

        public ProblematicaAcademica problematicaConSolucion(int idProblematica)
        {
            return ProblematicaAcademicaDAO.problematicaConSolucion(idProblematica);
        }

        public bool registrarEstudiante(Estudiante estudiante)
        {
            return EstudianteDAO.registrarEstudiante(estudiante);
        }

        public bool registrarExperienciaEducativa(ExperienciaEducativa experienciaEducativa, int idProgramaEducativo, int idPeriodoEscolar)
        {
            return ExperienciaEducativaDAO.registrarExperienciaEducativa(experienciaEducativa, idProgramaEducativo, idPeriodoEscolar);
        }

        public bool registrarFechasSesionTutoria(SesionTutoria[] sesionesTutoria, int idPeriodoEscolar)
        {
            return SesionTutoriaDAO.registrarFechasSesionTutoria(sesionesTutoria, idPeriodoEscolar);
        }

        public bool registrarFechasCierreParaEntrega(SesionTutoria[] sesionesTutoria, int sesionTutoria)
        {
            return SesionTutoriaDAO.registrarFechasCierreParaEntrega(sesionesTutoria, sesionTutoria);
        }

        public bool modificarFechasCierreParaEntrega(SesionTutoria[] sesionesTutoria, int sesionTutoriaEditar)
        {
            return SesionTutoriaDAO.modificarFechasCierreParaEntrega(sesionesTutoria, sesionTutoriaEditar);
        }

        public ProgramaEducativo obtenerProgramasEducativosPorId(int idProgramaEducativo)
        {
            return ProgramaEducativoDAO.obtenerProgramasEducativosPorId(idProgramaEducativo);
        }

        public PeriodoEscolar obtenerPeriodosEscolaresPorId(int idPeriodoEscolar)
        {
            return PeriodoEscolarDAO.obtenerPeriodosEscolaresPorId(idPeriodoEscolar);
        }

        public List<ProgramaEducativo> obtenerProgramasEducativos()
        {
            return ProgramaEducativoDAO.obtenerProgramasEducativos();
        }

        public List<PeriodoEscolar> obtenerPeriodosEscolares()
        {
            return PeriodoEscolarDAO.obtenerPeriodosEscolares();
        }

        public List<SesionTutoria> obtenerSesionTutoriaPorIdPeriodoEscolar(int idPeriodoEscolar)
        {
            return SesionTutoriaDAO.obtenerSesionTutoriaPorIdPeriodoEscolar(idPeriodoEscolar);
        }

        public List<ExperienciaEducativa> obtenerExperienciasEducativasPorIdProgramaEducativo(int idProgramaEducativo)
        {
            return ExperienciaEducativaDAO.obtenerExperienciasEducativasPorIdProgramaEducativo(idProgramaEducativo);
        }

        public List<Estudiante> obtenerEstudiantesSinTutor()
        {
            return EstudianteDAO.obtenerEstudiantesSinTutor();
        }

        public List<Academico> obtenerAcademicos()
        {
            return AcademicoDAO.obtenerAcademicos();
        }

        public bool asignarAcademicoAEstudiante(int idAcademico, int idEstudiante)
        {
            return EstudianteDAO.asignarAcademicoAEstudiante(idAcademico, idEstudiante);
        }

        public List<Estudiante> obtenerEstudiantesConTutor()
        {
            return EstudianteDAO.obtenerEstudiantesConTutor();
        }

        public bool registrarProgramaEducativo(ProgramaEducativo programaEducativoNuevo)
        {
            return ProgramaEducativoDAO.registrarProgramaEducativo(programaEducativoNuevo);

        }
    }
}
