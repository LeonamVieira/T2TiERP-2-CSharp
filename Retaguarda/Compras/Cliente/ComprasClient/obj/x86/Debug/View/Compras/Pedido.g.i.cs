﻿#pragma checksum "..\..\..\..\..\View\Compras\Pedido.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "ABF843465FCC981476AB272DE79DC31B"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18449
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using ComprasClient.Util;
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


namespace ComprasClient.View.Compras {
    
    
    /// <summary>
    /// Pedido
    /// </summary>
    public partial class Pedido : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 28 "..\..\..\..\..\View\Compras\Pedido.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btPesquisar;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\..\..\..\View\Compras\Pedido.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btIncluir;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\..\..\..\View\Compras\Pedido.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btExcluir;
        
        #line default
        #line hidden
        
        
        #line 48 "..\..\..\..\..\View\Compras\Pedido.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btAlterar;
        
        #line default
        #line hidden
        
        
        #line 55 "..\..\..\..\..\View\Compras\Pedido.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btRelatorio;
        
        #line default
        #line hidden
        
        
        #line 68 "..\..\..\..\..\View\Compras\Pedido.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox comboExp;
        
        #line default
        #line hidden
        
        
        #line 84 "..\..\..\..\..\View\Compras\Pedido.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dataGrid;
        
        #line default
        #line hidden
        
        
        #line 116 "..\..\..\..\..\View\Compras\Pedido.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btConfirmar;
        
        #line default
        #line hidden
        
        
        #line 122 "..\..\..\..\..\View\Compras\Pedido.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btCancelar;
        
        #line default
        #line hidden
        
        
        #line 150 "..\..\..\..\..\View\Compras\Pedido.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btPesquisarColaborador;
        
        #line default
        #line hidden
        
        
        #line 168 "..\..\..\..\..\View\Compras\Pedido.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btPesquisarTipoPedido;
        
        #line default
        #line hidden
        
        
        #line 284 "..\..\..\..\..\View\Compras\Pedido.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btIncluirProduto;
        
        #line default
        #line hidden
        
        
        #line 290 "..\..\..\..\..\View\Compras\Pedido.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btExcluirProduto;
        
        #line default
        #line hidden
        
        
        #line 300 "..\..\..\..\..\View\Compras\Pedido.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox comboExpProdutos;
        
        #line default
        #line hidden
        
        
        #line 317 "..\..\..\..\..\View\Compras\Pedido.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dataGridProdutos;
        
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
            System.Uri resourceLocater = new System.Uri("/ComprasClient;component/view/compras/pedido.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\View\Compras\Pedido.xaml"
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
            this.btPesquisar = ((System.Windows.Controls.Button)(target));
            return;
            case 2:
            this.btIncluir = ((System.Windows.Controls.Button)(target));
            
            #line 35 "..\..\..\..\..\View\Compras\Pedido.xaml"
            this.btIncluir.Click += new System.Windows.RoutedEventHandler(this.btIncluir_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.btExcluir = ((System.Windows.Controls.Button)(target));
            
            #line 42 "..\..\..\..\..\View\Compras\Pedido.xaml"
            this.btExcluir.Click += new System.Windows.RoutedEventHandler(this.btExcluir_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.btAlterar = ((System.Windows.Controls.Button)(target));
            
            #line 49 "..\..\..\..\..\View\Compras\Pedido.xaml"
            this.btAlterar.Click += new System.Windows.RoutedEventHandler(this.btAlterar_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.btRelatorio = ((System.Windows.Controls.Button)(target));
            
            #line 55 "..\..\..\..\..\View\Compras\Pedido.xaml"
            this.btRelatorio.Click += new System.Windows.RoutedEventHandler(this.btRelatorio_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.comboExp = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 7:
            
            #line 78 "..\..\..\..\..\View\Compras\Pedido.xaml"
            ((ExportarParaArquivo.Control.ButtonExport)(target)).Click += new System.Windows.RoutedEventHandler(this.ButtonExport_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.dataGrid = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 9:
            this.btConfirmar = ((System.Windows.Controls.Button)(target));
            
            #line 116 "..\..\..\..\..\View\Compras\Pedido.xaml"
            this.btConfirmar.Click += new System.Windows.RoutedEventHandler(this.btConfirmar_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            this.btCancelar = ((System.Windows.Controls.Button)(target));
            
            #line 122 "..\..\..\..\..\View\Compras\Pedido.xaml"
            this.btCancelar.Click += new System.Windows.RoutedEventHandler(this.btCancelar_Click);
            
            #line default
            #line hidden
            return;
            case 11:
            this.btPesquisarColaborador = ((System.Windows.Controls.Button)(target));
            
            #line 150 "..\..\..\..\..\View\Compras\Pedido.xaml"
            this.btPesquisarColaborador.Click += new System.Windows.RoutedEventHandler(this.btPesquisarColaborador_Click);
            
            #line default
            #line hidden
            return;
            case 12:
            this.btPesquisarTipoPedido = ((System.Windows.Controls.Button)(target));
            
            #line 168 "..\..\..\..\..\View\Compras\Pedido.xaml"
            this.btPesquisarTipoPedido.Click += new System.Windows.RoutedEventHandler(this.btPesquisarTipoPedido_Click);
            
            #line default
            #line hidden
            return;
            case 13:
            this.btIncluirProduto = ((System.Windows.Controls.Button)(target));
            
            #line 284 "..\..\..\..\..\View\Compras\Pedido.xaml"
            this.btIncluirProduto.Click += new System.Windows.RoutedEventHandler(this.btIncluirProduto_Click);
            
            #line default
            #line hidden
            return;
            case 14:
            this.btExcluirProduto = ((System.Windows.Controls.Button)(target));
            
            #line 290 "..\..\..\..\..\View\Compras\Pedido.xaml"
            this.btExcluirProduto.Click += new System.Windows.RoutedEventHandler(this.btExcluirProduto_Click);
            
            #line default
            #line hidden
            return;
            case 15:
            this.comboExpProdutos = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 16:
            
            #line 310 "..\..\..\..\..\View\Compras\Pedido.xaml"
            ((ExportarParaArquivo.Control.ButtonExport)(target)).Click += new System.Windows.RoutedEventHandler(this.ButtonExport_Click);
            
            #line default
            #line hidden
            return;
            case 17:
            this.dataGridProdutos = ((System.Windows.Controls.DataGrid)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

