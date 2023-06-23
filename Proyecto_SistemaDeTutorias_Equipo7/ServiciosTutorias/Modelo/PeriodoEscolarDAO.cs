using System;
using System.Collections.Generic;
using System.EnterpriseServices.Internal;
using System.Linq;
using System.Web;

namespace ServiciosTutorias.Modelo
{
    /*///////////////////////////////////////////////////////////////////////////////////////////////////////////
-	Autores: Froylan De Jesus Alvarez Rodriguez, Johan David Solis Hernandez
-	Descripción: Metodos para las operaciones que se realizaran en la base de datos que tengan que ver con los periodos escolares
    ///////////////////////////////////////////////////////////////////////////////////////////////////////////*/
    public class PeriodoEscolarDAO
    {
        public static PeriodoEscolar obtenerPeriodoEscolarPorId(int idPeriodoEscolar)
        {
            DataClassesTutoriasBDDataContext conexionBD = ConexionBaseDatos.getConnection();

            var periodoEscolarBD = (from periodoBD in conexionBD.PeriodoEscolar where periodoBD.idPeriodoEscolar == idPeriodoEscolar select periodoBD).FirstOrDefault();

            if(periodoEscolarBD != null)
            {
                PeriodoEscolar periodoEscolar = new PeriodoEscolar()
                {
                    idPeriodoEscolar = periodoEscolarBD.idPeriodoEscolar,
                    nombre = periodoEscolarBD.nombre,
                    fechaInicio = periodoEscolarBD.fechaInicio,
                    fechaFin = periodoEscolarBD.fechaFin,
                };

                return periodoEscolar;
            }
            else
            {
                return null;
            }
        }

        public static PeriodoEscolar obtenerPeriodosEscolaresPorId(int idPeriodoEscolar)
        {
            DataClassesTutoriasBDDataContext conexionBD = ConexionBaseDatos.getConnection();

            var periodosEscolaresBD = (from periodosEscolares in conexionBD.PeriodoEscolar
                                       where periodosEscolares.idPeriodoEscolar == idPeriodoEscolar
                                       select periodosEscolares).FirstOrDefault();

            PeriodoEscolar periodoEscolar = new PeriodoEscolar()
            {
                idPeriodoEscolar = periodosEscolaresBD.idPeriodoEscolar,
                nombre = periodosEscolaresBD.nombre,
                fechaInicio = periodosEscolaresBD.fechaInicio,
                fechaFin = periodosEscolaresBD.fechaFin
            };

            return periodoEscolar;
        }

        public static List<PeriodoEscolar> obtenerPeriodosEscolares()
        {
            DataClassesTutoriasBDDataContext conexionBD = ConexionBaseDatos.getConnection();

            var periodosEscolaresBD = from periodosEscolares in conexionBD.PeriodoEscolar
                                      select periodosEscolares;

            List<PeriodoEscolar> periodosEscolaresLista = new List<PeriodoEscolar>();

            foreach (PeriodoEscolar periodoEs in periodosEscolaresBD)
            {
                PeriodoEscolar periodoEscolar = new PeriodoEscolar()
                {
                    idPeriodoEscolar = periodoEs.idPeriodoEscolar,
                    nombre = periodoEs.nombre,
                    fechaInicio = periodoEs.fechaInicio,
                    fechaFin = periodoEs.fechaFin
                };
                periodosEscolaresLista.Add(periodoEscolar);
            }

            return periodosEscolaresLista;
        }
    }
}