﻿#pragma checksum "..\..\..\View\EmployeesView.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "D8406545D041541CCFB517EA8B3230EC589F7D9ABBF13EE530AC9005FDFDF013"
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
using WpfApp1.Model;
using WpfApp1.View;


namespace WpfApp1.View {
    
    
    /// <summary>
    /// EmployeesView
    /// </summary>
    public partial class EmployeesView : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 24 "..\..\..\View\EmployeesView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Border BorderTop;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\..\View\EmployeesView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label NameOfWindow;
        
        #line default
        #line hidden
        
        
        #line 55 "..\..\..\View\EmployeesView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ButtonAdd1;
        
        #line default
        #line hidden
        
        
        #line 56 "..\..\..\View\EmployeesView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ButtonEdit1;
        
        #line default
        #line hidden
        
        
        #line 57 "..\..\..\View\EmployeesView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ButtonDelete1;
        
        #line default
        #line hidden
        
        
        #line 63 "..\..\..\View\EmployeesView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox SearchTxtBox;
        
        #line default
        #line hidden
        
        
        #line 64 "..\..\..\View\EmployeesView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button SearchButton;
        
        #line default
        #line hidden
        
        
        #line 67 "..\..\..\View\EmployeesView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button RefreshButton;
        
        #line default
        #line hidden
        
        
        #line 77 "..\..\..\View\EmployeesView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid daataGridEmployees;
        
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
            System.Uri resourceLocater = new System.Uri("/WpfApp1;component/view/employeesview.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\View\EmployeesView.xaml"
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
            this.BorderTop = ((System.Windows.Controls.Border)(target));
            return;
            case 2:
            this.NameOfWindow = ((System.Windows.Controls.Label)(target));
            return;
            case 3:
            this.ButtonAdd1 = ((System.Windows.Controls.Button)(target));
            
            #line 55 "..\..\..\View\EmployeesView.xaml"
            this.ButtonAdd1.Click += new System.Windows.RoutedEventHandler(this.ButtonAdd1_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.ButtonEdit1 = ((System.Windows.Controls.Button)(target));
            
            #line 56 "..\..\..\View\EmployeesView.xaml"
            this.ButtonEdit1.Click += new System.Windows.RoutedEventHandler(this.ButtonEdit1_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.ButtonDelete1 = ((System.Windows.Controls.Button)(target));
            
            #line 57 "..\..\..\View\EmployeesView.xaml"
            this.ButtonDelete1.Click += new System.Windows.RoutedEventHandler(this.ButtonDelete1_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.SearchTxtBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.SearchButton = ((System.Windows.Controls.Button)(target));
            
            #line 64 "..\..\..\View\EmployeesView.xaml"
            this.SearchButton.Click += new System.Windows.RoutedEventHandler(this.SearchButton_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.RefreshButton = ((System.Windows.Controls.Button)(target));
            
            #line 67 "..\..\..\View\EmployeesView.xaml"
            this.RefreshButton.Click += new System.Windows.RoutedEventHandler(this.RefreshButton_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.daataGridEmployees = ((System.Windows.Controls.DataGrid)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

