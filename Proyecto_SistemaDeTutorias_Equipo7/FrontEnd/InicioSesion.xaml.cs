using FrontEnd;
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

namespace FrontEnd_SistemaDeTutorias
{
    /// <summary>
    /// Lógica de interacción para InicioSesion.xaml
    /// </summary>

    /*///////////////////////////////////////////////////////////////////////////////////////////////////////////
-	Autor: Froylan De Jesus Alvarez Rodriguez
-	Descripción: Ventana de inicio de sesión para ingresar al sistema.
    ///////////////////////////////////////////////////////////////////////////////////////////////////////////*/

    public partial class InicioSesion : Window
    {
        public InicioSesion()
        {
            InitializeComponent();
        }

        private void btnIniciarSesion_Click(object sender, RoutedEventArgs e)
        {
            if (!String.IsNullOrEmpty(tbUsuario.Text) && !String.IsNullOrEmpty(pbContrasenia.Password))
            {
                verificarInicioSesion(tbUsuario.Text, pbContrasenia.Password);
            }
            else
            {
                MessageBox.Show("Usuario y/o contraseña requeridos.");
            }
        }

        private async void verificarInicioSesion(string correoInstitucional, string contrasenia)
        {
            try
            {
                using (var conexionServicios = new Service1Client())
                {
                    MensajeInicioSesion resultado = await conexionServicios.iniciarSesionAsync(correoInstitucional, contrasenia);
                    if (resultado.error == false)
                    {
                        MessageBox.Show(resultado.mensaje, "Usuario verificado");

                        AcademicoRolAcademico rolAcademico = await conexionServicios.obtenerRolAcademicoAsync(resultado.academico.idAcademico);

                        if (rolAcademico != null)
                        {
                            MenuPrincipal menuPrincipal = new MenuPrincipal();
                            menuPrincipal.inicializarVentana(rolAcademico);
                            menuPrincipal.Show();
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Este usuario no cuenta con ningun rol.", "Error");
                        }

                    }
                    else
                    {
                        MessageBox.Show(resultado.mensaje, "Error.");
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
