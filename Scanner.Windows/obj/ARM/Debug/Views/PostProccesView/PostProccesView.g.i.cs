﻿

#pragma checksum "D:\Projects\Scanner\Windows\Scanner.Windows\Views\PostProccesView\PostProccesView.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "7DDDA1F74D3636508C17EB4F8095FE5D"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Scanner.Windows.Views.PostProccesView
{
    partial class PostProccesView : global::Scanner.Windows.Common.ViewBase
    {
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        private global::Scanner.Windows.Common.ViewBase PostProccesPage; 
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        private global::Scanner.Windows.ViewModels.PostProccesViewModel PostProccesViewModel; 
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        private global::Windows.UI.Xaml.Controls.MenuFlyout PresetsFlyout; 
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        private bool _contentLoaded;

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void InitializeComponent()
        {
            if (_contentLoaded)
                return;

            _contentLoaded = true;
            global::Windows.UI.Xaml.Application.LoadComponent(this, new global::System.Uri("ms-appx:///Views/PostProccesView/PostProccesView.xaml"), global::Windows.UI.Xaml.Controls.Primitives.ComponentResourceLocation.Application);
 
            PostProccesPage = (global::Scanner.Windows.Common.ViewBase)this.FindName("PostProccesPage");
            PostProccesViewModel = (global::Scanner.Windows.ViewModels.PostProccesViewModel)this.FindName("PostProccesViewModel");
            PresetsFlyout = (global::Windows.UI.Xaml.Controls.MenuFlyout)this.FindName("PresetsFlyout");
        }
    }
}


