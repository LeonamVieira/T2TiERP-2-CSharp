﻿#pragma checksum "..\..\..\..\..\View\GED\GEDClient.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "6010682013F34CEC4BE004EA6CE07D33"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.1008
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
    /// GEDClient
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
    public partial class GEDClient : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 18 "..\..\..\..\..\View\GED\GEDClient.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TabItem tabPrincipalDocumento;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\..\..\..\View\GED\GEDClient.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btPesquisarDoc;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\..\..\..\View\GED\GEDClient.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btIncluirDoc;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\..\..\..\View\GED\GEDClient.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btVisualizar;
        
        #line default
        #line hidden
        
        
        #line 45 "..\..\..\..\..\View\GED\GEDClient.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btExcluirDoc;
        
        #line default
        #line hidden
        
        
        #line 52 "..\..\..\..\..\View\GED\GEDClient.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btAlterarDoc;
        
        #line default
        #line hidden
        
        
        #line 82 "..\..\..\..\..\View\GED\GEDClient.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TabItem tabOperacoesDoc;
        
        #line default
        #line hidden
        
        
        #line 84 "..\..\..\..\..\View\GED\GEDClient.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DockPanel dpOperacoesDoc;
        
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
            System.Uri resourceLocater = new System.Uri("/GEDClient;component/view/ged/gedclient.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\View\GED\GEDClient.xaml"
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
            this.tabPrincipalDocumento = ((System.Windows.Controls.TabItem)(target));
            return;
            case 2:
            this.btPesquisarDoc = ((System.Windows.Controls.Button)(target));
            
            #line 26 "..\..\..\..\..\View\GED\GEDClient.xaml"
            this.btPesquisarDoc.Click += new System.Windows.RoutedEventHandler(this.btPesquisarDoc_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.btIncluirDoc = ((System.Windows.Controls.Button)(target));
            
            #line 32 "..\..\..\..\..\View\GED\GEDClient.xaml"
            this.btIncluirDoc.Click += new System.Windows.RoutedEventHandler(this.btIncluirDoc_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.btVisualizar = ((System.Windows.Controls.Button)(target));
            
            #line 39 "..\..\..\..\..\View\GED\GEDClient.xaml"
            this.btVisualizar.Click += new System.Windows.RoutedEventHandler(this.btVisualizar_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.btExcluirDoc = ((System.Windows.Controls.Button)(target));
            
            #line 46 "..\..\..\..\..\View\GED\GEDClient.xaml"
            this.btExcluirDoc.Click += new System.Windows.RoutedEventHandler(this.btExcluirDoc_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.btAlterarDoc = ((System.Windows.Controls.Button)(target));
            
            #line 53 "..\..\..\..\..\View\GED\GEDClient.xaml"
            this.btAlterarDoc.Click += new System.Windows.RoutedEventHandler(this.btAlterarDoc_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.tabOperacoesDoc = ((System.Windows.Controls.TabItem)(target));
            return;
            case 8:
            this.dpOperacoesDoc = ((System.Windows.Controls.DockPanel)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

