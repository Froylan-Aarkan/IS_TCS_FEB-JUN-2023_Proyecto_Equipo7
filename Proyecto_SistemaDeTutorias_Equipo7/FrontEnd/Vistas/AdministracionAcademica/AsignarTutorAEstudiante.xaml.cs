using FrontEnd.Modelo;
using ReferenciaServicioTutorias;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace FrontEnd.Vistas.AdministracionAcademica
{
    /// <summary>
    /// Lógica de interacción para AsignarTutorAEstudiante.xaml
    /// </summary>
    public partial class AsignarTutorAEstudiante : Window
    {
        public AsignarTutorAEstudiante()
        {
            InitializeComponent();           
        }

        private async void btnAceptar_Click(object sender, RoutedEventArgs e)
        {
            if (validarCampos())
            {
                Academico academicoCb = (Academico) cbAcademicos.SelectedItem;
                Estudiante estudianteDg = (Estudiante) dgEstudiantes.SelectedItem;

                try
                {
                    using (var conexionServicios = new Service1Client())
                    {
                        bool resultadoOperacion = await conexionServicios.asignarAcademicoAEstudianteAsync(academicoCb.idAcademico, estudianteDg.idEstudiante);

                        if (resultadoOperacion)
                        {
                            MessageBox.Show("Se asignó el académico al estudiante con éxito.", "Académico Asignado");
                            inicializarDataGrid();
                        }
                        else
                        {
                            MessageBox.Show("No Se asigno el académico al estudiante.", "Académico No Asignado");
                        }
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show("No hay conexión a la base de datos, intentelo de nuevo mas tarde.", "Error");
                }                
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
            inicializarComboBox();
            inicializarDataGrid();
        }

        private void inicializarDataGrid()
        {
            EstudianteViewModel modeloEstudiante = new EstudianteViewModel();

            if(modeloEstudiante.estudiantesBD != null)
            {
                dgEstudiantes.ItemsSource = modeloEstudiante.estudiantesBD;
            }
            else
            {
                MessageBox.Show("No hay estudiantes regisrados", "Estudiantes no encontrados");
            }
            
        }

        private async void inicializarComboBox()
        {
            cbAcademicos.Items.Add("Seleccionar tutor academico");

            using (var conexionServicios = new Service1Client())
            {
                Academico[] academicos = await conexionServicios.obtenerAcademicosAsync();
                foreach (Academico academico in academicos)
                {
                    cbAcademicos.Items.Add(academico);
                }
            }

            cbAcademicos.SelectedIndex = 0;
        }

        private bool validarCampos()
        {
            bool camposValidos = true;

            limpiarCampos();
            if(cbAcademicos.SelectedIndex == 0)
            {
                lblErrorTutores.Content = "Debe seleccionar un tutor";
                camposValidos = false;
            }
            if(dgEstudiantes.SelectedItem == null)
            {
                lblErrorEstudiantes.Content = "Debe seleccionar un estudiante";
                camposValidos = false;
            }

            return camposValidos;
        }

        private void limpiarCampos()
        {
            lblErrorTutores.Content = string.Empty;
            lblErrorEstudiantes.Content = string.Empty;
        }

        private void cerrarVentana()
        {
            AdministracionAcademica administracionAcademica = new AdministracionAcademica();
            administracionAcademica.inicializarVentana(int.Parse(tbIdRolAcademico.Text), int.Parse(tbIdAcademico.Text));
            administracionAcademica.Show();
            this.Close();
        }
    }
}
