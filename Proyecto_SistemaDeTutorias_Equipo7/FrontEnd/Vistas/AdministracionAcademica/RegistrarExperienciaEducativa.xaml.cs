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
using ReferenciaServicioTutorias;

namespace FrontEnd.Vistas.AdministracionAcademica
{
    /// <summary>
    /// Lógica de interacción para RegistrarExperienciaEducativa.xaml
    /// </summary>

    /*///////////////////////////////////////////////////////////////////////////////////////////////////////////
-	Autor: Johan David Solis Hernandez
-	Descripción: Ventana para registrar una nueva experiencia educativa dentro del sistema.
    ///////////////////////////////////////////////////////////////////////////////////////////////////////////*/
    public partial class RegistrarExperienciaEducativa : Window
    {
        public RegistrarExperienciaEducativa()
        {
            InitializeComponent();
        }

        private void btRegistrar_Click(object sender, RoutedEventArgs e)
        {
            if (hayCamposValidos())
            { 
                int nrc = int.Parse(tbNrc.Text);

                if (UtilidadesFrontEnd.mostrarCuadroConfirmacion("¿Desea guardar esta experiencia educativa?", "Confirmación"))
                {
                    registrarExperienciaEducativa(nrc);
                }
            }
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
            cbProgramaEducativo.Items.Add("Seleccionar Programa Educativo");

            int idAcademico = int.Parse(tbIdAcademico.Text.Trim());
            try
            {
                using (var conexionServicios = new Service1Client())
                {
                    ProgramaEducativo[] programasEducativos = await conexionServicios.obtenerProgramasEducativosAsync();
                    foreach (ProgramaEducativo programaEducativo in programasEducativos)
                    {
                        cbProgramaEducativo.Items.Add(programaEducativo);
                    }

                    PeriodoEscolar[] periodosEscolares = await conexionServicios.obtenerPeriodosEscolaresAsync();
                    foreach (PeriodoEscolar periodoEscolar in periodosEscolares)
                    {
                        cbPeriodoEscolar.Items.Add(periodoEscolar);
                    }
                }

                cbPeriodoEscolar.SelectedIndex = 0;
                cbProgramaEducativo.SelectedIndex = 0;
                cbNombre.SelectedIndex = 0;
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

        private void btRegresar_Click(object sender, RoutedEventArgs e)
        {
            if (UtilidadesFrontEnd.mostrarCuadroConfirmacion("¿Desea cancelar la operación?", "Cancelar Operacion"))
            {
                cerrarVentana();
            }
        }

        private async void registrarExperienciaEducativa(int nrcNuevo)
        {
            PeriodoEscolar periodoEscolarCb = (PeriodoEscolar)cbPeriodoEscolar.SelectedItem;
            ProgramaEducativo programaEducativoCb = (ProgramaEducativo)cbProgramaEducativo.SelectedItem;
            ExperienciaEducativa experienciaEducartivaCb = (ExperienciaEducativa)cbNombre.SelectedItem;

            try
            {
                using (var conexionServicios = new Service1Client())
                {
                    ExperienciaEducativa experienciaEducativaNueva = new ExperienciaEducativa()
                    {
                        nombre = experienciaEducartivaCb.nombre,
                        nrc = nrcNuevo
                    };
                    bool resultadoOperacion = await conexionServicios.registrarExperienciaEducativaAsync(experienciaEducativaNueva, programaEducativoCb.idProgramaEducativo, periodoEscolarCb.idPeriodoEscolar);

                    if (resultadoOperacion)
                    {
                        MessageBox.Show("Se ha registrado la experiencia educativa con éxito.", "Experiencia Educativa Registrado");
                        tbNrc.Text = string.Empty;
                        cbPeriodoEscolar.SelectedIndex = 0;
                        cbProgramaEducativo.SelectedIndex = 0;
                        cbNombre.Items.Clear();
                    }
                    else
                    {
                        MessageBox.Show("No se ha podido registrar la experiencia educativa.", "Experiencia Educativa No Registrado");
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("No hay conexión a la base de datos, intentelo de nuevo mas tarde.", "Error");
            }            
        }

        private bool hayCamposValidos()
        {
            limpiarCampos();
            bool camposValidos = true;
            int resultado = 0;

            if (String.IsNullOrEmpty(tbNrc.Text))
            {
                tbNrc.BorderBrush = Brushes.Red;
                lbNrc.Content = "No se puede dejar vacio.";
                camposValidos = false;
            } else if (!int.TryParse(tbNrc.Text, out resultado))
            {
                tbNrc.BorderBrush = Brushes.Red;
                lbNrc.Content = "Campos invalidos";
                camposValidos = false;
            }

            if (cbPeriodoEscolar.Text == "Seleccionar Periodo Escolar")
            {
                lbPeriodoEscolar.Content = "Debe seleccionar un periodo escolar.";
                camposValidos = false;
            }

            if (cbProgramaEducativo.Text == "Seleccionar Programa Educativo")
            {
                lbProgramaEducativo.Content = "Debe seleccionar un programa educativo.";
                camposValidos = false;
            }

            if(cbNombre.Text == "Seleccionar Experiencia Educativa")
            {
                lbNombre.Content = "Debe seleccionar una experiencia educativa";
                camposValidos = false;
            }

            return camposValidos;
        }

        private void limpiarCampos()
        {
            lbNombre.Content = string.Empty;
            lbNrc.Content = string.Empty;
            lbPeriodoEscolar.Content = string.Empty;
            lbProgramaEducativo.Content = string.Empty;

            
            tbNrc.BorderBrush = new SolidColorBrush(Color.FromRgb(171, 173, 179));
            cbNombre.BorderBrush = new SolidColorBrush(Color.FromRgb(171, 173, 179));
            cbPeriodoEscolar.BorderBrush = new SolidColorBrush(Color.FromRgb(171, 173, 179));
            cbProgramaEducativo.BorderBrush = new SolidColorBrush(Color.FromRgb(171, 173, 179));
        }

        private async void cbProgramaEducativo_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (cbProgramaEducativo.SelectedIndex > 0)
            {
                ProgramaEducativo programaE = (ProgramaEducativo)cbProgramaEducativo.SelectedItem;
                try
                {
                    using (var conexionServicios = new Service1Client())
                    {
                        ExperienciaEducativa[] experienciaEducativaSeleccion = await conexionServicios.obtenerExperienciasEducativasPorIdProgramaEducativoAsync(programaE.idProgramaEducativo);
                        if (experienciaEducativaSeleccion != null)
                        {
                            cbNombre.Items.Clear();
                            cbNombre.Items.Add("Seleccionar Experiencia Educativa");
                            foreach (ExperienciaEducativa experienciaEducativa in experienciaEducativaSeleccion)
                            {
                                cbNombre.Items.Add(experienciaEducativa);
                            }
                        }
                        else
                        {
                            MessageBox.Show("No se encontraron experiencias educativas", "Experiencias Educativas no encontradas");
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
                cbNombre.Text = string.Empty;
            }
        }
    }
}
