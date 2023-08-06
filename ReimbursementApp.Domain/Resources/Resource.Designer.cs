﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ReimbursementApp.Domain.Resources {
    using System;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public class Resource {
        
        private static System.Resources.ResourceManager resourceMan;
        
        private static System.Globalization.CultureInfo resourceCulture;
        
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resource() {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public static System.Resources.ResourceManager ResourceManager {
            get {
                if (object.Equals(null, resourceMan)) {
                    System.Resources.ResourceManager temp = new System.Resources.ResourceManager("ReimbursementApp.Domain.Resources.Resource", typeof(Resource).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public static System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        public static string WelcomeMessage {
            get {
                return ResourceManager.GetString("WelcomeMessage", resourceCulture);
            }
        }
        
        public static string FileUploadFailed {
            get {
                return ResourceManager.GetString("FileUploadFailed", resourceCulture);
            }
        }
        
        public static string UnAuthorized {
            get {
                return ResourceManager.GetString("UnAuthorized", resourceCulture);
            }
        }
        
        public static string TokenInvalid {
            get {
                return ResourceManager.GetString("TokenInvalid", resourceCulture);
            }
        }
        
        public static string RequestRaised {
            get {
                return ResourceManager.GetString("RequestRaised", resourceCulture);
            }
        }
        
        public static string RequestsFetched {
            get {
                return ResourceManager.GetString("RequestsFetched", resourceCulture);
            }
        }
        
        public static string PendingRequestsFetched {
            get {
                return ResourceManager.GetString("PendingRequestsFetched", resourceCulture);
            }
        }
        
        public static string AdminAcknowledged {
            get {
                return ResourceManager.GetString("AdminAcknowledged", resourceCulture);
            }
        }
        
        public static string ManagerAcknowledged {
            get {
                return ResourceManager.GetString("ManagerAcknowledged", resourceCulture);
            }
        }
        
        public static string RequestNotFound {
            get {
                return ResourceManager.GetString("RequestNotFound", resourceCulture);
            }
        }
        
        public static string EmployeeAdded {
            get {
                return ResourceManager.GetString("EmployeeAdded", resourceCulture);
            }
        }
        
        public static string EmployeeDeleted {
            get {
                return ResourceManager.GetString("EmployeeDeleted", resourceCulture);
            }
        }
        
        public static string EmployeeFetched {
            get {
                return ResourceManager.GetString("EmployeeFetched", resourceCulture);
            }
        }
        
        public static string EmployeesFetched {
            get {
                return ResourceManager.GetString("EmployeesFetched", resourceCulture);
            }
        }
        
        public static string EmployeeUpdated {
            get {
                return ResourceManager.GetString("EmployeeUpdated", resourceCulture);
            }
        }
        
        public static string EmployeeNotFound {
            get {
                return ResourceManager.GetString("EmployeeNotFound", resourceCulture);
            }
        }
        
        public static string EmployeePasswordMismatch {
            get {
                return ResourceManager.GetString("EmployeePasswordMismatch", resourceCulture);
            }
        }
        
        public static string EmailContent {
            get {
                return ResourceManager.GetString("EmailContent", resourceCulture);
            }
        }
        
        public static string EmailBody {
            get {
                return ResourceManager.GetString("EmailBody", resourceCulture);
            }
        }
    }
}
