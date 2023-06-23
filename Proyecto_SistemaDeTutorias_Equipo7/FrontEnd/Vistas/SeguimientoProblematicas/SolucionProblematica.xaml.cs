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

namespace FrontEnd.Vistas.SeguimientoProblematicas
{
    /// <summary>
    /// Lógica de interacción para SolucionProblematica.xaml
    /// </summary>

    /*///////////////////////////////////////////////////////////////////////////////////////////////////////////
-	Autor: Froylan De Jesus Alvarez Rodriguez
-	Descripción: Ventana para registrar la solución a la problematica academica seleccionada anteriormente.
    ///////////////////////////////////////////////////////////////////////////////////////////////////////////*/
    public partial class SolucionProblematica : Window
    {
        public SolucionProblematica()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, RoutedEventArgs e)
        {
            if (hayCamposValidos())
            {
                SolucionProblematicaAcademica solucionNueva = new SolucionProblematicaAcademica()
                {
                    fecha = DateTime.Parse(tbFecha.Text),
                    descripcion = tbSolucion.Text,
                };
                registrarSolucion(solucionNueva);
            }
        }

        private void btnCancelar_Click(object sender, RoutedEventArgs e)
        {
            if (UtilidadesFrontEnd.mostrarCuadroConfirmacion("¿Desea cancelar la operación?", "Cancelar Operacion"))
            {
                cerrarVentana();
            }
        }

        private void cerrarVentana()
        {
            SeguimientoProblematicas seguimientoProblematicas = new SeguimientoProblematicas();
            seguimientoProblematicas.inicializarVentana(int.Parse(tbIdRolAcademico.Text), int.Parse(tbIdAcademico.Text));
            seguimientoProblematicas.Show();
            this.Close();
        }

        public void inicializarVentana(int rolAcademico, int idAcademico, int idProblematica, string descripcion, string experienciaEducativa, string profesor)
        {
            tbIdRolAcademico.Text = rolAcademico.ToString();
            tbIdAcademico.Text = idAcademico.ToString();
            tbIdProblematica.Text = idProblematica.ToString();
            tbDescripción.Text = descripcion;
            lbExperienciaEducativaProfesor.Content = "Experiencia Educativa: " + experienciaEducativa + " Profesor: " + profesor;
            tbFecha.Text = DateTime.Now.ToString();
        }

        private bool hayCamposValidos()
        {
            limpiarCampos();
            bool camposValidos = true; 
            
            if(String.IsNullOrEmpty(tbSolucion.Text) )
            {
                tbSolucion.BorderBrush = Brushes.Red;
                lbErrorSolucion.Content = "No se puede dejar vacío";
                camposValidos = false;
            }
            return camposValidos;
        }

        private void limpiarCampos()
        {
            lbErrorSolucion.Content = string.Empty;
            tbSolucion.BorderBrush = new SolidColorBrush(Color.FromRgb(171, 173, 179));
        }

        private async void registrarSolucion(SolucionProblematicaAcademica solucionNueva)
        {
            try
            {
                using (var conexionServicios = new Service1Client())
                {
                    bool resultadoOperacion = await conexionServicios.registrarSolucionProblematicaAcademicaAsync(solucionNueva, int.Parse(tbIdProblematica.Text));

                    if (resultadoOperacion)
                    {
                        MessageBox.Show("Se ha registrado la solucion a la problematica academica con éxito", "Solción registrada");
                        cerrarVentana();
                    }
                    else
                    {
                        MessageBox.Show("No se ha podido registrar la solución", "Solución no registrada");
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
