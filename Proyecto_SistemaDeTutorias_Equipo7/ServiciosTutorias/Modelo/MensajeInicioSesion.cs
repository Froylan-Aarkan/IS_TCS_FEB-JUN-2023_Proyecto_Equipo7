using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Web;

namespace ServiciosTutorias.Modelo
{
    [DataContract]
    public class MensajeInicioSesion
    {
        [DataMember]
        public bool error { set; get; }
        [DataMember]
        public string mensaje { set; get; }
        [DataMember]
        public Academico academico { set; get; }
    }
}