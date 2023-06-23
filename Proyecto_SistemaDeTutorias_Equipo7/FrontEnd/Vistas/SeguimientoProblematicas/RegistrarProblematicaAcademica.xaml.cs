using ReferenciaServicioTutorias;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace FrontEnd.Vistas.SeguimientoProblematicas
{
    /// <summary>
    /// Lógica de interacción para RegistrarProblematicaAcademica.xaml
    /// </summary>
    public partial class RegistrarProblematicaAcademica : Window
    {
        public RegistrarProblematicaAcademica()
        {
            InitializeComponent();
            
        }

        private void btnGuardar_Click(object sender, RoutedEventArgs e)
        {
            if (hayCamposValidos())
            {
                
                CategoriaProblematica categoriaComboBox = (CategoriaProblematica) cbCategoria.SelectedItem;
                ExperienciaEducativa experienciaComboBox = (ExperienciaEducativa) cbExperienciaEducativa.SelectedItem;

                int idCategoria = categoriaComboBox.idCategoria;
                int idExperiencia = experienciaComboBox.idEE;

                ProblematicaAcademica problematicaAcademicaNueva = new ProblematicaAcademica()
                {
                    descripcion = tbDescripcion.Text,
                    fecha = DateTime.Parse(tbFecha.Text),
                };

                registrarProblematicaAcademica(problematicaAcademicaNueva, idCategoria, idExperiencia);                      
            }
        }

        private void btnCancelar_Click(object sender, RoutedEventArgs e)
        {
            if (UtilidadesFrontEnd.mostrarCuadroConfirmacion("¿Desea cancelar la operación?", "Cancelar Operacion"))
            {
                cerrarVentana();
            }
        }
        public void inicializarVentana(int rolAcademico, int idAcademico)
        {
            tbIdRolAcademico.Text = rolAcademico.ToString();
            tbIdAcademico.Text = idAcademico.ToString();
            tbFecha.Text = DateTime.Now.ToString();
            inicializarComboBox();
        }

        private async void inicializarComboBox()
        {
            cbEstudiante.Items.Add("Seleccionar estudiante");
            cbCategoria.Items.Add("Seleccionar categoria");
            cbExperienciaEducativa.Items.Add("Seleccionar experiencia educativa");

            int idAcademico = int.Parse(tbIdAcademico.Text.Trim());
            using (var conexionServicios = new Service1Client())
            {
                Estudiante[] estudiantes = await conexionServicios.obtenerEstudiantesPorIdAcademicoAsync(idAcademico);
                foreach(Estudiante estudiante in estudiantes)
                {
                    cbEstudiante.Items.Add(estudiante);
                }

                ExperienciaEducativa[] experiencias = await conexionServicios.obtenerExperienciasEducativasPorIdPeriodoEscolarAsync(1);
                foreach(ExperienciaEducativa experiencia in experiencias)
                {
                    cbExperienciaEducativa.Items.Add(experiencia);
                }

                CategoriaProblematica[] categorias = await conexionServicios.obtenerCategoriasProblematicasAsync();
                foreach(CategoriaProblematica categoria in categorias)
                {
                    cbCategoria.Items.Add(categoria);
                }
            }

            cbEstudiante.SelectedIndex = 0;
            cbCategoria.SelectedIndex = 0;
            cbExperienciaEducativa.SelectedIndex = 0;
        }

        private void cerrarVentana()
        {
            SeguimientoProblematicas seguimientoProblematicas = new SeguimientoProblematicas();
            seguimientoProblematicas.inicializarVentana(int.Parse(tbIdRolAcademico.Text), int.Parse(tbIdAcademico.Text));
            seguimientoProblematicas.Show();
            this.Close();
        }

        private bool hayCamposValidos()
        {
            bool camposValidos = true;

            limpiarCampos();

            if (string.IsNullOrEmpty(tbDescripcion.Text))
            {
                tbDescripcion.BorderBrush = Brushes.Red;
                lbDescripcionError.Content = "No se puede dejar vacio";
                camposValidos = false;
            }

            if(cbEstudiante.SelectedIndex == 0)
            {
                lbEstudianteError.Content = "Debe seleccionar al estudiante";
                camposValidos = false;
            }

            if(cbCategoria.SelectedIndex == 0)
            {
                lbCategoriaError.Content = "Debe seleccionar la categoria";
                camposValidos = false;
            }

            if(cbExperienciaEducativa.SelectedIndex == 0)
            {
                lbExperienciaEducativaError.Content = "Debe seleccionar la experiencia educativa";
                camposValidos = false;
            }

            return camposValidos;
        }

        private void limpiarCampos()
        {
            tbDescripcion.BorderBrush = new SolidColorBrush(Color.FromRgb(171, 173, 179));
            lbDescripcionError.Content = string.Empty;
            lbCategoriaError.Content = string.Empty;
            lbEstudianteError.Content = string.Empty;
            lbExperienciaEducativaError.Content = string.Empty;
        }

        private async void cbExperienciaEducativa_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if(cbExperienciaEducativa.SelectedIndex != 0)
            {
                ExperienciaEducativa experiencia = (ExperienciaEducativa) cbExperienciaEducativa.SelectedItem;

                try
                {
                    using (var conexionServicios = new Service1Client())
                    {
                        Academico academicoSeleccion = await conexionServicios.obtenerAcademicoPorIdAsync((int)experiencia.idAcademico);
                        tbAcadémico.Text = academicoSeleccion.nombreCompleto;
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show("No hay conexión a la base de datos, intentelo de nuevo mas tarde.", "Error");
                }                
            }
            else
            {
                tbAcadémico.Text = string.Empty;
            }          
        }

        private async void registrarProblematicaAcademica(ProblematicaAcademica problematicaAcademica, int idCategoriaProblematica, int idExperienciaEducativa)
        {
            try
            {
                using (var conexionServicios = new Service1Client())
                {
                    ProblematicaAcademica problematicaAcademicaNueva = new ProblematicaAcademica()
                    {
                        descripcion = problematicaAcademica.descripcion,
                        fecha = problematicaAcademica.fecha,
                    };

                    bool resultadoOperacion = await conexionServicios.registrarProblematicaAcademicaAsync(problematicaAcademicaNueva, idCategoriaProblematica, idExperienciaEducativa);

                    if (resultadoOperacion)
                    {
                        MessageBox.Show("Se ha registrado la problematica académica con éxito.", "Problematica Registrada");
                        cerrarVentana();
                    }
                    else
                    {
                        MessageBox.Show("No se ha podido registrar la problematica académica.", "Problematica No Registrada");
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("No hay conexión a la base de datos, intentelo de nuevo mas tarde.", "Error");
            }
        }
    }
}
