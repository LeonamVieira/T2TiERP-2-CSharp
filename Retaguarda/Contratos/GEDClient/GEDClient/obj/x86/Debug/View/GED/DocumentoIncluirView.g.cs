﻿#pragma checksum "..\..\..\..\..\View\GED\DocumentoIncluirView.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "FD43995A336EFA96C4907A18CF0016F4"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18449
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Microsoft.Windows.Controls;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
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


namespace GEDClient.View.GED {
    
    
    /// <summary>
    /// DocumentoIncluirView
    /// </summary>
    public partial class DocumentoIncluirView : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 8 "..\..\..\..\..\View\GED\DocumentoIncluirView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DockPanel dpInserir;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\..\..\..\View\GED\DocumentoIncluirView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btConfirmar;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\..\..\..\View\GED\DocumentoIncluirView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btCancelar;
        
        #line default
        #line hidden
        
        
        #line 95 "..\..\..\..\..\View\GED\DocumentoIncluirView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btScanner;
        
        #line default
        #line hidden
        
        
        #line 101 "..\..\..\..\..\View\GED\DocumentoIncluirView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btBrowse;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/GEDClient;component/view/ged/documentoincluirview.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\View\GED\DocumentoIncluirView.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.dpInserir = ((System.Windows.Controls.DockPanel)(target));
            return;
            case 2:
            this.btConfirmar = ((System.Windows.Controls.Button)(target));
            
            #line 13 "..\..\..\..\..\View\GED\DocumentoIncluirView.xaml"
            this.btConfirmar.Click += new System.Windows.RoutedEventHandler(this.btConfirmar_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.btCancelar = ((System.Windows.Controls.Button)(target));
            
            #line 19 "..\..\..\..\..\View\GED\DocumentoIncluirView.xaml"
            this.btCancelar.Click += new System.Windows.RoutedEventHandler(this.btCancelar_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.btScanner = ((System.Windows.Controls.Button)(target));
            
            #line 95 "..\..\..\..\..\View\GED\DocumentoIncluirView.xaml"
            this.btScanner.Click += new System.Windows.RoutedEventHandler(this.btScanner_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.btBrowse = ((System.Windows.Controls.Button)(target));
            
            #line 101 "..\..\..\..\..\View\GED\DocumentoIncluirView.xaml"
            this.btBrowse.Click += new System.Windows.RoutedEventHandler(this.btBrowse_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            
            #line 107 "..\..\..\..\..\View\GED\DocumentoIncluirView.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

