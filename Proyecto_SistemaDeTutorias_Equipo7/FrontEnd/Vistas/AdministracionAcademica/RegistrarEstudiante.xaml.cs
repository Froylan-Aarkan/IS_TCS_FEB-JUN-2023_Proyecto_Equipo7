using System;
using System.Collections.Generic;
using System.Linq;
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
using FrontEnd.Vistas.SeguimientoProblematicas;
using ReferenciaServicioTutorias;

namespace FrontEnd.Vistas.AdministracionAcademica
{
    /// <summary>
    /// Lógica de interacción para RegistrarEstudiante.xaml
    /// </summary>

    /*///////////////////////////////////////////////////////////////////////////////////////////////////////////
-	Autor: Johan David Solis Hernandez
-	Descripción: Ventana para registrar a un estudiante dentro del sistema.
    ///////////////////////////////////////////////////////////////////////////////////////////////////////////*/
    public partial class RegistrarEstudiante : Window
    {
        public RegistrarEstudiante()
        {
            InitializeComponent();
        }

        private void btRegistrar_Click(object sender, RoutedEventArgs e)
        {
            if(hayCamposValidos())
            {
                string nombre = tbNombre.Text;
                string matricula = tbMatricula.Text;
                string correoPersonal = tbCorreoPersonal.Text;
                string correoInstitucional = tbCorreoInstitucional.Text;

                if (UtilidadesFrontEnd.mostrarCuadroConfirmacion("¿Desea guardar este estudiante?", "Confirmación"))
                {
                    registrarEstudiante(nombre, matricula, correoPersonal, correoInstitucional);
                }
            }
        }

        private void limpiarCampos()
        {
            lbNombre.Content = string.Empty;
            lbMatricula.Content = string.Empty;
            lbCorreoPersonal.Content = string.Empty;
            lbCorreoInstitucional.Content = string.Empty;
            
            
            tbNombre.BorderBrush = new SolidColorBrush(Color.FromRgb(171, 173, 179));
            tbMatricula.BorderBrush = new SolidColorBrush(Color.FromRgb(171, 173, 179));
            tbCorreoInstitucional.BorderBrush = new SolidColorBrush(Color.FromRgb(171, 173, 179));
            tbCorreoPersonal.BorderBrush = new SolidColorBrush(Color.FromRgb(171, 173, 179));
        }

        private void btRegresar_Click(object sender, RoutedEventArgs e)
        {
            if (UtilidadesFrontEnd.mostrarCuadroConfirmacion("¿Desea cancelar la operación?", "Cancelar Operacion"))
            {
                cerrarVentana();
            }
        }

        private bool hayCamposValidos()
        {
            limpiarCampos();
            bool camposValidos = true;

            if (String.IsNullOrEmpty(tbNombre.Text))
            {
                tbNombre.BorderBrush = Brushes.Red;
                lbNombre.Content = "No se puede dejar vacio.";
                camposValidos = false;
            }

            if (String.IsNullOrEmpty(tbCorreoPersonal.Text))
            {
                tbCorreoPersonal.BorderBrush = Brushes.Red;
                lbCorreoPersonal.Content = "No se puede dejar vacio.";
                camposValidos = false;
            }

            if (String.IsNullOrEmpty(tbCorreoInstitucional.Text))
            {
                tbCorreoInstitucional.BorderBrush = Brushes.Red;
                lbCorreoInstitucional.Content = "No se puede dejar vacio.";
                camposValidos = false;
            }
            else if (!tbCorreoInstitucional.Text.StartsWith("z" + tbMatricula.Text) || !tbCorreoInstitucional.Text.EndsWith("@estudiantes.uv.mx"))
            {
                tbCorreoInstitucional.BorderBrush = Brushes.Red;
                lbCorreoInstitucional.Content = "Debe ser un correo perteneciente a la universidad veracruzana.";
                camposValidos = false;
            }

            if (String.IsNullOrEmpty(tbMatricula.Text))
            {
                tbMatricula.BorderBrush = Brushes.Red;
                lbMatricula.Content = "No se puede dejar vacio.";
                camposValidos = false;
            }
            else if(!tbMatricula.Text.StartsWith("S"))
            {
                tbMatricula.BorderBrush = Brushes.Red;
                lbMatricula.Content = "La matricula debe empezar con la letra S.";
                camposValidos = false;
            }

            return camposValidos;
        }

        private async void registrarEstudiante(string nombreNuevo, string matriculaNuevo, string correoPersonalNuevo, string correoInstitucionalNuevo)
        {
            try
            {
                using (var conexionServicios = new Service1Client())
                {
                    Estudiante estudianteNuevo = new Estudiante()
                    {
                        nombreCompleto = nombreNuevo,
                        matricula = matriculaNuevo,
                        correoPersonal = correoPersonalNuevo,
                        correoInstucional = correoInstitucionalNuevo
                    };
                    bool resultadoOperacion = await conexionServicios.registrarEstudianteAsync(estudianteNuevo);

                    if (resultadoOperacion)
                    {
                        MessageBox.Show("Se ha registrado el estudiante con éxito.", "Estudiante Registrado");
                        tbNombre.Text = string.Empty;
                        tbMatricula.Text = string.Empty;
                        tbCorreoPersonal.Text = string.Empty;
                        tbCorreoInstitucional.Text = string.Empty;
                    }
                    else
                    {
                        MessageBox.Show("No se ha podido registrar el estudiante.", "Estudiante No Registrado");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No hay conexión a la base de datos, intentelo de nuevo mas tarde.", "Error");
            }            
        }

        public void inicializarVentana(int rolAcademico, int idAcademico)
        {
            tbIdRolAcademico.Text = rolAcademico.ToString();
            tbIdAcademico.Text = idAcademico.ToString();
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
