﻿#pragma checksum "..\..\..\UserSettings\UserSettingsView.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "971112DABB935AF58CEFFA5ADB6D4F12"
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


namespace HotspotMe.UserSettings {
    
    
    /// <summary>
    /// UserSettingsView
    /// </summary>
    public partial class UserSettingsView : FirstFloor.ModernUI.Windows.Controls.ModernWindow, System.Windows.Markup.IComponentConnector {
        
        
        #line 18 "..\..\..\UserSettings\UserSettingsView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cb_NetworkInterfaces;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\..\UserSettings\UserSettingsView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_save;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\..\UserSettings\UserSettingsView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_cancel;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\..\UserSettings\UserSettingsView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox cBox_showDialog;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\..\UserSettings\UserSettingsView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton rb_dark;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\..\UserSettings\UserSettingsView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton rb_light;
        
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
            System.Uri resourceLocater = new System.Uri("/HotspotMe;component/usersettings/usersettingsview.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\UserSettings\UserSettingsView.xaml"
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
            
            #line 9 "..\..\..\UserSettings\UserSettingsView.xaml"
            ((HotspotMe.UserSettings.UserSettingsView)(target)).MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.ModernWindow_MouseLeftButtonDown);
            
            #line default
            #line hidden
            
            #line 9 "..\..\..\UserSettings\UserSettingsView.xaml"
            ((HotspotMe.UserSettings.UserSettingsView)(target)).Loaded += new System.Windows.RoutedEventHandler(this.ModernWindow_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            
            #line 13 "..\..\..\UserSettings\UserSettingsView.xaml"
            ((System.Windows.Documents.Hyperlink)(target)).RequestNavigate += new System.Windows.Navigation.RequestNavigateEventHandler(this.networkadapterLink);
            
            #line default
            #line hidden
            return;
            case 3:
            this.cb_NetworkInterfaces = ((System.Windows.Controls.ComboBox)(target));
            
            #line 18 "..\..\..\UserSettings\UserSettingsView.xaml"
            this.cb_NetworkInterfaces.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.cb_NetworkInterfaces_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.btn_save = ((System.Windows.Controls.Button)(target));
            
            #line 20 "..\..\..\UserSettings\UserSettingsView.xaml"
            this.btn_save.Click += new System.Windows.RoutedEventHandler(this.btn_save_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.btn_cancel = ((System.Windows.Controls.Button)(target));
            
            #line 21 "..\..\..\UserSettings\UserSettingsView.xaml"
            this.btn_cancel.Click += new System.Windows.RoutedEventHandler(this.btn_cancel_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.cBox_showDialog = ((System.Windows.Controls.CheckBox)(target));
            return;
            case 7:
            this.rb_dark = ((System.Windows.Controls.RadioButton)(target));
            
            #line 25 "..\..\..\UserSettings\UserSettingsView.xaml"
            this.rb_dark.Checked += new System.Windows.RoutedEventHandler(this.rb_dark_Checked);
            
            #line default
            #line hidden
            return;
            case 8:
            this.rb_light = ((System.Windows.Controls.RadioButton)(target));
            
            #line 26 "..\..\..\UserSettings\UserSettingsView.xaml"
            this.rb_light.Checked += new System.Windows.RoutedEventHandler(this.rb_light_Checked);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

