﻿#pragma checksum "..\..\..\..\..\View\CadastrosBase\SituacaoColaboradorPrincipal.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "9F41B41C49C1EB440E82FA2E59C9DD2C"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.269
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using CadastrosBaseClient.View.CadastrosBase;
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


namespace CadastrosBaseClient.View.CadastrosBase {
    
    
    /// <summary>
    /// SituacaoColaboradorPrincipal
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
    public partial class SituacaoColaboradorPrincipal : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 10 "..\..\..\..\..\View\CadastrosBase\SituacaoColaboradorPrincipal.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TabItem tabSituacaoColaboradorLista;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\..\..\..\View\CadastrosBase\SituacaoColaboradorPrincipal.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnExcluir;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\..\..\..\View\CadastrosBase\SituacaoColaboradorPrincipal.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnIncluir;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\..\..\..\View\CadastrosBase\SituacaoColaboradorPrincipal.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnConsultar;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\..\..\..\View\CadastrosBase\SituacaoColaboradorPrincipal.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TabItem tabSituacaoColaborador;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/VendasClient;component/view/cadastrosbase/situacaocolaboradorprincipal.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\View\CadastrosBase\SituacaoColaboradorPrincipal.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.tabSituacaoColaboradorLista = ((System.Windows.Controls.TabItem)(target));
            return;
            case 2:
            this.btnExcluir = ((System.Windows.Controls.Button)(target));
            
            #line 14 "..\..\..\..\..\View\CadastrosBase\SituacaoColaboradorPrincipal.xaml"
            this.btnExcluir.Click += new System.Windows.RoutedEventHandler(this.btnExcluir_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.btnIncluir = ((System.Windows.Controls.Button)(target));
            
            #line 20 "..\..\..\..\..\View\CadastrosBase\SituacaoColaboradorPrincipal.xaml"
            this.btnIncluir.Click += new System.Windows.RoutedEventHandler(this.btnIncluir_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.btnConsultar = ((System.Windows.Controls.Button)(target));
            
            #line 26 "..\..\..\..\..\View\CadastrosBase\SituacaoColaboradorPrincipal.xaml"
            this.btnConsultar.Click += new System.Windows.RoutedEventHandler(this.btnConsultar_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.tabSituacaoColaborador = ((System.Windows.Controls.TabItem)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

