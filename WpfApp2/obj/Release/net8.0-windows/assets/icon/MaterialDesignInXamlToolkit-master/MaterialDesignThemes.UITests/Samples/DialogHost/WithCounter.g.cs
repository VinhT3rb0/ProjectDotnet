﻿#pragma checksum "..\..\..\..\..\..\..\..\..\assets\icon\MaterialDesignInXamlToolkit-master\MaterialDesignThemes.UITests\Samples\DialogHost\WithCounter.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1513283CF09AF1489086FAFE7F1154C15BAF91B6"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using MaterialDesignThemes.Wpf;
using MaterialDesignThemes.Wpf.Converters;
using MaterialDesignThemes.Wpf.Transitions;
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


namespace MaterialDesignThemes.UITests.Samples.DialogHost {
    
    
    /// <summary>
    /// WithCounter
    /// </summary>
    public partial class WithCounter : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 14 "..\..\..\..\..\..\..\..\..\assets\icon\MaterialDesignInXamlToolkit-master\MaterialDesignThemes.UITests\Samples\DialogHost\WithCounter.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button CloseDialogButton;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\..\..\..\..\..\..\..\assets\icon\MaterialDesignInXamlToolkit-master\MaterialDesignThemes.UITests\Samples\DialogHost\WithCounter.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ShowDialogButton;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\..\..\..\..\..\..\..\assets\icon\MaterialDesignInXamlToolkit-master\MaterialDesignThemes.UITests\Samples\DialogHost\WithCounter.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button TestOverlayButton;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\..\..\..\..\..\..\..\assets\icon\MaterialDesignInXamlToolkit-master\MaterialDesignThemes.UITests\Samples\DialogHost\WithCounter.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock ResultTextBlock;
        
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
            System.Uri resourceLocater = new System.Uri("/WpfApp2;component/assets/icon/materialdesigninxamltoolkit-master/materialdesignt" +
                    "hemes.uitests/samples/dialoghost/withcounter.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\..\..\..\..\assets\icon\MaterialDesignInXamlToolkit-master\MaterialDesignThemes.UITests\Samples\DialogHost\WithCounter.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
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
            this.CloseDialogButton = ((System.Windows.Controls.Button)(target));
            return;
            case 2:
            this.ShowDialogButton = ((System.Windows.Controls.Button)(target));
            return;
            case 3:
            this.TestOverlayButton = ((System.Windows.Controls.Button)(target));
            
            #line 26 "..\..\..\..\..\..\..\..\..\assets\icon\MaterialDesignInXamlToolkit-master\MaterialDesignThemes.UITests\Samples\DialogHost\WithCounter.xaml"
            this.TestOverlayButton.Click += new System.Windows.RoutedEventHandler(this.TestOverlayClick);
            
            #line default
            #line hidden
            return;
            case 4:
            this.ResultTextBlock = ((System.Windows.Controls.TextBlock)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

