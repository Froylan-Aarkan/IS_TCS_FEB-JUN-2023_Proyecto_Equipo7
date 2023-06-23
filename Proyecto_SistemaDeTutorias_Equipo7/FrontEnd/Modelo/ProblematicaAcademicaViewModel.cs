using ReferenciaServicioTutorias;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrontEnd.Modelo
{
    class ProblematicaAcademicaViewModel
    {
        public ObservableCollection<ProblematicaAcademica> problematicasBD { get; set; }

        public ProblematicaAcademicaViewModel()
        {
            problematicasBD = new ObservableCollection<ProblematicaAcademica>();
            solicitarInformacionServicio();
        }

        private async void solicitarInformacionServicio()
        {
            var conexionServicios = new Service1Client();

            if(conexionServicios != null)
            {
                ProblematicaAcademica[] problematicasServicio = await conexionServicios.obtenerProblematicasAcademicasAsync();
                foreach(ProblematicaAcademica problematica in problematicasServicio)
                {
                    problematicasBD.Add(problematica);
                }
            }
        }
    }
}
