using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace SmartRefri
{
    class TemperatureSensor
    {
        public static string fileDirctory = Application.StartupPath+"\\temperatureSensorData\\";

        public static int GetLastTemperature()
        {
            string[] files=Directory.GetFiles(fileDirctory);
            Stream stream = File.Open(files[0], FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
            //File.OpenRead(seclogPath1);
            StreamReader reader = new StreamReader(stream);
            string line = "";
            while (!reader.EndOfStream)
            {
                line = reader.ReadLine();
            }
            string[] parts = line.Split(',');
            return (int)float.Parse(parts[1]);
        }
    }
}
