﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.1
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace NClass.DiagramEditor {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "10.0.0.0")]
    public sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("5000")]
        public int DiagramWidth {
            get {
                return ((int)(this["DiagramWidth"]));
            }
            set {
                this["DiagramWidth"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("4000")]
        public int DiagramHeight {
            get {
                return ((int)(this["DiagramHeight"]));
            }
            set {
                this["DiagramHeight"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool UsePrecisionSnapping {
            get {
                return ((bool)(this["UsePrecisionSnapping"]));
            }
            set {
                this["UsePrecisionSnapping"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("AsNeeded")]
        public global::NClass.DiagramEditor.ClassDiagram.ChevronMode ShowChevron {
            get {
                return ((global::NClass.DiagramEditor.ClassDiagram.ChevronMode)(this["ShowChevron"]));
            }
            set {
                this["ShowChevron"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool ShowType {
            get {
                return ((bool)(this["ShowType"]));
            }
            set {
                this["ShowType"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool ShowParameters {
            get {
                return ((bool)(this["ShowParameters"]));
            }
            set {
                this["ShowParameters"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool ShowParameterNames {
            get {
                return ((bool)(this["ShowParameterNames"]));
            }
            set {
                this["ShowParameterNames"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool ShowInitialValue {
            get {
                return ((bool)(this["ShowInitialValue"]));
            }
            set {
                this["ShowInitialValue"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Never")]
        public global::NClass.DiagramEditor.ClassDiagram.ClearTypeMode UseClearType {
            get {
                return ((global::NClass.DiagramEditor.ClassDiagram.ClearTypeMode)(this["UseClearType"]));
            }
            set {
                this["UseClearType"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool UseClearTypeForImages {
            get {
                return ((bool)(this["UseClearTypeForImages"]));
            }
            set {
                this["UseClearTypeForImages"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::NClass.DiagramEditor.ClassDiagram.Dialogs.PrintingSettings PrintingSettings {
            get {
                return ((global::NClass.DiagramEditor.ClassDiagram.Dialogs.PrintingSettings)(this["PrintingSettings"]));
            }
            set {
                this["PrintingSettings"] = value;
            }
        }
    }
}
