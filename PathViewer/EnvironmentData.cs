using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PathViewer
{
    public class EnvironmentData
    {
        public static string GetEnvironmentFromRegistry(string variableName)
        {
            string regKey = @"SYSTEM\CurrentControlSet\Control\Session Manager\Environment\";
            string regValue = (string)Registry.LocalMachine.OpenSubKey(regKey).GetValue(variableName, "", RegistryValueOptions.DoNotExpandEnvironmentNames);

            return regValue; 
        }
    }
}
