﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FlexPivotExplorer.Properties {
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
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("FlexPivotExplorer.Properties.Resources", typeof(Resources).Assembly);
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
        ///   Looks up a localized string similar to Shows how to apply conditional formatting to an FlexPivotGrid control using the FlexGrid&apos;s CustomCellFactory feature
        ///The FlexPivotGrid derives from the FlexGrid control, so you can use the standard CustomCellFactory mechanism to apply styles to cells based on their contents(or to draw the entire cell if you prefer).
        ///This sample shows a grid where values greater than 500 appear with a light green background.
        /// </summary>
        public static string CellFactory {
            get {
                return ResourceManager.GetString("CellFactory", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Custom Cell Factory.
        /// </summary>
        public static string CellFactoryTitle {
            get {
                return ResourceManager.GetString("CellFactoryTitle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Shows a custom calculated column in FlexPivotGrid
        ///This project shows sales by country and category.It also shows a couple calculated columns that show the difference in product sales a custom total calculation..
        /// </summary>
        public static string Column {
            get {
                return ResourceManager.GetString("Column", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Custom Columns.
        /// </summary>
        public static string ColumnTitle {
            get {
                return ResourceManager.GetString("ColumnTitle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Shows how to work with cube data source.
        /// </summary>
        public static string CubeAnalysisDesc {
            get {
                return ResourceManager.GetString("CubeAnalysisDesc", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cube Analysis.
        /// </summary>
        public static string CubeAnalysisTitle {
            get {
                return ResourceManager.GetString("CubeAnalysisTitle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to This sample shows how to get data to C1 DataEngine to perform analytics. C1DataEngine is capable of handling large amount of data, millions of rows in seconds or less. Data is retrieved from a database..
        /// </summary>
        public static string DataEngine {
            get {
                return ResourceManager.GetString("DataEngine", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Data Engine.
        /// </summary>
        public static string DataEngineTitle {
            get {
                return ResourceManager.GetString("DataEngineTitle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Shows how you can use FlexPivot to analyze multiple fields in one view.
        ///The C1FlexPivotFieldList class has a new MaxItems property.This property allows you to determine how many fields are allowed in each field list (Rows, Columns, Filters, and Values).
        ///If you set the MaxItems of the Values list to a number higher than one, users will be able to add multiple fields to the values list, and the analysis will be performed on all of them at once.
        ///You can also use the MaxItems property on the Rows, Columns, a [rest of string was truncated]&quot;;.
        /// </summary>
        public static string MultiValue {
            get {
                return ResourceManager.GetString("MultiValue", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Multi Values.
        /// </summary>
        public static string MultiValueTitle {
            get {
                return ResourceManager.GetString("MultiValueTitle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Shows how you can customize the FlexPivotPage control.
        ///The sample creates a default view that is persisted across sessions in isolated storage.It also adds a new menu to the FlexPivotPage that contains a list of predefined views.
        ///The IsolatedStorageSettings.ApplicationSettings class allows you to save and load application settings very easily.
        ///The predefined views defined in this application show how you can use the FlexPivotField.Format property to group date values and analyze sales by year, month, and [rest of string was truncated]&quot;;.
        /// </summary>
        public static string Page {
            get {
                return ResourceManager.GetString("Page", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Custom Page.
        /// </summary>
        public static string PageTitle {
            get {
                return ResourceManager.GetString("PageTitle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to With FlexPivot you can create pivot grids and charts that slice and dice your tabular and cube data to give you real-time information, insights, and results in seconds. The easy-to-use controls are modeled after Microsoft Excel® Pivot Tables, so they&apos;re powerful and familiar for all users..
        /// </summary>
        public static string Pivot {
            get {
                return ResourceManager.GetString("Pivot", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Overview.
        /// </summary>
        public static string PivotTitle {
            get {
                return ResourceManager.GetString("PivotTitle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Shows how to customize the FlexPivotPage component by creating a custom template based on the default one.
        ///The sample creates a custom template(located in App.xaml) for the FlexPivotPage, this template is a customized version of the default one, the changes made to the template are:
        ///The FlexPivotPanel is located on the right side of the FlexPivotPage.
        ///The FlexPivotChart has been removed from the TabPanel at the top of the page and is shown below the FlexPivotGrid.
        /// </summary>
        public static string Template {
            get {
                return ResourceManager.GetString("Template", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Custom Template.
        /// </summary>
        public static string TemplateTitle {
            get {
                return ResourceManager.GetString("TemplateTitle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Shows how to work with TopN filter.
        /// </summary>
        public static string TopNDemoDesc {
            get {
                return ResourceManager.GetString("TopNDemoDesc", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Top N Filter.
        /// </summary>
        public static string TopNDemoTitle {
            get {
                return ResourceManager.GetString("TopNDemoTitle", resourceCulture);
            }
        }
    }
}
