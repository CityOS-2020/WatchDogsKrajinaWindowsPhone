﻿

#pragma checksum "c:\users\adim\documents\visual studio 2013\Projects\WatchDogsKrajina\WatchDogsKrajina\MainPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "9824631C265978F2C7D5AA7EB68D62C9"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WatchDogsKrajina
{
    partial class MainPage : global::Windows.UI.Xaml.Controls.Page, global::Windows.UI.Xaml.Markup.IComponentConnector
    {
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
 
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 1:
                #line 14 "..\..\MainPage.xaml"
                ((global::Windows.UI.Xaml.Controls.WebView)(target)).NavigationCompleted += this.Browser_NavigationCompleted;
                 #line default
                 #line hidden
                break;
            case 2:
                #line 24 "..\..\MainPage.xaml"
                ((global::Windows.UI.Xaml.Controls.Primitives.ButtonBase)(target)).Click += this.SwitchMapBtn_Click;
                 #line default
                 #line hidden
                break;
            case 3:
                #line 31 "..\..\MainPage.xaml"
                ((global::Windows.UI.Xaml.Controls.Primitives.ButtonBase)(target)).Click += this.CenterMapBtn_Click;
                 #line default
                 #line hidden
                break;
            case 4:
                #line 40 "..\..\MainPage.xaml"
                ((global::Windows.UI.Xaml.Controls.Primitives.ButtonBase)(target)).Click += this.DodatneBtn_Click;
                 #line default
                 #line hidden
                break;
            }
            this._contentLoaded = true;
        }
    }
}

