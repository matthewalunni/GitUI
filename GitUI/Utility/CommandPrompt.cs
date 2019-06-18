using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Utility
{
    class CommandPrompt
    {
        public static string RunCommandClose(params string[] commands)
        {
            Process cmd = new Process();
            cmd.StartInfo.FileName = "cmd.exe";
            cmd.StartInfo.RedirectStandardInput = true;
            cmd.StartInfo.RedirectStandardOutput = true;
            cmd.StartInfo.CreateNoWindow = true;
            cmd.StartInfo.UseShellExecute = false;
            cmd.Start();

            foreach (var command in commands)
            {
                cmd.StandardInput.WriteLine(command);
            }

            cmd.StandardInput.Flush(); //may need to be included in loop
            cmd.StandardInput.Close();
            cmd.WaitForExit();

            return cmd.StandardOutput.ReadToEnd();
        }

        public static string RunCommand(params string[] commands)
        {
            Process cmd = new Process();
            cmd.StartInfo.FileName = "cmd.exe";
            cmd.StartInfo.RedirectStandardInput = true;
            cmd.StartInfo.RedirectStandardOutput = true;
            cmd.StartInfo.CreateNoWindow = true;
            cmd.StartInfo.UseShellExecute = false;
            cmd.Start();

            foreach (var command in commands)
            {
                cmd.StandardInput.WriteLine(command);
            }

            cmd.StandardInput.Flush(); //may need to be included in loop
            //cmd.StandardInput.Close();
            //cmd.WaitForExit();

            return cmd.StandardOutput.ReadToEnd();
        }

        public static string Execute(string command)
        {

            Process process = new Process();
            process.StartInfo.FileName = "cmd.exe";
            process.StartInfo.CreateNoWindow = true;
            process.StartInfo.RedirectStandardInput = true;
            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.UseShellExecute = false;
            process.Start();

            process.StandardInput.WriteLine(command);
            process.StandardInput.Flush();
            process.StandardInput.Close();
            process.WaitForExit();
            return process.StandardOutput.ReadToEnd();
        }

       // public static string Execute(IEnumerable<string> commands)
        //{
        //    ProcessStartInfo pStartInfo = new ProcessStartInfo();
        //    pStartInfo.FileName = "cmd.exe";
        //    pStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
        //    pStartInfo.CreateNoWindow = true;
        //    pStartInfo.RedirectStandardInput = true;
        //    pStartInfo.RedirectStandardOutput = true;
        //    pStartInfo.UseShellExecute = false;
            
        //    Process process = Process.Start();
        //    process.StandardInput.Write();

        //    Thread.Sleep(90);
        //    return process.StandardOutput.ReadToEnd();

        //}

    }
}
