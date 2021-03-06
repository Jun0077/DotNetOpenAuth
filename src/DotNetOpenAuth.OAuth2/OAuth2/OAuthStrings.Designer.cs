﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.17622
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DotNetOpenAuth.OAuth2 {
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
    internal class OAuthStrings {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal OAuthStrings() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("DotNetOpenAuth.OAuth2.OAuthStrings", typeof(OAuthStrings).Assembly);
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
        ///   Looks up a localized string similar to The value for message part &quot;{0}&quot; must be an absolute URI..
        /// </summary>
        internal static string AbsoluteUriRequired {
            get {
                return ResourceManager.GetString("AbsoluteUriRequired", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The access token contains characters that must not appear in the HTTP Authorization header..
        /// </summary>
        internal static string AccessTokenInvalidForHttpAuthorizationHeader {
            get {
                return ResourceManager.GetString("AccessTokenInvalidForHttpAuthorizationHeader", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to At least one parameter is required for the Bearer scheme in its WWW-Authenticate header..
        /// </summary>
        internal static string BearerTokenUnauthorizedAtLeastOneParameterRequired {
            get {
                return ResourceManager.GetString("BearerTokenUnauthorizedAtLeastOneParameterRequired", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to This message can only be sent over HTTPS..
        /// </summary>
        internal static string HttpsRequired {
            get {
                return ResourceManager.GetString("HttpsRequired", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The scope token &quot;{0}&quot; contains illegal characters or is empty..
        /// </summary>
        internal static string InvalidScopeToken {
            get {
                return ResourceManager.GetString("InvalidScopeToken", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Refresh tokens should not be granted without the request including an access grant..
        /// </summary>
        internal static string NoGrantNoRefreshToken {
            get {
                return ResourceManager.GetString("NoGrantNoRefreshToken", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The &apos;{0}&apos; parameter contains the illegal character &apos;{1}&apos;..
        /// </summary>
        internal static string ParameterContainsIllegalCharacters {
            get {
                return ResourceManager.GetString("ParameterContainsIllegalCharacters", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The return value of {0}.{1} should never be null..
        /// </summary>
        internal static string ResultShouldNotBeNull {
            get {
                return ResourceManager.GetString("ResultShouldNotBeNull", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Individual scopes may not contain spaces..
        /// </summary>
        internal static string ScopesMayNotContainSpaces {
            get {
                return ResourceManager.GetString("ScopesMayNotContainSpaces", resourceCulture);
            }
        }
    }
}
