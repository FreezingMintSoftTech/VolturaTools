﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DiskSpace.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "15.1.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));

        //public event System.EventHandler DriveChanged;
        //private static readonly object Locker = new object();

        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        ///// <summary>
        ///// Drive to report free space on
        ///// </summary>
        //[global::System.Configuration.UserScopedSettingAttribute()]
        //[global::System.Configuration.SettingsDescriptionAttribute("Drive to report free space on")]
        //[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        //[global::System.Configuration.DefaultSettingValueAttribute("C")]
        //public string driveLetter {
        //    get {
        //        return ((string)(this["driveLetter"]));
        //    }
        //    set {
        //        lock (Locker)
        //        {
        //            if (this["driveLetter"].ToString() != value)
        //            {
        //                this["driveLetter"] = value;
        //                DriveChanged?.Invoke(this, System.EventArgs.Empty);
        //            }
        //        }
        //    }
        //}
        
        /// <summary>
        /// Show application form topmost
        /// </summary>
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Configuration.SettingsDescriptionAttribute("Show application form topmost")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool alwaysOnTop {
            get {
                return ((bool)(this["alwaysOnTop"]));
            }
            set {
                this["alwaysOnTop"] = value;
            }
        }
        
        /// <summary>
        /// Start application without displaying form
        /// </summary>
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Configuration.SettingsDescriptionAttribute("Start application without displaying form")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool startMinimized {
            get {
                return ((bool)(this["startMinimized"]));
            }
            set {
                this["startMinimized"] = value;
            }
        }
        
        /// <summary>
        /// Start application automatically with Windows
        /// </summary>
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Configuration.SettingsDescriptionAttribute("Start application automatically with Windows")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool startWithWindows {
            get {
                return ((bool)(this["startWithWindows"]));
            }
            set {
                this["startWithWindows"] = value;
            }
        }
        
        /// <summary>
        /// Display Balloon notification when free disk space changes
        /// </summary>
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Configuration.SettingsDescriptionAttribute("Display Balloon notification when free disk space changes")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool notifyWhenSpaceChange {
            get {
                return ((bool)(this["notifyWhenSpaceChange"]));
            }
            set {
                this["notifyWhenSpaceChange"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("700")]
        public uint NotificationLimitGB {
            get {
                return ((uint)(this["NotificationLimitGB"]));
            }
            set {
                this["NotificationLimitGB"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool NotificationLimitActive {
            get {
                return ((bool)(this["NotificationLimitActive"]));
            }
            set {
                this["NotificationLimitActive"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("700")]
        public uint NotificatonAmountLimit {
            get {
                return ((uint)(this["NotificatonAmountLimit"]));
            }
            set {
                this["NotificatonAmountLimit"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("40, 40")]
        public global::System.Drawing.Point mainFormLocation {
            get {
                return ((global::System.Drawing.Point)(this["mainFormLocation"]));
            }
            set {
                this["mainFormLocation"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("10")]
        public int logFileSizeMB {
            get {
                return ((int)(this["logFileSizeMB"]));
            }
            set {
                this["logFileSizeMB"] = value;
            }
        }
    }
}
