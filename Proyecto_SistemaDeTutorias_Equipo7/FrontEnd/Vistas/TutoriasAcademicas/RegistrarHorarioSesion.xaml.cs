using ReferenciaServicioTutorias;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Numerics;
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
    /// Lógica de interacción para RegistrarHorarioSesion.xaml
    /// </summary>

    /*///////////////////////////////////////////////////////////////////////////////////////////////////////////
-	Autor: Froylan De Jesus Alvarez Rodriguez
-	Descripción: Ventana para asignar un horario de sesion de tutoria a los estudiantes del academico actual.
    ///////////////////////////////////////////////////////////////////////////////////////////////////////////*/
    public partial class RegistrarHorarioSesion : Window
    {
        public RegistrarHorarioSesion()
        {
            InitializeComponent();            
        }

        private void btnGuardar_Click(object sender, RoutedEventArgs e)
        {
            if (hayCamposValidos())
            {
 
                string fechaHora = tbFecha.Text.Substring(0,10) + " " + cbHora.Text;

                DateTime fechaExacta = DateTime.Parse(fechaHora);

                SesionTutoria sesionTutoria = new SesionTutoria()
                {
                    idSesionTutoria = int.Parse(tbIdSesionTutoria.Text),
                };

                Estudiante estudianteComboBox = (Estudiante) cbEstudiante.SelectedItem;

                Estudiante estudianteSeleccion = new Estudiante()
                {
                    idEstudiante = estudianteComboBox.idEstudiante,
                };

                registrarHorarioSesion(sesionTutoria, estudianteSeleccion, fechaExacta);         
            }
        }

        private void btnCancelar_Click(object sender, RoutedEventArgs e)
        {
            if (UtilidadesFrontEnd.mostrarCuadroConfirmacion("¿Desea cancelar la operación?", "Cancelar Operacion"))
            {
                cerrarVentana();
            }
        }

        public void inicializarVentana(int idRolAcademico, int idAcademico)
        {
            tbIdRolAcademico.Text = idRolAcademico.ToString();
            tbIdAcademico.Text = idAcademico.ToString();
            inicializarComboBox();
            inicializarTextBox();
        }

        private async void inicializarComboBox()
        {
            cbHora.Items.Add("Seleccionar hora");

            for(int i = 9; i < 21; i++)
            {
                for(int j = 0; j < 60; j += 30)
                {
                    cbHora.Items.Add(string.Format("{0:D2}:{1:D2}:00", i, j));
                }
            }

            cbEstudiante.Items.Add("Seleccionar estudiante");

            int idAcademico = int.Parse(tbIdAcademico.Text.Trim());

            try
            {
                using (var conexionServicios = new Service1Client())
                {
                    Estudiante[] estudiantes = await conexionServicios.obtenerEstudiantesPorIdAcademicoAsync(idAcademico);
                    foreach (Estudiante estudiante in estudiantes)
                    {
                        cbEstudiante.Items.Add(estudiante);
                    }
                }
                cbEstudiante.SelectedIndex = 0;
                cbHora.SelectedIndex = 0;
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

        private async void inicializarTextBox()
        {
            try
            {
                using (var conexionServicios = new Service1Client())
                {
                    SesionTutoria sesionTutoria = await conexionServicios.obtenerSesionTutoriaPorIdAsync(1);

                    if(sesionTutoria != null)
                    {
                        tbFecha.Text = sesionTutoria.fechaSesion.ToString();
                        tbSesion.Text = sesionTutoria.numSesion.ToString();
                        tbIdSesionTutoria.Text = sesionTutoria.idSesionTutoria.ToString();
                    }
                    else
                    {
                        MessageBox.Show("No hay sesiones de tutorias registradas.", "Sesion no encontrada");
                    }                   
                }
            }catch(Exception ex)
            {
                MessageBox.Show("No hay sesiones de tutorias registradas.", "Sesion no encontrada");
            }
            
        }

        private async void registrarHorarioSesion(SesionTutoria sesionTutoria, Estudiante estudiante, DateTime fechaHora)
        {
            try
            {
                using (var conexionServicios = new Service1Client())
                {
                    bool horarioOcupado = await conexionServicios.horarioOcupadoAsync(sesionTutoria.idSesionTutoria, fechaHora.TimeOfDay);

                    if (!horarioOcupado)
                    {
                        lbHoraError.Content = "";

                        bool estudianteConHorario = await conexionServicios.estudianteConHorarioAsync(estudiante.idEstudiante);

                        if (!estudianteConHorario)
                        {
                            lbEstudianteError.Content = "";

                            bool resultadoOperacion = await conexionServicios.registrarHorarioSesionAsync(sesionTutoria, estudiante, fechaHora);

                            if (resultadoOperacion)
                            {
                                MessageBox.Show("Se ha registrado el horario de sesión con éxito.", "Horario Registrado");
                                cbEstudiante.SelectedIndex = 0;
                                cbHora.SelectedIndex = 0;
                            }
                            else
                            {
                                MessageBox.Show("No se ha podido registrar el horario de sesión.", "Horario No Registrado");
                            }
                        }
                        else
                        {
                            lbEstudianteError.Content = "Este estudiante ya cuenta con horario asignado";
                        }                        
                    }
                    else
                    {
                        lbHoraError.Content = "Horario ya ocupado";
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
            bool camposValidos = true;

            lbEstudianteError.Content = string.Empty;
            lbHoraError.Content = string.Empty;

            if(cbEstudiante.SelectedIndex == 0)
            {
                lbEstudianteError.Content = "Debe seleccionar un estudiante";
                camposValidos = false;
            }

            if(cbHora.SelectedIndex == 0)
            {
                lbHoraError.Content = "Debe seleccionar una hora";
                camposValidos = false;
            }
            return camposValidos;
        }
    }
}
