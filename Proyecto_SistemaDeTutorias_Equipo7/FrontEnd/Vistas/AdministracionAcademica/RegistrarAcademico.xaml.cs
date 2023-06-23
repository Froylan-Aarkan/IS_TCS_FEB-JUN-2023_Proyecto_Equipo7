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

namespace FrontEnd.Vistas.AdministracionAcademica
{
    /// <summary>
    /// Lógica de interacción para RegistrarAcademico.xaml
    /// </summary>

    /*///////////////////////////////////////////////////////////////////////////////////////////////////////////
-	Autor: Froylan De Jesus Alvarez Rodriguez
-	Descripción: Ventana para registrar un académico dentro del sistema.
    ///////////////////////////////////////////////////////////////////////////////////////////////////////////*/
    public partial class RegistrarAcademico : Window
    {
        public RegistrarAcademico()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, RoutedEventArgs e)
        {
            if (hayCamposValidos())
            {
                Academico academicoNuevo = new Academico()
                {
                    nombreCompleto = tbNombreCompleto.Text,
                    correoPersonal = tbCorreoPersonal.Text,
                    correoInstitucional = tbCorreoInstitucional.Text,
                    numPersonal = tbNumeroPersonal.Text,
                    contrasenia = pbContrasenia.Password,
                };
                registrarAcademico(academicoNuevo, cbRolAcademico.Text);
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
        }

        private bool hayCamposValidos()
        {
            limpiarCampos();
            bool camposValidos = true;

            if(String.IsNullOrEmpty(tbNombreCompleto.Text))
            {
                tbNombreCompleto.BorderBrush = Brushes.Red;
                lbNombreCompletoError.Content = "No se puede dejar vacio.";
                camposValidos = false;
            }

            if(String.IsNullOrEmpty(tbCorreoPersonal.Text))
            {
                tbCorreoPersonal.BorderBrush = Brushes.Red;
                lbCorreoPersonalError.Content = "No se puede dejar vacio.";
                camposValidos = false;
            }

            if(String.IsNullOrEmpty(tbCorreoInstitucional.Text))
            {
                tbCorreoInstitucional.BorderBrush = Brushes.Red;
                lbCorreoInstitucionalError.Content = "No se puede dejar vacio.";
                camposValidos = false;
            }
            else if(!tbCorreoInstitucional.Text.EndsWith("@uv.mx"))
            {
                tbCorreoInstitucional.BorderBrush = Brushes.Red;
                lbCorreoInstitucionalError.Content = "Debe ser un correo perteneciente a la universidad veracruzana.";
                camposValidos = false;
            }

            if(String.IsNullOrEmpty(tbNumeroPersonal.Text))
            {
                tbNumeroPersonal.BorderBrush = Brushes.Red;
                lbNumeroPersonalError.Content = "No se puede dejar vacio.";
                camposValidos = false;
            }

            if(String.IsNullOrEmpty(pbContrasenia.Password))
            {
                pbContrasenia.BorderBrush = Brushes.Red;
                lbContraseniaError.Content = "No se puede dejar vacio.";
                camposValidos = false;
            }

            if(cbRolAcademico.Text == "Seleccionar rol academico")
            {
                lbRolAcademicoError.Content = "Debe seleccionar un rol academico.";
                camposValidos = false;
            }
            

            return camposValidos;
        }

        private void limpiarCampos()
        {
            lbNombreCompletoError.Content = string.Empty;
            lbCorreoPersonalError.Content = string.Empty;
            lbCorreoInstitucionalError.Content = string.Empty;
            lbNumeroPersonalError.Content = string.Empty;
            lbContraseniaError.Content = string.Empty;
            lbRolAcademicoError.Content = string.Empty;
            tbNombreCompleto.BorderBrush = new SolidColorBrush(Color.FromRgb(171, 173, 179));
            tbCorreoPersonal.BorderBrush = new SolidColorBrush(Color.FromRgb(171, 173, 179));
            tbCorreoInstitucional.BorderBrush = new SolidColorBrush(Color.FromRgb(171, 173, 179));
            tbNumeroPersonal.BorderBrush = new SolidColorBrush(Color.FromRgb(171, 173, 179));
            pbContrasenia.BorderBrush = new SolidColorBrush(Color.FromRgb(171, 173, 179));
        }

        private async void registrarAcademico(Academico academicoNuevo, string rolAcademico)
        {
            try
            {
                using (var conexionServicios = new Service1Client())
                {
                    bool resultadoOperacion = await conexionServicios.registrarAcademicoAsync(academicoNuevo, rolAcademico);

                    if (resultadoOperacion)
                    {
                        MessageBox.Show("Se ha registrado al académico con éxito.", "Académico Registrado");
                        tbNombreCompleto.Text = string.Empty;
                        tbCorreoPersonal.Text = string.Empty;
                        tbCorreoInstitucional.Text = string.Empty;
                        tbNumeroPersonal.Text = string.Empty;
                        pbContrasenia.Password = string.Empty;
                        cbRolAcademico.SelectedItem = 0;

                    }
                    else
                    {
                        MessageBox.Show("No se ha podido registrar al académico.", "Académico No Registrado");
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("No hay conexión a la base de datos, intentelo de nuevo mas tarde.", "Error");
            }            
        }

        private void cerrarVentana()
        {
            AdministracionAcademica administracionAcademica = new AdministracionAcademica();
            administracionAcademica.inicializarVentana(int.Parse(tbIdRolAcademico.Text), int.Parse(tbIdAcademico.Text));
            administracionAcademica.Show();
            this.Close();
        }

        private void inicializarComboBox()
        {
            cbRolAcademico.Items.Add("Seleccionar rol academico");
            cbRolAcademico.Items.Add("Tutor");
            cbRolAcademico.Items.Add("Coordinador de tutorias");
            cbRolAcademico.Items.Add("Jefe de carrera");
            cbRolAcademico.Items.Add("Administrador");
            cbRolAcademico.SelectedIndex = 0;
        }
    }
}
