﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SpellCheckerExplorer.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "17.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("SpellCheckerExplorer.Properties.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Check Spelling.
        /// </summary>
        public static string CheckSpelling {
            get {
                return ResourceManager.GetString("CheckSpelling", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Failed to load dictionary.
        /// </summary>
        public static string DictionaryFailed {
            get {
                return ResourceManager.GetString("DictionaryFailed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Loaded main dictionary.
        /// </summary>
        public static string DictionaryOk {
            get {
                return ResourceManager.GetString("DictionaryOk", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Failed to load {0} dictionary: {1}.
        /// </summary>
        public static string FailedToLoadDictionary {
            get {
                return ResourceManager.GetString("FailedToLoadDictionary", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Loaded {0} dictionary ({1:n0} words)..
        /// </summary>
        public static string LoadDictionary {
            get {
                return ResourceManager.GetString("LoadDictionary", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Demo using C1SpellChecker with multiple languages.
        /// </summary>
        public static string MultiLanguageDemoDescription {
            get {
                return ResourceManager.GetString("MultiLanguageDemoDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to MultiLanguage Demo.
        /// </summary>
        public static string MultiLanguageDemoTitle {
            get {
                return ResourceManager.GetString("MultiLanguageDemoTitle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Demo using C1SpellChecker for RichTextBox.
        /// </summary>
        public static string SpellCheckerRtbDemoDescription {
            get {
                return ResourceManager.GetString("SpellCheckerRtbDemoDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to SpellChecker Demo with RichTextBox.
        /// </summary>
        public static string SpellCheckerRtbDemoTitle {
            get {
                return ResourceManager.GetString("SpellCheckerRtbDemoTitle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Demo using C1SpellChecker for a normal textbox.
        /// </summary>
        public static string SpellCheckerTextDemoDescription {
            get {
                return ResourceManager.GetString("SpellCheckerTextDemoDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to SpellChecker Demo with plain textbox.
        /// </summary>
        public static string SpellCheckerTextDemoTitle {
            get {
                return ResourceManager.GetString("SpellCheckerTextDemoTitle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to SpellCheckerExplorer.
        /// </summary>
        public static string Title {
            get {
                return ResourceManager.GetString("Title", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to words.
        /// </summary>
        public static string Word {
            get {
                return ResourceManager.GetString("Word", resourceCulture);
            }
        }
    }
}
