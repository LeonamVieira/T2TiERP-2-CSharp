﻿#pragma checksum "..\..\..\..\..\View\ContasPagar\FinLctoPagarNtFinanceiraLista.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "B15A54922F8E694B71DB76CC568E26A9"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18449
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using ContasPagarClient.Util;
using ExportarParaArquivo;
using ExportarParaArquivo.Control;
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


namespace ContasPagarClient.View.ContasPagar {
    
    
    /// <summary>
    /// FinLctoPagarNtFinanceiraLista
    /// </summary>
    public partial class FinLctoPagarNtFinanceiraLista : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 18 "..\..\..\..\..\View\ContasPagar\FinLctoPagarNtFinanceiraLista.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox comboExp;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\..\..\..\View\ContasPagar\FinLctoPagarNtFinanceiraLista.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dataGrid;
        
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
            System.Uri resourceLocater = new System.Uri("/ContasPagarClient;component/view/contaspagar/finlctopagarntfinanceiralista.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\View\ContasPagar\FinLctoPagarNtFinanceiraLista.xaml"
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
            this.comboExp = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 2:
            
            #line 19 "..\..\..\..\..\View\ContasPagar\FinLctoPagarNtFinanceiraLista.xaml"
            ((ExportarParaArquivo.Control.ButtonExport)(target)).Click += new System.Windows.RoutedEventHandler(this.ButtonExport_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.dataGrid = ((System.Windows.Controls.DataGrid)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

