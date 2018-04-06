using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public static class ffmpegHelper
    {
        public static void Convert(string strFfmpegPath, string strSourceFile, string strOutputFileName)
        {
            Process process0 = new Process();
            process0.StartInfo.FileName = strFfmpegPath;

            process0.StartInfo.Arguments = "-i " + strSourceFile + " " + strOutputFileName;

            process0.StartInfo.UseShellExecute = false;
            process0.StartInfo.CreateNoWindow = false;
            process0.Start();
            process0.WaitForExit();
            process0.Close();
        }
    }
}
