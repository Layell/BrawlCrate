﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18052
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
namespace BrawlCrate.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "11.0.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }

        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public ModelEditorSettings ViewerSettings
        {
            get
            {
                return ((ModelEditorSettings)(this["ViewerSettings"]));
            }
            set
            {
                this["ViewerSettings"] = value;
            }
        }

        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("false")]
        public bool ViewerSettingsSet
        {
            get
            {
                return ((bool)(this["ViewerSettingsSet"]));
            }
            set
            {
                this["ViewerSettingsSet"] = value;
            }
        }

        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::System.Collections.Specialized.StringCollection RecentFiles
        {
            get
            {
                return ((global::System.Collections.Specialized.StringCollection)(this["RecentFiles"]));
            }
            set
            {
                this["RecentFiles"] = value;
            }
        }

        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("10")]
        public int RecentFilesMax
        {
            get
            {
                return ((int)(this["RecentFilesMax"]));
            }
            set
            {
                this["RecentFilesMax"] = value;
            }
        }

        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("true")]
        public bool DisplayPropertyDescriptionWhenAvailable
        {
            get
            {
                return ((bool)(this["DisplayPropertyDescriptionWhenAvailable"]));
            }
            set
            {
                this["DisplayPropertyDescriptionWhenAvailable"] = value;
            }
        }

        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("true")]
        public bool CheckUpdatesAtStartup
        {
            get
            {
                return ((bool)(this["CheckUpdatesAtStartup"]));
            }
            set
            {
                this["CheckUpdatesAtStartup"] = value;
            }
        }

        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("true")]
        public bool UpdateAutomatically
        {
            get
            {
                return ((bool)(this["UpdateAutomatically"]));
            }
            set
            {
                this["UpdateAutomatically"] = value;
            }
        }

        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("true")]
        public bool GetDocumentationUpdates
        {
            get
            {
                return ((bool)(this["GetDocumentationUpdates"]));
            }
            set
            {
                this["GetDocumentationUpdates"] = value;
            }
        }

        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
#if DEBUG
        [global::System.Configuration.DefaultSettingValueAttribute("true")]
#else
        [global::System.Configuration.DefaultSettingValueAttribute("false")]
#endif
        public bool ShowHex
        {
            get
            {
                return ((bool)(this["ShowHex"]));
            }
            set
            {
                this["ShowHex"] = value;
            }
        }

        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("false")]
        public bool PixelLighting
        {
            get
            {
                return ((bool)(this["PixelLighting"]));
            }
            set
            {
                this["PixelLighting"] = value;
            }
        }

        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("true")]
        public bool ContextualLoop
        {
            get
            {
                return ((bool)(this["ContextualLoop"]));
            }
            set
            {
                this["ContextualLoop"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("true")]
        public bool UpdateSettings
        {
            get
            {
                return ((bool)(this["UpdateSettings"]));
            }
            set
            {
                this["UpdateSettings"] = value;
            }
        }
    }
}
