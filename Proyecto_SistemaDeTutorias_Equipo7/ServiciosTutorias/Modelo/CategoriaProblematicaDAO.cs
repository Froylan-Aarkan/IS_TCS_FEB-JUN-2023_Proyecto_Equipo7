using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ServiciosTutorias.Modelo
{
    public class CategoriaProblematicaDAO
    {
        public static List<CategoriaProblematica> obtenerCategoriasProblematicas()
        {
            DataClassesTutoriasBDDataContext conexionBD = ConexionBaseDatos.getConnection();

            var categoriasBD = from categoriaBD in conexionBD.CategoriaProblematica select categoriaBD;

            List<CategoriaProblematica> categorias = new List<CategoriaProblematica>();

            foreach(CategoriaProblematica categoria in categoriasBD)
            {
                CategoriaProblematica categoriaProblematica= new CategoriaProblematica()
                {
                    idCategoria = categoria.idCategoria,
                    nombre = categoria.nombre,
                };

                categorias.Add(categoriaProblematica);
            }

            return categorias;
        }


        public static CategoriaProblematica obtenerCategoriaProblematicaPorId(int idCategoria)
        {
            DataClassesTutoriasBDDataContext conexionBD = ConexionBaseDatos.getConnection();

            var categoriaBD = (from categoria in conexionBD.CategoriaProblematica where categoria.idCategoria == idCategoria select categoria).FirstOrDefault();

            CategoriaProblematica categoriaProblematica = new CategoriaProblematica()
            {
                idCategoria = categoriaBD.idCategoria,
                nombre = categoriaBD.nombre,
            };

            return categoriaProblematica;
        }
    }
}