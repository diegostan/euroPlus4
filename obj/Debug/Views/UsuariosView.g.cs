﻿#pragma checksum "..\..\..\Views\UsuariosView.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "15A793B4507B75CD173A9676851E2E933B52A934DBCD71297BF645657C7EF679"
//------------------------------------------------------------------------------
// <auto-generated>
//     O código foi gerado por uma ferramenta.
//     Versão de Tempo de Execução:4.0.30319.42000
//
//     As alterações ao arquivo poderão causar comportamento incorreto e serão perdidas se
//     o código for gerado novamente.
// </auto-generated>
//------------------------------------------------------------------------------

using MahApps.Metro;
using MahApps.Metro.Controls;
using MahApps.Metro.Controls.Dialogs;
using MahApps.Metro.IconPacks;
using MahApps.Metro.IconPacks.Converter;
using MaterialDesignThemes.Wpf;
using MaterialDesignThemes.Wpf.Converters;
using MaterialDesignThemes.Wpf.Transitions;
using Rife.Keyboard;
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


namespace euroPlus4_1.Views {
    
    
    /// <summary>
    /// UsuariosView
    /// </summary>
    public partial class UsuariosView : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 28 "..\..\..\Views\UsuariosView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal MahApps.Metro.Controls.MetroAnimatedTabControl menu;
        
        #line default
        #line hidden
        
        
        #line 46 "..\..\..\Views\UsuariosView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock lblNome;
        
        #line default
        #line hidden
        
        
        #line 47 "..\..\..\Views\UsuariosView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock lblNivel;
        
        #line default
        #line hidden
        
        
        #line 48 "..\..\..\Views\UsuariosView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock lblRFID;
        
        #line default
        #line hidden
        
        
        #line 49 "..\..\..\Views\UsuariosView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock lblData;
        
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
            System.Uri resourceLocater = new System.Uri("/euroPlus4_1;component/views/usuariosview.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Views\UsuariosView.xaml"
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
            
            #line 12 "..\..\..\Views\UsuariosView.xaml"
            ((euroPlus4_1.Views.UsuariosView)(target)).LostFocus += new System.Windows.RoutedEventHandler(this.Page_LostFocus);
            
            #line default
            #line hidden
            return;
            case 2:
            this.menu = ((MahApps.Metro.Controls.MetroAnimatedTabControl)(target));
            return;
            case 3:
            this.lblNome = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 4:
            this.lblNivel = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 5:
            this.lblRFID = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 6:
            this.lblData = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 7:
            
            #line 91 "..\..\..\Views\UsuariosView.xaml"
            ((System.Windows.Controls.TextBox)(target)).GotFocus += new System.Windows.RoutedEventHandler(this.TextBox_GotFocus);
            
            #line default
            #line hidden
            
            #line 91 "..\..\..\Views\UsuariosView.xaml"
            ((System.Windows.Controls.TextBox)(target)).LostFocus += new System.Windows.RoutedEventHandler(this.TextBox_LostFocus);
            
            #line default
            #line hidden
            return;
            case 8:
            
            #line 94 "..\..\..\Views\UsuariosView.xaml"
            ((System.Windows.Controls.TextBox)(target)).GotFocus += new System.Windows.RoutedEventHandler(this.TextBox_GotFocus);
            
            #line default
            #line hidden
            
            #line 94 "..\..\..\Views\UsuariosView.xaml"
            ((System.Windows.Controls.TextBox)(target)).LostFocus += new System.Windows.RoutedEventHandler(this.TextBox_LostFocus);
            
            #line default
            #line hidden
            return;
            case 9:
            
            #line 97 "..\..\..\Views\UsuariosView.xaml"
            ((System.Windows.Controls.TextBox)(target)).GotFocus += new System.Windows.RoutedEventHandler(this.TextBox_GotFocus);
            
            #line default
            #line hidden
            
            #line 97 "..\..\..\Views\UsuariosView.xaml"
            ((System.Windows.Controls.TextBox)(target)).LostFocus += new System.Windows.RoutedEventHandler(this.TextBox_LostFocus);
            
            #line default
            #line hidden
            return;
            case 10:
            
            #line 100 "..\..\..\Views\UsuariosView.xaml"
            ((System.Windows.Controls.TextBox)(target)).GotFocus += new System.Windows.RoutedEventHandler(this.TextBox_GotFocus);
            
            #line default
            #line hidden
            
            #line 100 "..\..\..\Views\UsuariosView.xaml"
            ((System.Windows.Controls.TextBox)(target)).LostFocus += new System.Windows.RoutedEventHandler(this.TextBox_LostFocus);
            
            #line default
            #line hidden
            return;
            case 11:
            
            #line 103 "..\..\..\Views\UsuariosView.xaml"
            ((MahApps.Metro.Controls.NumericUpDown)(target)).GotFocus += new System.Windows.RoutedEventHandler(this.NumericUpDown_GotFocus);
            
            #line default
            #line hidden
            
            #line 103 "..\..\..\Views\UsuariosView.xaml"
            ((MahApps.Metro.Controls.NumericUpDown)(target)).LostFocus += new System.Windows.RoutedEventHandler(this.NumericUpDown_LostFocus);
            
            #line default
            #line hidden
            return;
            case 12:
            
            #line 181 "..\..\..\Views\UsuariosView.xaml"
            ((System.Windows.Controls.DataGrid)(target)).GotFocus += new System.Windows.RoutedEventHandler(this.NumericUpDown_GotFocus);
            
            #line default
            #line hidden
            
            #line 181 "..\..\..\Views\UsuariosView.xaml"
            ((System.Windows.Controls.DataGrid)(target)).LostFocus += new System.Windows.RoutedEventHandler(this.NumericUpDown_LostFocus);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

