﻿#pragma checksum "..\..\..\..\Visualizar\AdminControle.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "F2728FEC5A9CE57BD31FFE5F15484061837F7790"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms.Integration;
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
using WPF_PIM_4.Visualizar;


namespace WPF_PIM_4.Visualizar {
    
    
    /// <summary>
    /// AdminControle
    /// </summary>
    public partial class AdminControle : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 23 "..\..\..\..\Visualizar\AdminControle.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtEmail;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\..\..\Visualizar\AdminControle.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dataGridEmails;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\..\..\Visualizar\AdminControle.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dataGridSugestoes;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\..\..\Visualizar\AdminControle.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dataGridRespostas;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.10.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/WPF-PIM-4;component/visualizar/admincontrole.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Visualizar\AdminControle.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.10.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            
            #line 18 "..\..\..\..\Visualizar\AdminControle.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Buscar_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            
            #line 19 "..\..\..\..\Visualizar\AdminControle.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.AtualizarEmail_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            
            #line 20 "..\..\..\..\Visualizar\AdminControle.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.DeletarEmail_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            
            #line 21 "..\..\..\..\Visualizar\AdminControle.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.DeletarSugestao_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            
            #line 22 "..\..\..\..\Visualizar\AdminControle.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.DeletarResposta_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.txtEmail = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.dataGridEmails = ((System.Windows.Controls.DataGrid)(target));
            
            #line 29 "..\..\..\..\Visualizar\AdminControle.xaml"
            this.dataGridEmails.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.dataGridEmails_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 8:
            this.dataGridSugestoes = ((System.Windows.Controls.DataGrid)(target));
            
            #line 36 "..\..\..\..\Visualizar\AdminControle.xaml"
            this.dataGridSugestoes.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.dataGridSugestoes_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 9:
            this.dataGridRespostas = ((System.Windows.Controls.DataGrid)(target));
            
            #line 43 "..\..\..\..\Visualizar\AdminControle.xaml"
            this.dataGridRespostas.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.dataGridRespostas_SelectionChanged);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

