﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AccordionExplorer.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
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
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("AccordionExplorer.Properties.Resources", typeof(Resources).Assembly);
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
        ///   Looks up a localized string similar to The C1Accordion control is a container that that can hold a series of expandable and collapsible panes for storing text, images, and controls. The C1Accordion control is an ItemsControl, which means that the control is designed to host a series of objects. The C1Expander class represents the items, or accordion panes, that can be hosted by the C1Accordion control.
        /// </summary>
        public static string AccordionDesc {
            get {
                return ResourceManager.GetString("AccordionDesc", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Accordion.
        /// </summary>
        public static string AccordionTitle {
            get {
                return ResourceManager.GetString("AccordionTitle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to C1Expander allows you to create an expandable and collapsible information panel that can include text, images, and controls. Choose from four expand directions and position of the expand button..
        /// </summary>
        public static string ExpanderDesc {
            get {
                return ResourceManager.GetString("ExpanderDesc", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Expander.
        /// </summary>
        public static string ExpanderTitle {
            get {
                return ResourceManager.GetString("ExpanderTitle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to AccordionExplorer.
        /// </summary>
        public static string Title {
            get {
                return ResourceManager.GetString("Title", resourceCulture);
            }
        }
    }
}