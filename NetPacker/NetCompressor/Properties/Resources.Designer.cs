﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace NetPacker.Properties {
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
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("NetPacker.Properties.Resources", typeof(Resources).Assembly);
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
        ///   Looks up a localized string similar to ResourceManager rm = new ResourceManager(&quot;resource&quot;, Assembly.GetExecutingAssembly());
        ///byte[] appBytes = (byte[])rm.GetObject(&quot;%appname%&quot;);
        ///
        /////Loading App
        ///int appSize = %appsize%;
        ///MemoryStream memStr = new MemoryStream(appBytes);
        ///var gStream = new %mode%;
        ///
        ///
        ///
        ///byte[] tAppBytes = new byte[appSize];
        ///
        ///gStream.Read(tAppBytes, 0, appSize);
        ///memStr.Close();
        ///gStream.Close();
        ///
        /////End Loading App.
        /// </summary>
        public static string AppMethod {
            get {
                return ResourceManager.GetString("AppMethod", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to 
        /////nothing passed on yet.
        ///var assemb = Assembly.Load(tAppBytes);
        ///tAppBytes = null; 
        ///GC.Collect();
        ///
        ///try {
        ///	assemb.EntryPoint.Invoke(null, new object[] { new string[0]});
        ///} catch(Exception ex) {
        ///	Console.WriteLine(&quot;Invoke Main error ! {0}&quot;, ex.Message);
        ///}
        ///.
        /// </summary>
        public static string AppMethodEnd {
            get {
                return ResourceManager.GetString("AppMethodEnd", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to [assembly: AssemblyTitle(&quot;&quot;)]
        ///[assembly: AssemblyDescription(&quot;&quot;)]
        ///[assembly: AssemblyConfiguration(&quot;&quot;)]
        ///[assembly: AssemblyCompany(&quot;&quot;)]
        ///[assembly: AssemblyProduct(&quot;&quot;)]
        ///[assembly: AssemblyCopyright(&quot;Copyright ©&quot;)]
        ///[assembly: AssemblyTrademark(&quot;&quot;)]
        ///[assembly: AssemblyCulture(&quot;&quot;)]
        ///
        ///// Version information for an assembly consists of the following four values:
        /////
        /////      Major Version
        /////      Minor Version 
        /////      Build Number
        /////      Revision
        /////
        ///// You can specify all the values or you can defa [rest of string was truncated]&quot;;.
        /// </summary>
        public static string Assembly {
            get {
                return ResourceManager.GetString("Assembly", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Byte[].
        /// </summary>
        public static byte[] SharpCompress {
            get {
                object obj = ResourceManager.GetObject("SharpCompress", resourceCulture);
                return ((byte[])(obj));
            }
        }
    }
}