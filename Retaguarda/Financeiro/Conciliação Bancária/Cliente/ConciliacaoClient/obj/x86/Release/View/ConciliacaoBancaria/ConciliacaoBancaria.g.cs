﻿#pragma checksum "..\..\..\..\..\View\ConciliacaoBancaria\ConciliacaoBancaria.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "E737562F54C1C65B568E2B361D7D0E40"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.1
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using ConciliacaoClient.Util;
using ExportarParaArquivo;
using ExportarParaArquivo.Control;
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


namespace ConciliacaoClient.View.ConciliacaoBancaria {
    
    
    /// <summary>
    /// ConciliacaoBancaria
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
    public partial class ConciliacaoBancaria : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 31 "..\..\..\..\..\View\ConciliacaoBancaria\ConciliacaoBancaria.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btPesquisarContaCaixa;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\..\..\..\View\ConciliacaoBancaria\ConciliacaoBancaria.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btPesquisarMovimento;
        
        #line default
        #line hidden
        
        
        #line 46 "..\..\..\..\..\View\ConciliacaoBancaria\ConciliacaoBancaria.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btImportar;
        
        #line default
        #line hidden
        
        
        #line 52 "..\..\..\..\..\View\ConciliacaoBancaria\ConciliacaoBancaria.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btConciliarLancamentos;
        
        #line default
        #line hidden
        
        
        #line 58 "..\..\..\..\..\View\ConciliacaoBancaria\ConciliacaoBancaria.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btConciliarCheque;
        
        #line default
        #line hidden
        
        
        #line 73 "..\..\..\..\..\View\ConciliacaoBancaria\ConciliacaoBancaria.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox comboExp;
        
        #line default
        #line hidden
        
        
        #line 118 "..\..\..\..\..\View\ConciliacaoBancaria\ConciliacaoBancaria.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dataGrid;
        
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
            System.Uri resourceLocater = new System.Uri("/ConciliacaoClient;component/view/conciliacaobancaria/conciliacaobancaria.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\View\ConciliacaoBancaria\ConciliacaoBancaria.xaml"
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
            this.btPesquisarContaCaixa = ((System.Windows.Controls.Button)(target));
            
            #line 31 "..\..\..\..\..\View\ConciliacaoBancaria\ConciliacaoBancaria.xaml"
            this.btPesquisarContaCaixa.Click += new System.Windows.RoutedEventHandler(this.btPesquisarContaCaixa_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            
            #line 39 "..\..\..\..\..\View\ConciliacaoBancaria\ConciliacaoBancaria.xaml"
            ((System.Windows.Controls.TextBox)(target)).LostFocus += new System.Windows.RoutedEventHandler(this.TextBox_LostFocus_1);
            
            #line default
            #line hidden
            return;
            case 3:
            this.btPesquisarMovimento = ((System.Windows.Controls.Button)(target));
            
            #line 40 "..\..\..\..\..\View\ConciliacaoBancaria\ConciliacaoBancaria.xaml"
            this.btPesquisarMovimento.Click += new System.Windows.RoutedEventHandler(this.btPesquisarMovimento_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.btImportar = ((System.Windows.Controls.Button)(target));
            
            #line 46 "..\..\..\..\..\View\ConciliacaoBancaria\ConciliacaoBancaria.xaml"
            this.btImportar.Click += new System.Windows.RoutedEventHandler(this.btImportar_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.btConciliarLancamentos = ((System.Windows.Controls.Button)(target));
            
            #line 52 "..\..\..\..\..\View\ConciliacaoBancaria\ConciliacaoBancaria.xaml"
            this.btConciliarLancamentos.Click += new System.Windows.RoutedEventHandler(this.btConciliarLancamentos_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.btConciliarCheque = ((System.Windows.Controls.Button)(target));
            
            #line 58 "..\..\..\..\..\View\ConciliacaoBancaria\ConciliacaoBancaria.xaml"
            this.btConciliarCheque.Click += new System.Windows.RoutedEventHandler(this.btConciliarCheque_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.comboExp = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 8:
            
            #line 83 "..\..\..\..\..\View\ConciliacaoBancaria\ConciliacaoBancaria.xaml"
            ((ExportarParaArquivo.Control.ButtonExport)(target)).Click += new System.Windows.RoutedEventHandler(this.ButtonExport_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.dataGrid = ((System.Windows.Controls.DataGrid)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

