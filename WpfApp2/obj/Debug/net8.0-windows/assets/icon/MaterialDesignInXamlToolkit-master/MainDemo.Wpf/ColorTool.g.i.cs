﻿#pragma checksum "..\..\..\..\..\..\..\assets\icon\MaterialDesignInXamlToolkit-master\MainDemo.Wpf\ColorTool.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "B993E54B87EACC230CCE7E76B2B7B67DC02982D6"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using MaterialDesignColors;
using MaterialDesignDemo;
using MaterialDesignDemo.Converters;
using MaterialDesignDemo.Domain;
using MaterialDesignThemes.Wpf;
using MaterialDesignThemes.Wpf.Converters;
using MaterialDesignThemes.Wpf.Transitions;
using ShowMeTheXAML;
using ShowMeTheXAML.AvalonEdit;
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


namespace MaterialDesignDemo {
    
    
    /// <summary>
    /// ColorTool
    /// </summary>
    public partial class ColorTool : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 468 "..\..\..\..\..\..\..\assets\icon\MaterialDesignInXamlToolkit-master\MainDemo.Wpf\ColorTool.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton MdPaletteButton;
        
        #line default
        #line hidden
        
        
        #line 474 "..\..\..\..\..\..\..\assets\icon\MaterialDesignInXamlToolkit-master\MainDemo.Wpf\ColorTool.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton CustomPaletteButton;
        
        #line default
        #line hidden
        
        
        #line 498 "..\..\..\..\..\..\..\assets\icon\MaterialDesignInXamlToolkit-master\MainDemo.Wpf\ColorTool.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal MaterialDesignThemes.Wpf.ColorPicker ColorPicker;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/WpfApp2;V1.0.0.0;component/assets/icon/materialdesigninxamltoolkit-master/mainde" +
                    "mo.wpf/colortool.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\..\..\assets\icon\MaterialDesignInXamlToolkit-master\MainDemo.Wpf\ColorTool.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.0.0")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal System.Delegate _CreateDelegate(System.Type delegateType, string handler) {
            return System.Delegate.CreateDelegate(delegateType, this, handler);
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.MdPaletteButton = ((System.Windows.Controls.RadioButton)(target));
            return;
            case 2:
            this.CustomPaletteButton = ((System.Windows.Controls.RadioButton)(target));
            return;
            case 3:
            this.ColorPicker = ((MaterialDesignThemes.Wpf.ColorPicker)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

