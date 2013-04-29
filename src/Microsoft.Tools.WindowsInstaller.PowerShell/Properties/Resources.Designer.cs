﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18033
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Microsoft.Tools.WindowsInstaller.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Microsoft.Tools.WindowsInstaller.Properties.Resources", typeof(Resources).Assembly);
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
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The user context &quot;None&quot; is not validation for this operation..
        /// </summary>
        internal static string Error_InvalidContext {
            get {
                return ResourceManager.GetString("Error_InvalidContext", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The path &quot;{0}&quot; is not a file or does not exist..
        /// </summary>
        internal static string Error_InvalidFile {
            get {
                return ResourceManager.GetString("Error_InvalidFile", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The patch state filter &quot;None&quot; is not valid for this operation..
        /// </summary>
        internal static string Error_InvalidFilter {
            get {
                return ResourceManager.GetString("Error_InvalidFilter", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The argument is not in the acceptable form of {xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx} where x is a number or a letter from A-F..
        /// </summary>
        internal static string Error_InvalidGuid {
            get {
                return ResourceManager.GetString("Error_InvalidGuid", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The security identifier is invalid..
        /// </summary>
        internal static string Error_InvalidSid {
            get {
                return ResourceManager.GetString("Error_InvalidSid", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The file &quot;{0}&quot; is not a supported format..
        /// </summary>
        internal static string Error_InvalidStorage {
            get {
                return ResourceManager.GetString("Error_InvalidStorage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Package.
        /// </summary>
        internal static string Type_Package {
            get {
                return ResourceManager.GetString("Type_Package", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Patch.
        /// </summary>
        internal static string Type_Patch {
            get {
                return ResourceManager.GetString("Type_Patch", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Transform.
        /// </summary>
        internal static string Type_Transform {
            get {
                return ResourceManager.GetString("Type_Transform", resourceCulture);
            }
        }
    }
}
