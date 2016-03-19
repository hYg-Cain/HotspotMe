﻿#pragma checksum "..\..\MainWindow.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "A8D28246F27D0A936799A4526C38CDDE"
//------------------------------------------------------------------------------
// <auto-generated>
//     Dieser Code wurde von einem Tool generiert.
//     Laufzeitversion:4.0.30319.42000
//
//     Änderungen an dieser Datei können falsches Verhalten verursachen und gehen verloren, wenn
//     der Code erneut generiert wird.
// </auto-generated>
//------------------------------------------------------------------------------

using FirstFloor.ModernUI.Presentation;
using FirstFloor.ModernUI.Windows;
using FirstFloor.ModernUI.Windows.Controls;
using FirstFloor.ModernUI.Windows.Converters;
using FirstFloor.ModernUI.Windows.Navigation;
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


namespace HotspotMe {
    
    
    /// <summary>
    /// MainWindow
    /// </summary>
    public partial class MainWindow : FirstFloor.ModernUI.Windows.Controls.ModernWindow, System.Windows.Markup.IComponentConnector {
        
        
        #line 11 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_settings;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_help;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txt_ssid;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox txt_password;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox txt_confirmpassword;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_setHotspot;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_startHotspot;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_stopHotspot;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox cb_persistent;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lbl_monitor;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MediaElement mE_wlangif;
        
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
            System.Uri resourceLocater = new System.Uri("/HotspotMe;component/mainwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\MainWindow.xaml"
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
            
            #line 7 "..\..\MainWindow.xaml"
            ((HotspotMe.MainWindow)(target)).Closing += new System.ComponentModel.CancelEventHandler(this.ModernWindow_Closing);
            
            #line default
            #line hidden
            return;
            case 2:
            this.btn_settings = ((System.Windows.Controls.Button)(target));
            
            #line 11 "..\..\MainWindow.xaml"
            this.btn_settings.Click += new System.Windows.RoutedEventHandler(this.settings_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.btn_help = ((System.Windows.Controls.Button)(target));
            
            #line 12 "..\..\MainWindow.xaml"
            this.btn_help.Click += new System.Windows.RoutedEventHandler(this.btn_help_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.txt_ssid = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.txt_password = ((System.Windows.Controls.PasswordBox)(target));
            return;
            case 6:
            this.txt_confirmpassword = ((System.Windows.Controls.PasswordBox)(target));
            
            #line 16 "..\..\MainWindow.xaml"
            this.txt_confirmpassword.PasswordChanged += new System.Windows.RoutedEventHandler(this.txt_confirmpassword_PasswordChanged);
            
            #line default
            #line hidden
            return;
            case 7:
            this.btn_setHotspot = ((System.Windows.Controls.Button)(target));
            
            #line 17 "..\..\MainWindow.xaml"
            this.btn_setHotspot.Click += new System.Windows.RoutedEventHandler(this.btn_setHotspot_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.btn_startHotspot = ((System.Windows.Controls.Button)(target));
            
            #line 18 "..\..\MainWindow.xaml"
            this.btn_startHotspot.Click += new System.Windows.RoutedEventHandler(this.btn_startHotspot_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.btn_stopHotspot = ((System.Windows.Controls.Button)(target));
            
            #line 19 "..\..\MainWindow.xaml"
            this.btn_stopHotspot.Click += new System.Windows.RoutedEventHandler(this.btn_stopHotspot_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            this.cb_persistent = ((System.Windows.Controls.CheckBox)(target));
            return;
            case 11:
            
            #line 28 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.Canvas)(target)).MouseEnter += new System.Windows.Input.MouseEventHandler(this.MouseHoverEnter);
            
            #line default
            #line hidden
            
            #line 28 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.Canvas)(target)).MouseLeave += new System.Windows.Input.MouseEventHandler(this.MouseHoverLeave);
            
            #line default
            #line hidden
            
            #line 28 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.Canvas)(target)).MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.Explanation_Click);
            
            #line default
            #line hidden
            return;
            case 12:
            this.lbl_monitor = ((System.Windows.Controls.Label)(target));
            return;
            case 13:
            this.mE_wlangif = ((System.Windows.Controls.MediaElement)(target));
            
            #line 35 "..\..\MainWindow.xaml"
            this.mE_wlangif.MediaEnded += new System.Windows.RoutedEventHandler(this.myGif_MediaEnded);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

