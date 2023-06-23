using ReferenciaServicioTutorias;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrontEnd.Modelo
{
    internal class EstudianteConTutorViewModel
    {
        public ObservableCollection<Estudiante> estudiantesBD { get; set; }

        public EstudianteConTutorViewModel()
        {
            estudiantesBD = new ObservableCollection<Estudiante>();
            solicitarInformacionServicio();
        }

        private async void solicitarInformacionServicio()
        {
            var conexionServicios = new Service1Client();

            if (conexionServicios != null)
            {
                Estudiante[] estudiantesSinTutor = await conexionServicios.obtenerEstudiantesConTutorAsync();

                foreach (Estudiante estudiante in estudiantesSinTutor)
                {
                    estudiantesBD.Add(estudiante);
                }
            }
        }
    }
}
