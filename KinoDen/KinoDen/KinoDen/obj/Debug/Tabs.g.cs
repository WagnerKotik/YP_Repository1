﻿#pragma checksum "..\..\Tabs.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "AED3C5CDDCD683E332E597865382F225C1600F57F548AC024EB4CDA1808168C4"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using KinoDen;
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


namespace KinoDen {
    
    
    /// <summary>
    /// Tabs
    /// </summary>
    public partial class Tabs : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 15 "..\..\Tabs.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel Otdel;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\Tabs.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Redact;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\Tabs.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView LViewFilm;
        
        #line default
        #line hidden
        
        
        #line 47 "..\..\Tabs.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView LViewZakup;
        
        #line default
        #line hidden
        
        
        #line 73 "..\..\Tabs.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel Rent;
        
        #line default
        #line hidden
        
        
        #line 79 "..\..\Tabs.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView LViewCinema;
        
        #line default
        #line hidden
        
        
        #line 106 "..\..\Tabs.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView LViewRent;
        
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
            System.Uri resourceLocater = new System.Uri("/KinoDen;component/tabs.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Tabs.xaml"
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
            this.Otdel = ((System.Windows.Controls.StackPanel)(target));
            return;
            case 2:
            this.Redact = ((System.Windows.Controls.Button)(target));
            
            #line 19 "..\..\Tabs.xaml"
            this.Redact.Click += new System.Windows.RoutedEventHandler(this.Redact_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.LViewFilm = ((System.Windows.Controls.ListView)(target));
            return;
            case 4:
            this.LViewZakup = ((System.Windows.Controls.ListView)(target));
            return;
            case 5:
            this.Rent = ((System.Windows.Controls.StackPanel)(target));
            return;
            case 6:
            this.LViewCinema = ((System.Windows.Controls.ListView)(target));
            return;
            case 7:
            this.LViewRent = ((System.Windows.Controls.ListView)(target));
            return;
            case 8:
            
            #line 141 "..\..\Tabs.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.ButtonPros);
            
            #line default
            #line hidden
            return;
            case 9:
            
            #line 148 "..\..\Tabs.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.ButtonReiting);
            
            #line default
            #line hidden
            return;
            case 10:
            
            #line 155 "..\..\Tabs.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.ButtonViruchka);
            
            #line default
            #line hidden
            return;
            case 11:
            
            #line 162 "..\..\Tabs.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.ButtonArenda);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

