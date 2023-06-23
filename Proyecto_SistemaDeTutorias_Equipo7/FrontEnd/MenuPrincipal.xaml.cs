using FrontEnd.Vistas.AdministracionAcademica;
using FrontEnd.Vistas.SeguimientoProblematicas;
using FrontEnd.Vistas.TutoriasAcademicas;
using FrontEnd_SistemaDeTutorias;
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

namespace FrontEnd
{
    /// <summary>
    /// Lógica de interacción para MenuPrincipal.xaml
    /// </summary>

    /*///////////////////////////////////////////////////////////////////////////////////////////////////////////
-	Autor: Froylan De Jesus Alvarez Rodriguez
-	Descripción: ventana del menu principal del sistema.
    ///////////////////////////////////////////////////////////////////////////////////////////////////////////*/
    public partial class MenuPrincipal : Window
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void btnTutorias_Click(object sender, RoutedEventArgs e)
        {
            TutoriasAcademicas tutoriasAcademicas = new TutoriasAcademicas();
            tutoriasAcademicas.inicializarVentana(int.Parse(tbIdRolAcademico.Text), int.Parse(tbIdAcademico.Text));
            tutoriasAcademicas.Show();
            this.Close();
        }

        private void btnProblematicas_Click(object sender, RoutedEventArgs e)
        {
            SeguimientoProblematicas seguimientoProblematicas = new SeguimientoProblematicas();
            seguimientoProblematicas.inicializarVentana(int.Parse(tbIdRolAcademico.Text), int.Parse(tbIdAcademico.Text));
            seguimientoProblematicas.Show();
            this.Close();
        }

        private void btnAdministracion_Click(object sender, RoutedEventArgs e)
        {
            AdministracionAcademica administracionAcademica = new AdministracionAcademica();
            administracionAcademica.inicializarVentana(int.Parse(tbIdRolAcademico.Text), int.Parse(tbIdAcademico.Text));
            administracionAcademica.Show();
            this.Close();
        }

        private void btnCerrarSesion_Click(object sender, RoutedEventArgs e)
        {
            InicioSesion inicioSesion = new InicioSesion();
            inicioSesion.Show();
            this.Close();
        }

        public void inicializarVentana(AcademicoRolAcademico rolAcademico)
        {
            switch (rolAcademico.idRolAcademico)
            {
                case 1: //Tutor
                    btnAdministracion.IsEnabled = false;
                    btnAdministracion.Visibility = Visibility.Hidden;
                    tbIdRolAcademico.Text = rolAcademico.idRolAcademico.ToString();
                    tbIdAcademico.Text = rolAcademico.idAcademico.ToString();

                    break;
                case 2: //Coordinador
                    tbIdRolAcademico.Text = rolAcademico.idRolAcademico.ToString();
                    tbIdAcademico.Text = rolAcademico.idAcademico.ToString();

                    break;
                case 3: //Jefe de carrera
                    btnAdministracion.IsEnabled = false;
                    btnAdministracion.Visibility = Visibility.Hidden;
                    tbIdRolAcademico.Text = rolAcademico.idRolAcademico.ToString();
                    tbIdAcademico.Text = rolAcademico.idAcademico.ToString();

                    break;
                case 4: //Administrador
                    tbIdRolAcademico.Text = rolAcademico.idRolAcademico.ToString();
                    tbIdAcademico.Text = rolAcademico.idAcademico.ToString();

                    break;

                default:
                    MessageBox.Show("Usuario sin roles.", "Error");
                    break;
            }

        }

        public void inicializarVentana(int rolAcademico, int idAcademico)
        {
            switch (rolAcademico)
            {
                case 1: //Tutor
                    btnAdministracion.IsEnabled = false;
                    btnAdministracion.Visibility = Visibility.Hidden;
                    tbIdRolAcademico.Text = rolAcademico.ToString();
                    tbIdAcademico.Text = idAcademico.ToString();

                    break;
                case 2: //Coordinador
                    tbIdRolAcademico.Text = rolAcademico.ToString();
                    tbIdAcademico.Text = idAcademico.ToString();
                    break;
                case 3: //Jefe de carrera
                    btnAdministracion.IsEnabled = false;
                    btnAdministracion.Visibility = Visibility.Hidden;
                    tbIdRolAcademico.Text = rolAcademico.ToString();
                    tbIdAcademico.Text = idAcademico.ToString();

                    break;
                case 4: //Administrador
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
