﻿#pragma checksum "..\..\mailwindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "E7A05F887188B96971865B215480C1C946416FFD7F6E59DA64104CA7CE150388"
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
using parser4mails;


namespace parser4mails {
    
    
    /// <summary>
    /// mailwindow
    /// </summary>
    public partial class mailwindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 15 "..\..\mailwindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.WebBrowser preview_browser;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\mailwindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label zadeva_label;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\mailwindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label email_label;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\mailwindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label optin_label;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\mailwindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label optout_label;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\mailwindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label affiliate_label;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\mailwindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox email_tbox;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\mailwindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox optin_tbox;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\mailwindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox optout_tbox;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\mailwindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox affiliate_tbox;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\mailwindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button email_btn;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\mailwindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button optin_btn;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\mailwindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button optout_btn;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\mailwindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button affiliate_btn;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\mailwindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button objavi_btn;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\mailwindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button izbriši_btn;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\mailwindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button izbrisi_potrdi_btn;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\mailwindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RichTextBox richtb;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\mailwindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button blacklist_btn;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\mailwindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label duration_label;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\mailwindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox duration_tbox;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\mailwindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button duration_btn;
        
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
            System.Uri resourceLocater = new System.Uri("/parser4mails;component/mailwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\mailwindow.xaml"
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
            this.preview_browser = ((System.Windows.Controls.WebBrowser)(target));
            return;
            case 2:
            this.zadeva_label = ((System.Windows.Controls.Label)(target));
            return;
            case 3:
            this.email_label = ((System.Windows.Controls.Label)(target));
            return;
            case 4:
            this.optin_label = ((System.Windows.Controls.Label)(target));
            return;
            case 5:
            this.optout_label = ((System.Windows.Controls.Label)(target));
            return;
            case 6:
            this.affiliate_label = ((System.Windows.Controls.Label)(target));
            return;
            case 7:
            this.email_tbox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            this.optin_tbox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 9:
            this.optout_tbox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 10:
            this.affiliate_tbox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 11:
            this.email_btn = ((System.Windows.Controls.Button)(target));
            
            #line 25 "..\..\mailwindow.xaml"
            this.email_btn.Click += new System.Windows.RoutedEventHandler(this.Email_btn_Click);
            
            #line default
            #line hidden
            return;
            case 12:
            this.optin_btn = ((System.Windows.Controls.Button)(target));
            
            #line 26 "..\..\mailwindow.xaml"
            this.optin_btn.Click += new System.Windows.RoutedEventHandler(this.Optin_btn_Click);
            
            #line default
            #line hidden
            return;
            case 13:
            this.optout_btn = ((System.Windows.Controls.Button)(target));
            
            #line 27 "..\..\mailwindow.xaml"
            this.optout_btn.Click += new System.Windows.RoutedEventHandler(this.Optout_btn_Click);
            
            #line default
            #line hidden
            return;
            case 14:
            this.affiliate_btn = ((System.Windows.Controls.Button)(target));
            
            #line 28 "..\..\mailwindow.xaml"
            this.affiliate_btn.Click += new System.Windows.RoutedEventHandler(this.Affiliate_btn_Click);
            
            #line default
            #line hidden
            return;
            case 15:
            this.objavi_btn = ((System.Windows.Controls.Button)(target));
            
            #line 29 "..\..\mailwindow.xaml"
            this.objavi_btn.Click += new System.Windows.RoutedEventHandler(this.Objavi_btn_Click);
            
            #line default
            #line hidden
            return;
            case 16:
            this.izbriši_btn = ((System.Windows.Controls.Button)(target));
            
            #line 30 "..\..\mailwindow.xaml"
            this.izbriši_btn.Click += new System.Windows.RoutedEventHandler(this.Izbrisi_btn_Click);
            
            #line default
            #line hidden
            return;
            case 17:
            this.izbrisi_potrdi_btn = ((System.Windows.Controls.Button)(target));
            
            #line 31 "..\..\mailwindow.xaml"
            this.izbrisi_potrdi_btn.Click += new System.Windows.RoutedEventHandler(this.Izbrisi_potrdi_btn_Click);
            
            #line default
            #line hidden
            return;
            case 18:
            this.richtb = ((System.Windows.Controls.RichTextBox)(target));
            return;
            case 19:
            this.blacklist_btn = ((System.Windows.Controls.Button)(target));
            
            #line 40 "..\..\mailwindow.xaml"
            this.blacklist_btn.Click += new System.Windows.RoutedEventHandler(this.Blacklist_btn_Click_1);
            
            #line default
            #line hidden
            return;
            case 20:
            this.duration_label = ((System.Windows.Controls.Label)(target));
            return;
            case 21:
            this.duration_tbox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 22:
            this.duration_btn = ((System.Windows.Controls.Button)(target));
            
            #line 43 "..\..\mailwindow.xaml"
            this.duration_btn.Click += new System.Windows.RoutedEventHandler(this.Duration_btn_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

