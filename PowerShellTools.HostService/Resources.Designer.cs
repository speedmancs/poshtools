﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.0
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PowerShellTools.HostService {
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
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("PowerShellTools.HostService.Resources", typeof(Resources).Assembly);
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
        ///   Looks up a localized string similar to Windows PowerShell credential request.
        /// </summary>
        public static string CredentialDialogCaption {
            get {
                return ResourceManager.GetString("CredentialDialogCaption", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Enter your credentials..
        /// </summary>
        public static string CredentialDialogMessage {
            get {
                return ResourceManager.GetString("CredentialDialogMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Local script ({0}) cannot be run through remote PowerShell session.
        /// </summary>
        public static string Error_LocalScriptInRemoteSession {
            get {
                return ResourceManager.GetString("Error_LocalScriptInRemoteSession", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Pipeline not executed because a pipeline is already executing. Pipelines cannot be executed concurrently..
        /// </summary>
        public static string Error_PipelineBusy {
            get {
                return ResourceManager.GetString("Error_PipelineBusy", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unable to attach to specified process..
        /// </summary>
        public static string ProcessAttachFailErrorBody {
            get {
                return ResourceManager.GetString("ProcessAttachFailErrorBody", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Error Attaching to Process.
        /// </summary>
        public static string ProcessAttachFailErrorTitle {
            get {
                return ResourceManager.GetString("ProcessAttachFailErrorTitle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unable to attach to specified process with PowerShell Tools.
        ///PowerShell version 5.0 or above is required before PowerShell Tools may attach to a local or remote process..
        /// </summary>
        public static string ProcessAttachVersionErrorBody {
            get {
                return ResourceManager.GetString("ProcessAttachVersionErrorBody", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Invalid PowerShell Version.
        /// </summary>
        public static string ProcessAttachVersionErrorTitle {
            get {
                return ResourceManager.GetString("ProcessAttachVersionErrorTitle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Warning: PowerShell v4.0 or later is needed on your remote computer to debug during remote script execution. You can install the latest PowerShell from: {0}.
        /// </summary>
        public static string Warning_HigherVersionOnTargetRequiredForDebugging {
            get {
                return ResourceManager.GetString("Warning_HigherVersionOnTargetRequiredForDebugging", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Warning: PowerShell v4.0 or later is needed to debug during remote script execution. You can install the latest PowerShell from: {0}.
        /// </summary>
        public static string Warning_HigherVersionRequiredForDebugging {
            get {
                return ResourceManager.GetString("Warning_HigherVersionRequiredForDebugging", resourceCulture);
            }
        }
    }
}
