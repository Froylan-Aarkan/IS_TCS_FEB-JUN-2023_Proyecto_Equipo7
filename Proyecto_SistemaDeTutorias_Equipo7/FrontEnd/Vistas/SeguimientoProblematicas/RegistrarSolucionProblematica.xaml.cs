using FrontEnd.Modelo;
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
    /// Lógica de interacción para RegistrarSolucionProblematica.xaml
    /// </summary>
    public partial class RegistrarSolucionProblematica : Window
    {
        public RegistrarSolucionProblematica()
        {
            InitializeComponent();
            
        }

        private void BtnRegresar_Click(object sender, RoutedEventArgs e)
        {
            cerrarVentana();
        }

        private async void btnConsultar_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if(dgProblematicasAcademicas.SelectedCells.Count > 0)
                {
                    ProblematicaAcademica problematicaAcademicaSeleccionada = (ProblematicaAcademica) dgProblematicasAcademicas.SelectedItem;
                    
                    if(problematicaAcademicaSeleccionada != null)
                    {
                        using (var conexionServicios = new Service1Client())
                        {
                            ProblematicaAcademica problematicaAcademicaValidacion = await conexionServicios.problematicaConSolucionAsync(problematicaAcademicaSeleccionada.idProblematicaACademica);

                            if(problematicaAcademicaValidacion == null)
                            {
                                ExperienciaEducativa experienciaEducativa = await conexionServicios.obtenerExperienciaEducativaPorIdAsync((int)problematicaAcademicaSeleccionada.idEE);

                                Academico academico = await conexionServicios.obtenerAcademicoPorIdAsync((int)experienciaEducativa.idAcademico);

                                SolucionProblematica solucionProblematica = new SolucionProblematica();
                                solucionProblematica.inicializarVentana(int.Parse(tbIdRolAcademico.Text), int.Parse(tbIdAcademico.Text), problematicaAcademicaSeleccionada.idProblematicaACademica, problematicaAcademicaSeleccionada.descripcion, experienciaEducativa.nombre, academico.nombreCompleto);
                                solucionProblematica.Show();
                                this.Close();
                            }                      
                        }                     
                    }
                }
                else
                {
                    MessageBox.Show("Debe seleccionar una problematica", "Atención");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("No hay conexión a la base de datos, intentelo de nuevo mas tarde.", "Error");
            }
            
        }

        public void inicializarVentana(int rolAcademico, int idAcademico)
        {
            tbIdRolAcademico.Text = rolAcademico.ToString();
            tbIdAcademico.Text = idAcademico.ToString();
            inicializarDataGrid();
        }

        private void inicializarDataGrid()
        {
            ProblematicaAcademicaViewModel modelo = new ProblematicaAcademicaViewModel();
            dgProblematicasAcademicas.ItemsSource = modelo.problematicasBD;
        }

        private void cerrarVentana()
        {
            SeguimientoProblematicas seguimientoProblematicas = new SeguimientoProblematicas();
            seguimientoProblematicas.inicializarVentana(int.Parse(tbIdRolAcademico.Text), int.Parse(tbIdAcademico.Text));
            seguimientoProblematicas.Show();
            this.Close();
        }
    }
}
