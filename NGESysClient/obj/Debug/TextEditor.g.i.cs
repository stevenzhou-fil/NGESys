﻿#pragma checksum "..\..\TextEditor.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4C671E0B6DF680D6D8A05ED8BE310D11AC853E55"
//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

using NGESysClient;
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


namespace NGESysClient {
    
    
    /// <summary>
    /// TextEditor
    /// </summary>
    public partial class TextEditor : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 8 "..\..\TextEditor.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal NGESysClient.TextEditor TextEditorPage;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\TextEditor.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox editorFontToolBarCb;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\TextEditor.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox editorSizeToolBarCb;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\TextEditor.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button addArticleSubmitButton;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\TextEditor.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button editorSaveAsButton;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\TextEditor.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox titleTextBox;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\TextEditor.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RichTextBox editorRichTextBox;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\TextEditor.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label RichTextBoxStatus;
        
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
            System.Uri resourceLocater = new System.Uri("/NGESysClient;component/texteditor.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\TextEditor.xaml"
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
            this.TextEditorPage = ((NGESysClient.TextEditor)(target));
            
            #line 9 "..\..\TextEditor.xaml"
            this.TextEditorPage.Loaded += new System.Windows.RoutedEventHandler(this.TextEditorPage_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.editorFontToolBarCb = ((System.Windows.Controls.ComboBox)(target));
            
            #line 22 "..\..\TextEditor.xaml"
            this.editorFontToolBarCb.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.editorFontToolBarCb_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.editorSizeToolBarCb = ((System.Windows.Controls.ComboBox)(target));
            
            #line 24 "..\..\TextEditor.xaml"
            this.editorSizeToolBarCb.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.editorSizeToolBarCb_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.addArticleSubmitButton = ((System.Windows.Controls.Button)(target));
            
            #line 25 "..\..\TextEditor.xaml"
            this.addArticleSubmitButton.Click += new System.Windows.RoutedEventHandler(this.addArticleSubmitButton_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.editorSaveAsButton = ((System.Windows.Controls.Button)(target));
            
            #line 26 "..\..\TextEditor.xaml"
            this.editorSaveAsButton.Click += new System.Windows.RoutedEventHandler(this.editorSaveAsButton_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.titleTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.editorRichTextBox = ((System.Windows.Controls.RichTextBox)(target));
            return;
            case 8:
            
            #line 34 "..\..\TextEditor.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.MenuItem_Click_Copy);
            
            #line default
            #line hidden
            return;
            case 9:
            
            #line 35 "..\..\TextEditor.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.MenuItem_Click_Cut);
            
            #line default
            #line hidden
            return;
            case 10:
            
            #line 36 "..\..\TextEditor.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.MenuItem_Click_Paste);
            
            #line default
            #line hidden
            return;
            case 11:
            this.RichTextBoxStatus = ((System.Windows.Controls.Label)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}
