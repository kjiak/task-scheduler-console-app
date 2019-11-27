using System;
using System.IO;

namespace task_scheduler_console_app
{
    class Program
    {
        static void Main(string[] args)
        {
            RunSchedule();
        }
        public static void RunSchedule()
        {
            string path = Path.GetFullPath("C:\\MyTest") + "\\" + DateTime.Now.ToString("MM_dd_yyyy_HH_mm") + "_Log.txt";
            try
            {
                // Put your own logic which you want to perform on schedule basis

                if (!File.Exists(path))
                {
                    File.Create(path);
                }
            }
            catch (Exception ex)
            {
                // Log error and send email to Admin that schedule has failed
                string errorLogPath = @"C:\MyTest.txt";
                File.AppendAllText(errorLogPath, Environment.NewLine + ex.Message);
            }
        }
    }
}
