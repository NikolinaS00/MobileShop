﻿#pragma checksum "..\..\..\View\ProcurementPreviewReceiptWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "6E96843D33BDCB811F1E5900FF8AA57063BDD3B0A1A75D91965E0862172915D3"
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
    /// ProcurementPreviewReceiptWindow
    /// </summary>
    public partial class ProcurementPreviewReceiptWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 30 "..\..\..\View\ProcurementPreviewReceiptWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Border BorderTop;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\..\View\ProcurementPreviewReceiptWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label NameOfWindow;
        
        #line default
        #line hidden
        
        
        #line 55 "..\..\..\View\ProcurementPreviewReceiptWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button DeleteItemButton;
        
        #line default
        #line hidden
        
        
        #line 70 "..\..\..\View\ProcurementPreviewReceiptWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button PrintReceiptButton;
        
        #line default
        #line hidden
        
        
        #line 73 "..\..\..\View\ProcurementPreviewReceiptWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid DataGridItems;
        
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
            System.Uri resourceLocater = new System.Uri("/WpfApp1;component/view/procurementpreviewreceiptwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\View\ProcurementPreviewReceiptWindow.xaml"
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
            this.DeleteItemButton = ((System.Windows.Controls.Button)(target));
            
            #line 55 "..\..\..\View\ProcurementPreviewReceiptWindow.xaml"
            this.DeleteItemButton.Click += new System.Windows.RoutedEventHandler(this.DeleteItemButton_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.PrintReceiptButton = ((System.Windows.Controls.Button)(target));
            
            #line 70 "..\..\..\View\ProcurementPreviewReceiptWindow.xaml"
            this.PrintReceiptButton.Click += new System.Windows.RoutedEventHandler(this.PrintReceiptButton_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.DataGridItems = ((System.Windows.Controls.DataGrid)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

