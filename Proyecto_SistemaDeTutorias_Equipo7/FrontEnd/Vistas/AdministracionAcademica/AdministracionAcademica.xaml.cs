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

namespace FrontEnd.Vistas.AdministracionAcademica
{
    /// <summary>
    /// Lógica de interacción para AdministracionAcademica.xaml
    /// </summary>

    /*///////////////////////////////////////////////////////////////////////////////////////////////////////////
-	Autor: Froylan De Jesus Alvarez Rodriguez
-	Descripción: Ventana del menu de la sección de administración académica.
    ///////////////////////////////////////////////////////////////////////////////////////////////////////////*/
    public partial class AdministracionAcademica : Window
    {
        public AdministracionAcademica()
        {
            InitializeComponent();
        }

        private void btnRegistrarAcademico_Click(object sender, RoutedEventArgs e)
        {
            RegistrarAcademico registrarAcademico = new RegistrarAcademico();
            registrarAcademico.inicializarVentana(int.Parse(tbIdRolAcademico.Text), int.Parse(tbIdAcademico.Text));
            registrarAcademico.Show();
            this.Close();
        }

        private void btnRegistrarEstudiante_Click(object sender, RoutedEventArgs e)
        {
            RegistrarEstudiante registrarEstudiante = new RegistrarEstudiante();
            registrarEstudiante.inicializarVentana(int.Parse(tbIdRolAcademico.Text), int.Parse(tbIdAcademico.Text));
            registrarEstudiante.Show();
            this.Close();
        }

        private void btnRegistrarExperienciaEducativa_Click(object sender, RoutedEventArgs e)
        {
            RegistrarExperienciaEducativa registrarExperienciaEducativa = new RegistrarExperienciaEducativa();
            registrarExperienciaEducativa.inicializarVentana(int.Parse(tbIdRolAcademico.Text), int.Parse(tbIdAcademico.Text));
            registrarExperienciaEducativa.Show();
            this.Close();
        }

        private void btnRegistrarProgramaEducativo_Click(object sender, RoutedEventArgs e)
        {
            RegistrarProgramaEducativo registrarProgramaEducativo = new RegistrarProgramaEducativo();
            registrarProgramaEducativo.inicializarVentana(int.Parse(tbIdRolAcademico.Text), int.Parse(tbIdAcademico.Text));
            registrarProgramaEducativo.Show();
            this.Close();
        }

        private void btnAsignarTutor_Click(object sender, RoutedEventArgs e)
        {
            AsignarTutorAEstudiante asignarTutorAEstudiante = new AsignarTutorAEstudiante();
            asignarTutorAEstudiante.inicializarVentana(int.Parse(tbIdRolAcademico.Text), int.Parse(tbIdAcademico.Text));
            asignarTutorAEstudiante.Show();
            this.Close();
        }

        private void btnModificarAsignacionTutor_Click(object sender, RoutedEventArgs e)
        {
            ModificarAsignacionTutor modificarAsignacionTutor = new ModificarAsignacionTutor();
            modificarAsignacionTutor.inicializarVentana(int.Parse(tbIdRolAcademico.Text), int.Parse(tbIdAcademico.Text));
            modificarAsignacionTutor.Show();
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
                    tbIdRolAcademico.Text = rolAcademico.ToString();
                    tbIdAcademico.Text = idAcademico.ToString();

                    break;
                case 2: //Coordinador
                    btnRegistrarAcademico.IsEnabled = false;
                    btnRegistrarAcademico.Visibility = Visibility.Hidden;
                    btnRegistrarEstudiante.IsEnabled = false;
                    btnRegistrarEstudiante.Visibility = Visibility.Hidden;
                    btnRegistrarExperienciaEducativa.IsEnabled = false;
                    btnRegistrarExperienciaEducativa.Visibility = Visibility.Hidden;
                    btnRegistrarProgramaEducativo.IsEnabled = false;
                    btnRegistrarProgramaEducativo.Visibility = Visibility.Hidden;
                    btnAsignarTutor.Margin = new Thickness(0, 138, 0, 0);
                    btnModificarAsignacionTutor.Margin = new Thickness(0, 218, 0, 0);
                    tbIdRolAcademico.Text = rolAcademico.ToString();
                    tbIdAcademico.Text = idAcademico.ToString();

                    break;
                case 3: //Jefe de carrera
                    tbIdRolAcademico.Text = rolAcademico.ToString();
                    tbIdAcademico.Text = idAcademico.ToString();

                    break;
                case 4: //Administrador
                    btnAsignarTutor.IsEnabled = false;
                    btnAsignarTutor.Visibility = Visibility.Hidden;
                    btnModificarAsignacionTutor.IsEnabled = false;
                    btnModificarAsignacionTutor.Visibility = Visibility.Hidden;
                    tbIdRolAcademico.Text = rolAcademico.ToString();
                    tbIdAcademico.Text = idAcademico.ToString();

                    break;

                default:
                    MessageBox.Show("Usuario sin roles.", "Error");
                    break;
            }
        }
    }
}
