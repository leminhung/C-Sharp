﻿#pragma checksum "..\..\..\Window2.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "D1D9DFFE1542A892D4634E9EB4C7DC888732860B"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using LeMinhHung_2019601690;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
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


namespace LeMinhHung_2019601690 {
    
    
    /// <summary>
    /// Window2
    /// </summary>
    public partial class Window2 : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 13 "..\..\..\Window2.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txt_manv;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\..\Window2.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txt_hoten;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\..\Window2.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txt_tienluong;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\..\Window2.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txt_songaylamviec;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\..\Window2.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton rdnam;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\..\Window2.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton rdnu;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\..\Window2.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker datepicker;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\..\Window2.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txt_tongluong;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\..\Window2.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_thoat;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "6.0.4.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/LeMinhHung_2019601690;component/window2.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Window2.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "6.0.4.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.txt_manv = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.txt_hoten = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.txt_tienluong = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.txt_songaylamviec = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.rdnam = ((System.Windows.Controls.RadioButton)(target));
            return;
            case 6:
            this.rdnu = ((System.Windows.Controls.RadioButton)(target));
            return;
            case 7:
            this.datepicker = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 8:
            this.txt_tongluong = ((System.Windows.Controls.TextBox)(target));
            return;
            case 9:
            this.btn_thoat = ((System.Windows.Controls.Button)(target));
            
            #line 27 "..\..\..\Window2.xaml"
            this.btn_thoat.Click += new System.Windows.RoutedEventHandler(this.btn_close);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
