//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BTSxfrag {
    using System;
    using Xamarin.Forms;
    using Xamarin.Forms.Xaml;
    
    
    public partial class IfconfugPage : global::Xamarin.Forms.ContentPage {
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "0.0.0.0")]
        private global::Xamarin.Forms.Entry EntryIp;
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "0.0.0.0")]
        private global::Xamarin.Forms.Entry EntryMasque;
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "0.0.0.0")]
        private global::Xamarin.Forms.Entry EntryCapteur;
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "0.0.0.0")]
        private global::Xamarin.Forms.Entry EntryVers;
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "0.0.0.0")]
        private global::Xamarin.Forms.Label LabelError;
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "0.0.0.0")]
        private void InitializeComponent() {
            this.LoadFromXaml(typeof(IfconfugPage));
            EntryIp = this.FindByName<global::Xamarin.Forms.Entry>("EntryIp");
            EntryMasque = this.FindByName<global::Xamarin.Forms.Entry>("EntryMasque");
            EntryCapteur = this.FindByName<global::Xamarin.Forms.Entry>("EntryCapteur");
            EntryVers = this.FindByName<global::Xamarin.Forms.Entry>("EntryVers");
            LabelError = this.FindByName<global::Xamarin.Forms.Label>("LabelError");
        }
    }
}
