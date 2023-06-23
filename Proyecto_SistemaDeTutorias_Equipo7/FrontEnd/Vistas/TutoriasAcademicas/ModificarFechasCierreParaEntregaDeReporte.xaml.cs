using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
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
using ReferenciaServicioTutorias;

namespace FrontEnd.Vistas.TutoriasAcademicas
{
    /// <summary>
    /// Lógica de interacción para ModificarFechasCierreParaEntregaDeReporte.xaml
    /// </summary>
    public partial class ModificarFechasCierreParaEntregaDeReporte : Window
    {
        public ModificarFechasCierreParaEntregaDeReporte()
        {
            InitializeComponent();
        }

        public void inicializarVentana(int rolAcademico, int idAcademico)
        {
            tbIdRolAcademico.Text = rolAcademico.ToString();
            tbIdAcademico.Text = idAcademico.ToString();
            inicializarComboBox();
        }

        private async void inicializarComboBox()
        {
            cbPeriodoEscolar.Items.Add("Seleccionar Periodo Escolar");

            int idAcademico = int.Parse(tbIdAcademico.Text.Trim());

            try
            {
                using (var conexionServicios = new Service1Client())
                {
                    PeriodoEscolar[] periodosEscolares = await conexionServicios.obtenerPeriodosEscolaresAsync();
                    foreach (PeriodoEscolar periodoEscolar in periodosEscolares)
                    {
                        cbPeriodoEscolar.Items.Add(periodoEscolar);
                    }
                }

                cbPeriodoEscolar.SelectedIndex = 0;
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

        private async void modificarFechasCierre(int numSesionUno, DateTime fechaSesionUno, int numSesionDos, DateTime fechaSesionDos, int numSesionTres, DateTime fechaSesionTres)
        {
            PeriodoEscolar periodoEscolarCb = (PeriodoEscolar)cbPeriodoEscolar.SelectedItem;

            SesionTutoria[] sesionesTutoria =
            {
                new SesionTutoria()
                {
                    numSesion = numSesionUno,
                    fechaLimite = fechaSesionUno
                },
                new SesionTutoria()
                {
                    numSesion = numSesionDos,
                    fechaLimite = fechaSesionDos
                },
                new SesionTutoria()
                {
                    numSesion = numSesionTres,
                    fechaLimite = fechaSesionTres
                }
            };

            try
            {
                using (var conexionServicios = new Service1Client())
                {
                    if (sesionesTutoria != null)
                    {
                        bool resultadoOperacion = await conexionServicios.registrarFechasCierreParaEntregaAsync(sesionesTutoria, periodoEscolarCb.idPeriodoEscolar);

                        if (resultadoOperacion)
                        {
                            MessageBox.Show("Se ha modificado la fecha de cierre para entrega de reporte con éxito.", "Fecha de Cierre Para Entrega de Reporte Modificada");
                            tbFechaUno.Text = string.Empty;
                            tbFechaDos.Text = string.Empty;
                            tbFechaTres.Text = string.Empty;
                        }
                        else
                        {
                            MessageBox.Show("No se ha podido modificar la fecha de cierre para entrega de reporte.", "Fecha de Cierre Para Entrega de Reporte No Modificada");
                        }
                    }
                    else
                    {
                        MessageBox.Show("No se ha podido modificar la fecha de cierre para entrega de reporte.", "Fecha de Cierre Para Entrega de Reporte No Modificada");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No hay conexión a la base de datos, intentelo de nuevo mas tarde.", "Error");
            }            
        }

        private bool hayCamposValidos()
        {
            limpiarCampos();
            bool camposValidos = true;
            DateTime resultado;

            if (String.IsNullOrEmpty(tbFechaUno.Text))
            {
                tbFechaUno.BorderBrush = Brushes.Red;
                lbFechaUno.Content = "No se puede dejar vacio.";
                camposValidos = false;
            }
            else if (!DateTime.TryParse(tbFechaUno.Text, out resultado))
            {
                tbFechaUno.BorderBrush = Brushes.Red;
                lbFechaUno.Content = "Campos invalidos";
                camposValidos = false;
            }

            if (String.IsNullOrEmpty(tbFechaDos.Text))
            {
                tbFechaDos.BorderBrush = Brushes.Red;
                lbFechaDos.Content = "No se puede dejar vacio.";
                camposValidos = false;
            }
            else if (!DateTime.TryParse(tbFechaDos.Text, out resultado))
            {
                tbFechaDos.BorderBrush = Brushes.Red;
                lbFechaDos.Content = "Campos invalidos";
                camposValidos = false;
            }

            if (String.IsNullOrEmpty(tbFechaTres.Text))
            {
                tbFechaTres.BorderBrush = Brushes.Red;
                lbFechaTres.Content = "No se puede dejar vacio.";
                camposValidos = false;
            }
            else if (!DateTime.TryParse(tbFechaTres.Text, out resultado))
            {
                tbFechaTres.BorderBrush = Brushes.Red;
                lbFechaTres.Content = "Campos invalidos";
                camposValidos = false;
            }

            if (cbPeriodoEscolar.SelectedIndex == 0)
            {
                lbPeriodoEscolar.Content = "Debe seleccionar un periodo escolar.";
                camposValidos = false;
            }

            return camposValidos;
        }

        private void limpiarCampos()
        {
            lbFechaUno.Content = string.Empty;
            lbFechaDos.Content = string.Empty;
            lbPeriodoEscolar.Content = string.Empty;
            lbFechaTres.Content = string.Empty;

            tbFechaUno.BorderBrush = new SolidColorBrush(Color.FromRgb(171, 173, 179));
            tbFechaDos.BorderBrush = new SolidColorBrush(Color.FromRgb(171, 173, 179));
            tbFechaTres.BorderBrush = new SolidColorBrush(Color.FromRgb(171, 173, 179));
            cbPeriodoEscolar.BorderBrush = new SolidColorBrush(Color.FromRgb(171, 173, 179));

        }

        private void btRegistrar_Click(object sender, RoutedEventArgs e)
        {
            if (hayCamposValidos())
            {
                int numSesionUno = int.Parse(tbNumeroSesionUno.Text);
                DateTime fechaCierreUno = DateTime.Parse(tbFechaUno.Text);

                int numSesionDos = int.Parse(tbNumeroSesionDos.Text);
                DateTime fechaCierreDos = DateTime.Parse(tbFechaDos.Text);

                int numSesionTres = int.Parse(tbNumeroSesionTres.Text);
                DateTime fechaCierreTres = DateTime.Parse(tbFechaTres.Text);

                if (UtilidadesFrontEnd.mostrarCuadroConfirmacion("¿Desea modificar estas fechas de cierre para entrega de reporte?", "Confirmación"))
                {
                    modificarFechasCierre(numSesionUno, fechaCierreUno, numSesionDos, fechaCierreDos, numSesionTres, fechaCierreTres);
                }
            }
        }

        private void btRegresar_Click(object sender, RoutedEventArgs e)
        {
            if (UtilidadesFrontEnd.mostrarCuadroConfirmacion("¿Desea cancelar la operación?", "Cancelar Operacion"))
            {
                cerrarVentana();
            }
        }

        private async void cbPeriodoEscolar_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (cbPeriodoEscolar.SelectedIndex > 0)
            {
                PeriodoEscolar periodo = (PeriodoEscolar) cbPeriodoEscolar.SelectedItem;
                var conexionServicios = new Service1Client(); 
                try
                {
                    using (conexionServicios = new Service1Client())
                    {
                        SesionTutoria[] sesionTutoriaSeleccion = await conexionServicios.obtenerSesionTutoriaPorIdPeriodoEscolarAsync(periodo.idPeriodoEscolar);
                        if (sesionTutoriaSeleccion != null && sesionTutoriaSeleccion.Length == 3)
                        {
                            tbFechaUno.Text = sesionTutoriaSeleccion[0].fechaLimite.ToString();
                            tbFechaDos.Text = sesionTutoriaSeleccion[1].fechaLimite.ToString();
                            tbFechaTres.Text = sesionTutoriaSeleccion[2].fechaLimite.ToString();
                        }
                        else
                        {
                            MessageBox.Show("No se encontraron fechas se cierre para entrega del reporte", "Fechas de cierre no encontradas");
                        }
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show("No hay conexión a la base de datos, intentelo de nuevo mas tarde.", "Error");
                }                
            }
            else
            {
                tbFechaUno.Text = string.Empty;
                tbFechaDos.Text = string.Empty;
                tbFechaTres.Text = string.Empty;
            }
        }
    }
}
