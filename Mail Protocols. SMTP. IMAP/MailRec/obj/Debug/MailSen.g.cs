﻿#pragma checksum "..\..\MailSen.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "64A0B96C85B33871FB2FAA2343BD75ED6783913A8F6B1B5518128E9302E13BDB"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using MailRec;
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


namespace MailRec {
    
    
    /// <summary>
    /// MailSen
    /// </summary>
    public partial class MailSen : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 33 "..\..\MailSen.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Totext;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\MailSen.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox themeText;
        
        #line default
        #line hidden
        
        
        #line 44 "..\..\MailSen.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button byttonAttach;
        
        #line default
        #line hidden
        
        
        #line 45 "..\..\MailSen.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox ListAttachFile;
        
        #line default
        #line hidden
        
        
        #line 46 "..\..\MailSen.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox bodyText;
        
        #line default
        #line hidden
        
        
        #line 47 "..\..\MailSen.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button byttonLetter;
        
        #line default
        #line hidden
        
        
        #line 48 "..\..\MailSen.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button byttonSend;
        
        #line default
        #line hidden
        
        
        #line 49 "..\..\MailSen.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox checkboxPriority;
        
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
            System.Uri resourceLocater = new System.Uri("/MailRec;component/mailsen.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\MailSen.xaml"
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
            this.Totext = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.themeText = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.byttonAttach = ((System.Windows.Controls.Button)(target));
            
            #line 44 "..\..\MailSen.xaml"
            this.byttonAttach.Click += new System.Windows.RoutedEventHandler(this.byttonAttach_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.ListAttachFile = ((System.Windows.Controls.ListBox)(target));
            return;
            case 5:
            this.bodyText = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.byttonLetter = ((System.Windows.Controls.Button)(target));
            
            #line 47 "..\..\MailSen.xaml"
            this.byttonLetter.Click += new System.Windows.RoutedEventHandler(this.byttonLetter_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.byttonSend = ((System.Windows.Controls.Button)(target));
            
            #line 48 "..\..\MailSen.xaml"
            this.byttonSend.Click += new System.Windows.RoutedEventHandler(this.byttonSend_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.checkboxPriority = ((System.Windows.Controls.CheckBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}
