﻿#pragma checksum "..\..\..\..\..\View\Estoque\EstoqueReajusteCabecalhoPrincipal.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "099E026F61B9636AB32968F3B62D4B25"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18449
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using EstoqueClient.View.Estoque;
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


namespace EstoqueClient.View.Estoque {
    
    
    /// <summary>
    /// EstoqueReajusteCabecalhoPrincipal
    /// </summary>
    public partial class EstoqueReajusteCabecalhoPrincipal : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 10 "..\..\..\..\..\View\Estoque\EstoqueReajusteCabecalhoPrincipal.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TabItem tabEstoqueReajusteCabecalhoLista;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\..\..\..\View\Estoque\EstoqueReajusteCabecalhoPrincipal.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btExcluir;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\..\..\..\View\Estoque\EstoqueReajusteCabecalhoPrincipal.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btIncluir;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\..\..\..\View\Estoque\EstoqueReajusteCabecalhoPrincipal.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btConsultar;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\..\..\..\View\Estoque\EstoqueReajusteCabecalhoPrincipal.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TabItem tabEstoqueReajusteCabecalho;
        
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
            System.Uri resourceLocater = new System.Uri("/EstoqueClient;component/view/estoque/estoquereajustecabecalhoprincipal.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\View\Estoque\EstoqueReajusteCabecalhoPrincipal.xaml"
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
            this.tabEstoqueReajusteCabecalhoLista = ((System.Windows.Controls.TabItem)(target));
            return;
            case 2:
            this.btExcluir = ((System.Windows.Controls.Button)(target));
            
            #line 14 "..\..\..\..\..\View\Estoque\EstoqueReajusteCabecalhoPrincipal.xaml"
            this.btExcluir.Click += new System.Windows.RoutedEventHandler(this.btExcluir_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.btIncluir = ((System.Windows.Controls.Button)(target));
            
            #line 20 "..\..\..\..\..\View\Estoque\EstoqueReajusteCabecalhoPrincipal.xaml"
            this.btIncluir.Click += new System.Windows.RoutedEventHandler(this.btIncluir_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.btConsultar = ((System.Windows.Controls.Button)(target));
            
            #line 26 "..\..\..\..\..\View\Estoque\EstoqueReajusteCabecalhoPrincipal.xaml"
            this.btConsultar.Click += new System.Windows.RoutedEventHandler(this.btConsultar_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.tabEstoqueReajusteCabecalho = ((System.Windows.Controls.TabItem)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

