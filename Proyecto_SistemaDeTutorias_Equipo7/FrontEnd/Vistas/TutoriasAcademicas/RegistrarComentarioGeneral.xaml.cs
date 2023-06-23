using FrontEnd.Vistas.AdministracionAcademica;
using ReferenciaServicioTutorias;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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
    /// Lógica de interacción para RegistrarComentarioGeneral.xaml
    /// </summary>
    public partial class RegistrarComentarioGeneral : Window
    {
        public RegistrarComentarioGeneral()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, RoutedEventArgs e)
        {
            if (hayCamposValidos())
            {
                ComentarioGeneral comentarioGeneralNuevo = new ComentarioGeneral()
                {
                    fecha = DateTime.Parse(tbFecha.Text),
                    descripcion = tbDescripcion.Text,

                };

                registrarComentarioGeneral(comentarioGeneralNuevo);
            }
        }

        private void btnCancelar_Click(object sender, RoutedEventArgs e)
        {
            if(UtilidadesFrontEnd.mostrarCuadroConfirmacion("¿Desea cancelar la operación?", "Cancelar Operacion"))
            {
                cerrarVentana();
            }
        }

        public void inicializarVentana(int rolAcademico, int idAcademico)
        {
            tbIdRolAcademico.Text = rolAcademico.ToString();
            tbIdAcademico.Text = idAcademico.ToString();
            tbFecha.Text = DateTime.Now.ToString();
        }

        private bool hayCamposValidos()
        {
            lbDescripcionError.Content = string.Empty;
            tbDescripcion.BorderBrush = new SolidColorBrush(Color.FromRgb(171, 173, 179));

            if (String.IsNullOrEmpty(tbDescripcion.Text))
            {
                tbDescripcion.BorderBrush = Brushes.Red;
                lbDescripcionError.Content = "No se puede dejar vacio.";
                return false;
            }

            return true;
        }

        private async void registrarComentarioGeneral(ComentarioGeneral comentarioGeneralNuevo)
        {
            try
            {
                using (var conexionServicios = new Service1Client())
                {
                    bool resultadoOperacion = await conexionServicios.registrarComentarioGeneralAsync(comentarioGeneralNuevo);

                    if (resultadoOperacion)
                    {
                        MessageBox.Show("Se ha registrado el comentario general con éxito.", "Comentario Registrado");
                        cerrarVentana();

                    }
                    else
                    {
                        MessageBox.Show("No se ha podido registrar el comentario general.", "Comentario No Registrado");
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
            TutoriasAcademicas tutoriasAcademicas = new TutoriasAcademicas();
            tutoriasAcademicas.inicializarVentana(int.Parse(tbIdRolAcademico.Text), int.Parse(tbIdAcademico.Text));
            tutoriasAcademicas.Show();
            this.Close();
        }
    }
}
