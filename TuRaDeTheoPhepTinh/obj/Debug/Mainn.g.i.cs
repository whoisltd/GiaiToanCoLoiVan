﻿#pragma checksum "..\..\Mainn.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "58EF0AC2472C2577186CB8675B042833D8487BB67C2569377AF77AB0F5D864F8"
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
using TuRaDeTheoPhepTinh;


namespace TuRaDeTheoPhepTinh {
    
    
    /// <summary>
    /// Mainn
    /// </summary>
    public partial class Mainn : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 19 "..\..\Mainn.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button TuRaDe;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\Mainn.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ChonDapAn;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\Mainn.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel sp4;
        
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
            System.Uri resourceLocater = new System.Uri("/TuRaDeTheoPhepTinh;component/mainn.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Mainn.xaml"
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
            this.TuRaDe = ((System.Windows.Controls.Button)(target));
            
            #line 19 "..\..\Mainn.xaml"
            this.TuRaDe.Click += new System.Windows.RoutedEventHandler(this.TuRaDe_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.ChonDapAn = ((System.Windows.Controls.Button)(target));
            
            #line 22 "..\..\Mainn.xaml"
            this.ChonDapAn.Click += new System.Windows.RoutedEventHandler(this.ChonDapAn_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.sp4 = ((System.Windows.Controls.StackPanel)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

