using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ServiciosTutorias.Modelo
{
    /*///////////////////////////////////////////////////////////////////////////////////////////////////////////
-	Autores: Froylan De Jesus Alvarez Rodriguez, Johan David Solis Hernandez
-	Descripción: Metodos para las operaciones que se realizaran en la base de datos que tengan que ver con la categoria de las problematicas académicas
    ///////////////////////////////////////////////////////////////////////////////////////////////////////////*/
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