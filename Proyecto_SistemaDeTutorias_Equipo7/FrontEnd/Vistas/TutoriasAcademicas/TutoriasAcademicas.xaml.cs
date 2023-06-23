using ReferenciaServicioTutorias;
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

namespace FrontEnd.Vistas.TutoriasAcademicas
{
    /// <summary>
    /// Lógica de interacción para TutoriasAcademicas.xaml
    /// </summary>
    public partial class TutoriasAcademicas : Window
    {        
        public TutoriasAcademicas()
        {
            InitializeComponent();
        }

        private void btnRegistrarComentariosGenerales_Click(object sender, RoutedEventArgs e)
        {
            RegistrarComentarioGeneral registrarComentarioGeneral = new RegistrarComentarioGeneral();
            registrarComentarioGeneral.inicializarVentana(int.Parse(tbIdRolAcademico.Text), int.Parse(tbIdAcademico.Text));
            registrarComentarioGeneral.Show();
            this.Close();
        }

        private void btnRegistrarReporte_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnRegistrarFechasSesion_Click(object sender, RoutedEventArgs e)
        {
            RegistrarFechasSesionTutoria registrarFechasSesionTutoria = new RegistrarFechasSesionTutoria();
            registrarFechasSesionTutoria.inicializarVentana(int.Parse(tbIdRolAcademico.Text), int.Parse(tbIdAcademico.Text));
            registrarFechasSesionTutoria.Show();
            this.Close();
        }

        private void btnRegistrarFechasCierre_Click(object sender, RoutedEventArgs e)
        {
            RegistrarFechasCierreParaEntregaDeReporte registrarFechasCierreParaEntregaDeReporte = new RegistrarFechasCierreParaEntregaDeReporte();
            registrarFechasCierreParaEntregaDeReporte.inicializarVentana(int.Parse(tbIdRolAcademico.Text), int.Parse(tbIdAcademico.Text));
            registrarFechasCierreParaEntregaDeReporte.Show();
            this.Close();
        }

        private void btnRegistrarHorarioSesion_Click(object sender, RoutedEventArgs e)
        {
            RegistrarHorarioSesion registrarHorarioSesion = new RegistrarHorarioSesion();
            registrarHorarioSesion.inicializarVentana(int.Parse(tbIdRolAcademico.Text), int.Parse(tbIdAcademico.Text));
            registrarHorarioSesion.Show();
            this.Close();
        }

        private void btnModificarFechasCierre_Click(object sender, RoutedEventArgs e)
        {
            ModificarFechasCierreParaEntregaDeReporte modificarFechasCierreParaEntregaDeReporte = new ModificarFechasCierreParaEntregaDeReporte();
            modificarFechasCierreParaEntregaDeReporte.inicializarVentana(int.Parse(tbIdRolAcademico.Text), int.Parse(tbIdAcademico.Text));
            modificarFechasCierreParaEntregaDeReporte.Show();
            this.Close();
        }

        private void btnRegresar_Click(object sender, RoutedEventArgs e)
        {
            MenuPrincipal menuPrincipal = new MenuPrincipal();
            menuPrincipal.inicializarVentana(int.Parse(tbIdRolAcademico.Text), int.Parse(tbIdAcademico.Text));
            menuPrincipal.Show();
            this.Close();
        }

        public void inicializarVentana(int rolAcademico, int idAcademico)
        {
            switch (rolAcademico)
            {
                case 1: //Tutor
                    btnRegistrarFechasSesion.IsEnabled = false;
                    btnRegistrarFechasSesion.Visibility = Visibility.Hidden;
                    btnRegistrarFechasCierre.IsEnabled = false;
                    btnRegistrarFechasCierre.Visibility = Visibility.Hidden;
                    btnModificarFechasCierre.IsEnabled = false;
                    btnModificarFechasCierre.Visibility = Visibility.Hidden;
                    btnRegistrarHorarioSesion.Margin = new Thickness(0, 209, 0, 0);

                    break;
                case 2: //Coordinador


                    break;
                case 3: //Jefe de carrera
                    btnRegistrarFechasSesion.IsEnabled = false;
                    btnRegistrarFechasSesion.Visibility = Visibility.Hidden;
                    btnRegistrarFechasCierre.IsEnabled = false;
                    btnRegistrarFechasCierre.Visibility = Visibility.Hidden;
                    btnModificarFechasCierre.IsEnabled = false;
                    btnModificarFechasCierre.Visibility = Visibility.Hidden;
                    btnRegistrarHorarioSesion.Margin = new Thickness(0, 209, 0, 0);

                    break;
                case 4: //Administrador
                    btnRegistrarFechasSesion.IsEnabled = false;
                    btnRegistrarFechasSesion.Visibility = Visibility.Hidden;
                    btnRegistrarFechasCierre.IsEnabled = false;
                    btnRegistrarFechasCierre.Visibility = Visibility.Hidden;
                    btnModificarFechasCierre.IsEnabled = false;
                    btnModificarFechasCierre.Visibility = Visibility.Hidden;
                    btnRegistrarHorarioSesion.Margin = new Thickness(0, 209, 0, 0);
                    

                    break;
                default:
                    MessageBox.Show("Usuario sin roles.", "Error");
                    break;
            }

            tbIdRolAcademico.Text = rolAcademico.ToString();
            tbIdAcademico.Text = idAcademico.ToString();
        }
    }
}
