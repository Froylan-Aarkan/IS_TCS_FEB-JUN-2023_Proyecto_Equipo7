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
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IService1" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        MensajeInicioSesion iniciarSesion(string correoInstitucional, string contrasenia);
        [OperationContract]
        AcademicoRolAcademico obtenerRolAcademico(int idAcademico);
        [OperationContract]
        int obtenerIdSesionTutoriaPorFechaSesion(DateTime fechaSesion);
        [OperationContract]
        bool registrarComentarioGeneral(ComentarioGeneral comentarioGeneralNuevo);
        [OperationContract]
        bool registrarAcademico(Academico academicoNuevo, string rolAcademico);
        [OperationContract]
        bool registrarAcademicoRolAcademico(int idAcademicoNuevo, string rolAcademico);
        [OperationContract]
        List<Estudiante> obtenerEstudiantesPorIdAcademico(int idAcademico);
        [OperationContract]
        Academico obtenerAcademicoPorId(int idAcademico);
        [OperationContract]
        bool registrarProblematicaAcademica(ProblematicaAcademica problematicaAcademicaNueva, int idCategoriaProblematica, int idExperienciaEducativa);
        [OperationContract]
        List<CategoriaProblematica> obtenerCategoriasProblematicas();
        [OperationContract]
        List<ExperienciaEducativa> obtenerExperienciasEducativasPorIdPeriodoEscolar(int idPeriodoEscolar);
        [OperationContract]
        CategoriaProblematica obtenerCategoriaProblematicaPorId(int idCategoria);
        [OperationContract]
        ExperienciaEducativa obtenerExperienciaEducativaPorId(int idExperiencia);
        [OperationContract]
        SesionTutoria obtenerSesionTutoriaPorId(int idSesionTutoria);
        [OperationContract]
        PeriodoEscolar obtenerPeriodoEscolarPorId(int idPeriodoEscolar);
        [OperationContract]
        bool registrarHorarioSesion(SesionTutoria sesionTutoria, Estudiante estudiante, DateTime fechaHora);
        [OperationContract]
        bool horarioOcupado(int idSesionTutoria, TimeSpan hora);
        [OperationContract]
        bool estudianteConHorario(int idEstudiante);
        [OperationContract]
        List<ProblematicaAcademica> obtenerProblematicasAcademicas();
        [OperationContract]
        bool registrarSolucionProblematicaAcademica(SolucionProblematicaAcademica solucionProblematicaAcademica, int idProblematica);
        [OperationContract]
        bool agregarSolucionAProblematica(int idProblematica, int idSolucion);
        [OperationContract]
        ProblematicaAcademica problematicaConSolucion(int idProblematica);
        [OperationContract]
        bool registrarEstudiante(Estudiante estudiante);
        [OperationContract]
        bool registrarExperienciaEducativa(ExperienciaEducativa experienciaEducativa, int idProgramaEducativo, int idPeriodoEscolar);
        [OperationContract]
        bool registrarFechasSesionTutoria(SesionTutoria[] sesionesTutoria, int idPeriodoEscolar);
        [OperationContract]
        bool registrarFechasCierreParaEntrega(SesionTutoria[] sesionesTutoria, int sesionTutoria);
        [OperationContract]
        bool modificarFechasCierreParaEntrega(SesionTutoria[] sesionesTutoria, int sesionTutoriaEditar);
        [OperationContract]
        ProgramaEducativo obtenerProgramasEducativosPorId(int idProgramaEducativo);
        [OperationContract]
        List<ProgramaEducativo> obtenerProgramasEducativos();
        [OperationContract]
        PeriodoEscolar obtenerPeriodosEscolaresPorId(int idPeriodoEscolar);
        [OperationContract]
        List<PeriodoEscolar> obtenerPeriodosEscolares();
        [OperationContract]
        List<SesionTutoria> obtenerSesionTutoriaPorIdPeriodoEscolar(int idPeriodoEscolar);
        [OperationContract]
        List<ExperienciaEducativa> obtenerExperienciasEducativasPorIdProgramaEducativo(int idProgramaEducativo);
        [OperationContract]
        List<Estudiante> obtenerEstudiantesSinTutor();
        [OperationContract]
        List<Academico> obtenerAcademicos();
        [OperationContract]
        bool asignarAcademicoAEstudiante(int idAcademico, int idEstudiante);
        [OperationContract]
        List<Estudiante> obtenerEstudiantesConTutor();
        [OperationContract]
        bool registrarProgramaEducativo(ProgramaEducativo programaEducativoNuevo);
    }
}
