using System;
using Microsoft.Win32;

namespace SpaceLauncher
{
    class AutoRun
    {
        private static RegistryKey reg = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Run", true) == null ? 
            Registry.CurrentUser.CreateSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Run") : 
            Registry.CurrentUser.OpenSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Run", true);
        
        /// <summary>
        /// 设置自启动
        /// </summary>
        /// <param name="appName"></param>
        /// <param name="fileName">应用的路径</param>
        /// <param name="isAutoRun">是否自启动</param>
        public static void setAutoRun(string appName, string fileName, bool isAutoRun)
        {
            RegistryKey reg = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Run", true) == null ?
            Registry.CurrentUser.CreateSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Run") :
            Registry.CurrentUser.OpenSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Run", true);
            try
            {
                if (!System.IO.File.Exists(fileName))
                    throw new Exception("该文件不存在!");
                if (isAutoRun)
                {
                    reg.SetValue(appName, fileName);
                }
                else
                {
                    reg.DeleteValue(appName);
                }
            }
            finally
            {
                if (reg != null)
                    reg.Close();
            }
        }

        /// <summary>
        /// 检测是否自启动
        /// </summary>
        /// <param name="appName">应用名</param>
        /// <param name="fileName">应用路径</param>
        /// <returns></returns>
        public static bool isAutoRun(String appName, String fileName)
        {
            try
            {
                String path = (String)reg.GetValue(appName);
                if (path == null)
                {
                    return false;
                }
                if(path == fileName)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch(Exception e)
            {
                System.Windows.Forms.MessageBox.Show(e.Message);
                return false;
            }
        }
    }
}
