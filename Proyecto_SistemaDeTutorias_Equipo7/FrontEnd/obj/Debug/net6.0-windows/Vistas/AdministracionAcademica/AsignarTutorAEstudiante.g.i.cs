﻿#pragma checksum "..\..\..\..\..\Vistas\AdministracionAcademica\AsignarTutorAEstudiante.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1E149C43C848C437893849250BF3F596BFD73798"
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

using FrontEnd.Vistas.AdministracionAcademica;
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


namespace FrontEnd.Vistas.AdministracionAcademica {
    
    
    /// <summary>
    /// AsignarTutorAEstudiante
    /// </summary>
    public partial class AsignarTutorAEstudiante : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 21 "..\..\..\..\..\Vistas\AdministracionAcademica\AsignarTutorAEstudiante.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dgEstudiantes;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\..\..\..\Vistas\AdministracionAcademica\AsignarTutorAEstudiante.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnAceptar;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\..\..\..\Vistas\AdministracionAcademica\AsignarTutorAEstudiante.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnCancelar;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\..\..\..\Vistas\AdministracionAcademica\AsignarTutorAEstudiante.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock tbIdRolAcademico;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\..\..\..\Vistas\AdministracionAcademica\AsignarTutorAEstudiante.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock tbIdAcademico;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\..\..\..\Vistas\AdministracionAcademica\AsignarTutorAEstudiante.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cbAcademicos;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\..\..\..\Vistas\AdministracionAcademica\AsignarTutorAEstudiante.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblErrorTutores;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\..\..\..\Vistas\AdministracionAcademica\AsignarTutorAEstudiante.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblErrorEstudiantes;
        
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
            System.Uri resourceLocater = new System.Uri("/FrontEnd;component/vistas/administracionacademica/asignartutoraestudiante.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\Vistas\AdministracionAcademica\AsignarTutorAEstudiante.xaml"
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
            this.dgEstudiantes = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 2:
            this.BtnAceptar = ((System.Windows.Controls.Button)(target));
            
            #line 27 "..\..\..\..\..\Vistas\AdministracionAcademica\AsignarTutorAEstudiante.xaml"
            this.BtnAceptar.Click += new System.Windows.RoutedEventHandler(this.btnAceptar_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.BtnCancelar = ((System.Windows.Controls.Button)(target));
            
            #line 28 "..\..\..\..\..\Vistas\AdministracionAcademica\AsignarTutorAEstudiante.xaml"
            this.BtnCancelar.Click += new System.Windows.RoutedEventHandler(this.btnCancelar_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.tbIdRolAcademico = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 5:
            this.tbIdAcademico = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 6:
            this.cbAcademicos = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 7:
            this.lblErrorTutores = ((System.Windows.Controls.Label)(target));
            return;
            case 8:
            this.lblErrorEstudiantes = ((System.Windows.Controls.Label)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

