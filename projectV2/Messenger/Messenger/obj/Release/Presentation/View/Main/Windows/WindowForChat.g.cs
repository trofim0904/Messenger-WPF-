﻿#pragma checksum "..\..\..\..\..\..\Presentation\View\Main\Windows\WindowForChat.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "D206D84790DB84395ACF437790FE9E9E1CFA9D1E"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using Messenger.Presentation.View.Main.Windows;
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


namespace Messenger.Presentation.View.Main.Windows {
    
    
    /// <summary>
    /// WindowForChat
    /// </summary>
    public partial class WindowForChat : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 26 "..\..\..\..\..\..\Presentation\View\Main\Windows\WindowForChat.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock _statusTb;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\..\..\..\..\Presentation\View\Main\Windows\WindowForChat.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image _chatImg;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\..\..\..\..\Presentation\View\Main\Windows\WindowForChat.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel _messagesSp;
        
        #line default
        #line hidden
        
        
        #line 53 "..\..\..\..\..\..\Presentation\View\Main\Windows\WindowForChat.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox _inputMessageTb;
        
        #line default
        #line hidden
        
        
        #line 60 "..\..\..\..\..\..\Presentation\View\Main\Windows\WindowForChat.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button _sendInfo;
        
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
            System.Uri resourceLocater = new System.Uri("/Messenger;component/presentation/view/main/windows/windowforchat.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\..\Presentation\View\Main\Windows\WindowForChat.xaml"
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
            this._statusTb = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 2:
            this._chatImg = ((System.Windows.Controls.Image)(target));
            return;
            case 3:
            this._messagesSp = ((System.Windows.Controls.StackPanel)(target));
            return;
            case 4:
            this._inputMessageTb = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this._sendInfo = ((System.Windows.Controls.Button)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}
