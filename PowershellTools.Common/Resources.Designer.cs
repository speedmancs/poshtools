﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.0
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PowerShellTools.Common {
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
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("PowerShellTools.Common.Resources", typeof(Resources).Assembly);
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
        ///   Looks up a localized string similar to Invalid argument &apos;{0}&apos;.
        /// </summary>
        internal static string ArgumentException_1arg {
            get {
                return ResourceManager.GetString("ArgumentException_1arg", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &quot;Failed to open file.&quot;.
        /// </summary>
        internal static string DefaultFileOpenError {
            get {
                return ResourceManager.GetString("DefaultFileOpenError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} : {1}.
        /// </summary>
        internal static string HostProcessWindowTitleFormat {
            get {
                return ResourceManager.GetString("HostProcessWindowTitleFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &quot;Failed to open local file while attaching to local process.&quot;.
        /// </summary>
        internal static string LocalAttachFileOpenError {
            get {
                return ResourceManager.GetString("LocalAttachFileOpenError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &quot;Failed to open local file.&quot;.
        /// </summary>
        internal static string LocalFileOpenError {
            get {
                return ResourceManager.GetString("LocalFileOpenError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &quot;Failed to open remote file through powershell remote session.&quot;.
        /// </summary>
        internal static string RemoteSessionFileOpenError {
            get {
                return ResourceManager.GetString("RemoteSessionFileOpenError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Exactly one of parameters &apos;{0}&apos; and &apos;{1}&apos; should be specified..
        /// </summary>
        internal static string ValidateExactlyOneSpecifiedFailed_2args {
            get {
                return ResourceManager.GetString("ValidateExactlyOneSpecifiedFailed_2args", resourceCulture);
            }
        }
    }
}
