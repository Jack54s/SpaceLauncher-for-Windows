using System;
using System.Diagnostics;
using System.Windows.Forms;
using System.Runtime.InteropServices;


namespace SpaceLauncher
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            bool createNew;
            using(System.Threading.Mutex mutex = new System.Threading.Mutex(true, Application.ProductName, out createNew))
            {
                if (createNew)
                {
                    Application.EnableVisualStyles();
                    Application.SetCompatibleTextRenderingDefault(false);
                    Application.Run(new commandView());
                }
                else
                {
                    Process instance = RunningInstance();
                    if(instance != null)
                    {
                        HandleRunningInstance(instance);
                    }
                    else
                    {
                        MessageBox.Show("未知错误，请先退出正在运行的程序！");
                    }
                }
            }
        }

        /// <summary>
        /// 找到已经打开的实例
        /// </summary>
        /// <returns></returns>
        private static Process RunningInstance()
        {
            Process current = Process.GetCurrentProcess();
            Process[] processes = Process.GetProcessesByName(current.ProcessName);
            foreach(Process process in processes)
            {
                if(process.Id != current.Id)
                {
                    if(System.Reflection.Assembly.GetExecutingAssembly().Location.Replace("/", @"/") == current.MainModule.FileName)
                    {
                        return process;
                    }
                }
            }
            return null;
        }

        /// <summary>
        /// 将已打开的实例放到前台
        /// </summary>
        /// <param name="instance"></param>
        private static void HandleRunningInstance(Process instance)
        {
            IntPtr windowHandle = FindWindow(null, "SpaceLauncher");
            ShowWindow(windowHandle, 1);
            SetForegroundWindow(windowHandle);
        }

        [DllImport("User32.dll")]
        private static extern bool ShowWindow(IntPtr hWnd, int cmdShow);
        [DllImport("User32.dll")]
        private static extern bool SetForegroundWindow(IntPtr hWnd);
        [DllImport("user32.dll", EntryPoint = "FindWindow")]
        private extern static IntPtr FindWindow(string lpClassName, string lpWindowName);
    }
}
