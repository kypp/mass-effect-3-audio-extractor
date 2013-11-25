using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Diagnostics;

namespace MassEffect3Tools
{
    public class Processor
    {
        public static int ProcessOne(string filename, string destination, ConversionProperties props)
        {
            int n = 0;

            string safename = filename.Substring(filename.LastIndexOf('\\') + 1);

            if (filename.EndsWith(".pcc"))
            {
                ProcessStartInfo info = new ProcessStartInfo("data\\decompress.exe", "-out=\"" + destination + "\\temp\" \"" + filename + "\"");
                info.CreateNoWindow = true;
                info.WindowStyle = ProcessWindowStyle.Hidden;

                Process unpack = Process.Start(info);
                unpack.WaitForExit();
                filename = destination + "\\temp\\" + safename;
            }


            List<long[]> positions = Scanner.Scan(filename);

            List<string> filenames = Extractor.Extract(filename, destination, positions);

            if (Directory.Exists(destination + "\\temp"))
                Directory.Delete(destination + "\\temp", true);

            if (props==null && filenames.Count>0)
                props = Converter.AssessProperties(filenames[0]);

            n = Converter.ConvertRange(filenames, props);

            foreach (string fn in filenames)
            {
                string s = fn.Substring(0, fn.LastIndexOf('.')) + ".wav";
                if (File.Exists(s))
                    File.Delete(s);
            }
            Progress.File_Complete();

            return n;
        }

        public static void ProcessRange(List<string> filenames, ProcessingMode processingMode)
        {
            Progress.Reset(filenames.Count);

            switch (processingMode.outputMode)
            {
                case ProcessingMode.OutputMode.SameDirectory:
                    foreach (string filename in filenames)
                    {
                        ProcessOne(filename, processingMode.outputPath, null);
                    }  
                    break;
                case ProcessingMode.OutputMode.SeparateDirectory:
                    foreach (string filename in filenames)
                    {
                        string dir = processingMode.outputPath + filename.Substring(filename.LastIndexOf('\\'), filename.LastIndexOf('.') - filename.LastIndexOf('\\'));
                        Directory.CreateDirectory(dir);
                        if (ProcessOne(filename, dir, null) == 0)
                        {
                            Directory.Delete(dir);
                        }
                    }  
                    break;
                case ProcessingMode.OutputMode.OriginalStructure:
                    foreach (string filename in filenames)
                    {
                        string dir = processingMode.outputPath + "\\" + filename.Substring(processingMode.rootPath.Length, filename.LastIndexOf('.') - processingMode.rootPath.Length);
                        Directory.CreateDirectory(dir);
                        ProcessOne(filename, dir, null);
                    }  
                    break;
            }          
                          
        }
    }
}
