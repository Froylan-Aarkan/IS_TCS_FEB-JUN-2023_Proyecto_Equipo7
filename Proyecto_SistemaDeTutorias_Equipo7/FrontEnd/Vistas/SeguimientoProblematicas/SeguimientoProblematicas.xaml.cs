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

namespace FrontEnd.Vistas.SeguimientoProblematicas
{
    /// <summary>
    /// Lógica de interacción para SeguimientoProblematicas.xaml
    /// </summary>
    public partial class SeguimientoProblematicas : Window
    {
        public SeguimientoProblematicas()
        {
            InitializeComponent();
        }

        private void btnRegistrarProblematica_Click(object sender, RoutedEventArgs e)
        {
            RegistrarProblematicaAcademica registrarProblematicaAcademica = new RegistrarProblematicaAcademica();
            registrarProblematicaAcademica.inicializarVentana(int.Parse(tbIdRolAcademico.Text), int.Parse(tbIdAcademico.Text));
            registrarProblematicaAcademica.Show();
            this.Close();
        }

        private void btnRegistrarSolucion_Click(object sender, RoutedEventArgs e)
        {
            RegistrarSolucionProblematica registrarSolucionProblematica = new RegistrarSolucionProblematica();
            registrarSolucionProblematica.inicializarVentana(int.Parse(tbIdRolAcademico.Text), int.Parse(tbIdAcademico.Text));
            registrarSolucionProblematica.Show();
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
                    btnRegistrarSolucion.IsEnabled = false;
                    btnRegistrarSolucion.Visibility = Visibility.Hidden;
                    tbIdRolAcademico.Text = rolAcademico.ToString();
                    tbIdAcademico.Text = idAcademico.ToString();

                    break;
                case 2: //Coordinador
                    btnRegistrarSolucion.IsEnabled = false;
                    btnRegistrarSolucion.Visibility = Visibility.Hidden;
                    tbIdRolAcademico.Text = rolAcademico.ToString();
                    tbIdAcademico.Text = idAcademico.ToString();

                    break;
                case 3: //Jefe de carrera
                    tbIdRolAcademico.Text = rolAcademico.ToString();
                    tbIdAcademico.Text = idAcademico.ToString();

                    break;
                case 4: //Administrador
                    btnRegistrarSolucion.IsEnabled = false;
                    btnRegistrarSolucion.Visibility = Visibility.Hidden;
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
