﻿#pragma checksum "..\..\..\..\..\Vistas\SeguimientoProblematicas\RegistrarSolucionProblematica.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "428637D76DDE93385C1B742FAFAE89772283DDAA"
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

using FrontEnd.Vistas.SeguimientoProblematicas;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;


namespace FrontEnd.Vistas.SeguimientoProblematicas {
    
    
    /// <summary>
    /// RegistrarSolucionProblematica
    /// </summary>
    public partial class RegistrarSolucionProblematica : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 17 "..\..\..\..\..\Vistas\SeguimientoProblematicas\RegistrarSolucionProblematica.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dgProblematicasAcademicas;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\..\..\..\Vistas\SeguimientoProblematicas\RegistrarSolucionProblematica.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnRegresar;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\..\..\..\Vistas\SeguimientoProblematicas\RegistrarSolucionProblematica.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnConsultar;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\..\..\..\Vistas\SeguimientoProblematicas\RegistrarSolucionProblematica.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock tbIdRolAcademico;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\..\..\..\Vistas\SeguimientoProblematicas\RegistrarSolucionProblematica.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock tbIdAcademico;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.5.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/FrontEnd;component/vistas/seguimientoproblematicas/registrarsolucionproblematica" +
                    ".xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\Vistas\SeguimientoProblematicas\RegistrarSolucionProblematica.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.5.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.dgProblematicasAcademicas = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 2:
            this.BtnRegresar = ((System.Windows.Controls.Button)(target));
            
            #line 24 "..\..\..\..\..\Vistas\SeguimientoProblematicas\RegistrarSolucionProblematica.xaml"
            this.BtnRegresar.Click += new System.Windows.RoutedEventHandler(this.BtnRegresar_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.btnConsultar = ((System.Windows.Controls.Button)(target));
            
            #line 25 "..\..\..\..\..\Vistas\SeguimientoProblematicas\RegistrarSolucionProblematica.xaml"
            this.btnConsultar.Click += new System.Windows.RoutedEventHandler(this.btnConsultar_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.tbIdRolAcademico = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 5:
            this.tbIdAcademico = ((System.Windows.Controls.TextBlock)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}
