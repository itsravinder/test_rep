//-----------------------------------------------------------------------------------
// File: Helper_Class.cs
// 
// Summary: Helper_Class class for reading/writing cofiguration values to/from SSO
//
// Sample: SSO as Configuration Store    
//
//-----------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Specialized;
using Microsoft.BizTalk.SSOClient.Interop;

namespace TSSG.SSO.Utility
{
    public class ConfigurationPropertyBag : IPropertyBag
    {
        private HybridDictionary properties;
        internal ConfigurationPropertyBag()
        {
            properties = new HybridDictionary();
        }
        public void Read(string propName, out object ptrVar, int errLog)
        {
            ptrVar = properties[propName];
        }
        public void Write(string propName, ref object ptrVar)
        {
            properties.Add(propName, ptrVar);
        }
        public bool Contains(string key)
        {
            return properties.Contains(key);
        }
        public void Remove(string key)
        {
            properties.Remove(key);
        }
    }
    public static class Helper_Class
    {
        private static string idenifierGUID = "ConfigProperties";

        /// <summary>
        /// Read method helps get configuration data
        /// </summary>        
        /// <param name="appName">The name of the affiliate application to represent the configuration container to access</param>
        /// <param name="propName">The property name to read</param>
        /// <returns>
        ///  The value of the property stored in the given affiliate application of this component.
        /// </returns>
        public static string Read(string appName, string propName)
        {
            try
            {
                SSOConfigStore ssoStore = new SSOConfigStore();
                ConfigurationPropertyBag appMgmtBag = new ConfigurationPropertyBag();
                ((ISSOConfigStore)ssoStore).GetConfigInfo(appName, idenifierGUID, SSOFlag.SSO_FLAG_RUNTIME, (IPropertyBag)appMgmtBag);
                object propertyValue = null;
                appMgmtBag.Read(propName, out propertyValue, 0);
                return (string)propertyValue;
            }
            catch (Exception e)
            {
                System.Diagnostics.Trace.WriteLine(e.Message);
                throw;
            }
        }

        /// <summary>
        /// Write method helps write configuration data
        /// </summary>        
        /// <param name="appName">The name of the affiliate application to represent the configuration container to access</param>
        /// <param name="propName">The property name to write</param>
        /// <param name="propName">The property value to write</param>
        public static void Write(string appName, string propName, object propValue)
        {
            try
            {
                SSOConfigStore ssoStore = new SSOConfigStore();
                ConfigurationPropertyBag appMgmtBag = new ConfigurationPropertyBag();
                ((ISSOConfigStore)ssoStore).GetConfigInfo(appName, idenifierGUID, SSOFlag.SSO_FLAG_RUNTIME, (IPropertyBag)appMgmtBag);
                object tempProp = propValue;

                try
                {
                    appMgmtBag.Remove(propName);
                }
                catch
                {
                }

                appMgmtBag.Write(propName, ref tempProp);
                ((ISSOConfigStore)ssoStore).SetConfigInfo(appName, idenifierGUID, appMgmtBag);
            }
            catch (Exception e)
            {
                System.Diagnostics.Trace.WriteLine(e.Message);
                throw;
            }
        }
    }
}
