using FrontEnd.Vistas.TutoriasAcademicas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace FrontEnd
{
    class UtilidadesFrontEnd
    {
        public static bool mostrarCuadroConfirmacion(string mensaje, string titulo)
        {
            MessageBoxResult resultado = MessageBox.Show(mensaje, titulo, MessageBoxButton.OKCancel, MessageBoxImage.Question); 

            if (resultado == MessageBoxResult.OK)
            {
                return true;
            }
            else if(resultado == MessageBoxResult.Cancel)
            {
                return false;
            }
            else
            {
                return false;
            }
        }
    }
}
