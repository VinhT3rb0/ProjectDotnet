﻿#pragma checksum "..\..\..\..\View\ThongTinPhim.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "E85BD6411EE2DBC069BAB1D8E5CA2192A371B896"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using FontAwesome.Sharp;
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
using WpfApp2.View;


namespace WpfApp2.View {
    
    
    /// <summary>
    /// ThongTinPhim
    /// </summary>
    public partial class ThongTinPhim : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 50 "..\..\..\..\View\ThongTinPhim.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnClose;
        
        #line default
        #line hidden
        
        
        #line 93 "..\..\..\..\View\ThongTinPhim.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image imgPoster;
        
        #line default
        #line hidden
        
        
        #line 157 "..\..\..\..\View\ThongTinPhim.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label txtTenPhim;
        
        #line default
        #line hidden
        
        
        #line 162 "..\..\..\..\View\ThongTinPhim.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label txtDaoDien;
        
        #line default
        #line hidden
        
        
        #line 167 "..\..\..\..\View\ThongTinPhim.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label txtTheLoai;
        
        #line default
        #line hidden
        
        
        #line 172 "..\..\..\..\View\ThongTinPhim.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label txtQuocGia;
        
        #line default
        #line hidden
        
        
        #line 177 "..\..\..\..\View\ThongTinPhim.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label txtThoiLuong;
        
        #line default
        #line hidden
        
        
        #line 187 "..\..\..\..\View\ThongTinPhim.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock txtMoTa;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.3.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/WpfApp2;component/view/thongtinphim.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\View\ThongTinPhim.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.3.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.btnClose = ((System.Windows.Controls.Button)(target));
            
            #line 60 "..\..\..\..\View\ThongTinPhim.xaml"
            this.btnClose.Click += new System.Windows.RoutedEventHandler(this.btnClose_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.imgPoster = ((System.Windows.Controls.Image)(target));
            return;
            case 3:
            this.txtTenPhim = ((System.Windows.Controls.Label)(target));
            return;
            case 4:
            this.txtDaoDien = ((System.Windows.Controls.Label)(target));
            return;
            case 5:
            this.txtTheLoai = ((System.Windows.Controls.Label)(target));
            return;
            case 6:
            this.txtQuocGia = ((System.Windows.Controls.Label)(target));
            return;
            case 7:
            this.txtThoiLuong = ((System.Windows.Controls.Label)(target));
            return;
            case 8:
            this.txtMoTa = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 9:
            
            #line 196 "..\..\..\..\View\ThongTinPhim.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.btnSelectRoom);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

