﻿

#pragma checksum "D:\Projects\Scanner\Windows\Scanner.Windows\Views\DocumentView\DocumentView.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "DB90F31B48CB1DF107FEB4F8EB5E39AB"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Scanner.Windows.Views.DocumentView
{
    partial class DocumentView : global::Scanner.Windows.Common.ViewBase
    {
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        private global::Scanner.Windows.Common.ViewBase DocumentPage; 
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        private global::Windows.UI.Xaml.Controls.AppBar TopAppBar; 
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        private global::Windows.UI.Xaml.Controls.ComboBox CategoryNamesCombobox; 
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        private global::Windows.UI.Xaml.Controls.TextBox DocumentNameTextBox; 
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        private global::Windows.UI.Xaml.Controls.AppBar BottomAppBar; 
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        private bool _contentLoaded;

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void InitializeComponent()
        {
            if (_contentLoaded)
                return;

            _contentLoaded = true;
            global::Windows.UI.Xaml.Application.LoadComponent(this, new global::System.Uri("ms-appx:///Views/DocumentView/DocumentView.xaml"), global::Windows.UI.Xaml.Controls.Primitives.ComponentResourceLocation.Application);
 
            DocumentPage = (global::Scanner.Windows.Common.ViewBase)this.FindName("DocumentPage");
            TopAppBar = (global::Windows.UI.Xaml.Controls.AppBar)this.FindName("TopAppBar");
            CategoryNamesCombobox = (global::Windows.UI.Xaml.Controls.ComboBox)this.FindName("CategoryNamesCombobox");
            DocumentNameTextBox = (global::Windows.UI.Xaml.Controls.TextBox)this.FindName("DocumentNameTextBox");
            BottomAppBar = (global::Windows.UI.Xaml.Controls.AppBar)this.FindName("BottomAppBar");
        }
    }
}



