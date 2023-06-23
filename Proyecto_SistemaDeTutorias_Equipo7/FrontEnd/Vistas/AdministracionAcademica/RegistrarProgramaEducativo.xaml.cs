using Microsoft.Win32;
using System.Windows.Media.Imaging;
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
using System.Windows.Shapes;
using ReferenciaServicioTutorias;
using System.IO;

namespace FrontEnd.Vistas.AdministracionAcademica
{
    /// <summary>
    /// Lógica de interacción para RegistrarProgramaEducativo.xaml
    /// </summary>
    public partial class RegistrarProgramaEducativo : Window
    {
        public RegistrarProgramaEducativo()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, RoutedEventArgs e)
        {
            if (hayCamposValidos())
            {
                registrarProgramaEducativo(tbProgramaEducativo.Text);
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
        }

        private bool hayCamposValidos()
        {
            limpiarCampos();
            bool camposValidos = true;

            if(String.IsNullOrEmpty(tbProgramaEducativo.Text))
            {
                lbProgramaEducativoError.Content = "No se puede dejar vacio";
                tbProgramaEducativo.BorderBrush = Brushes.Red;
                camposValidos = false;
            }

            return camposValidos;
        }

        private void limpiarCampos()
        {
            lbProgramaEducativoError.Content = string.Empty;
            tbProgramaEducativo.BorderBrush = new SolidColorBrush(Color.FromRgb(171, 173, 179));
        }

        private void cerrarVentana()
        {
            AdministracionAcademica administracionAcademica = new AdministracionAcademica();
            administracionAcademica.inicializarVentana(int.Parse(tbIdRolAcademico.Text), int.Parse(tbIdAcademico.Text));
            administracionAcademica.Show();
            this.Close();
        }

        private async void registrarProgramaEducativo(string nombreProgramaEducativo)
        {
            try
            {
                using (var conexionServicios = new Service1Client())
                {
                    ProgramaEducativo programaEducativo = new ProgramaEducativo()
                    {
                        nombre = nombreProgramaEducativo
                    };

                    bool resultadoOperacion = await conexionServicios.registrarProgramaEducativoAsync(programaEducativo);

                    if (resultadoOperacion)
                    {
                        MessageBox.Show("Se registró el programa educativo con éxito.", "Programa Educativo Registrado");
                        cerrarVentana();
                    }
                    else
                    {
                        MessageBox.Show("No se registró el programa educativo.", "Programa Educativo No Registrado");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No hay conexión a la base de datos, intentelo de nuevo mas tarde.", "Error");
            }           
        }
    }
}
