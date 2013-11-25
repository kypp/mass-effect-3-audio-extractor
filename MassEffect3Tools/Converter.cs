using System;
using System.Collections.Generic;
using System.IO;
using System.Diagnostics;

namespace MassEffect3Tools
{
    public class Converter
    {
        //converts one file, returns true if conversion successfull
        public static bool ConvertOne(string input, ConversionProperties props)
        {
            if (props == null)
            {
                props = AssessProperties(input);
                if (props == null) return false;
            }

            ProcessStartInfo info = new ProcessStartInfo(props.ww2ogg_Location, props.ww2ogg_Parameters + " " + "\"" + input + "\"");
            info.CreateNoWindow = true;
            info.WindowStyle = ProcessWindowStyle.Hidden;

            Process ww2ogg = Process.Start(info);
            ww2ogg.WaitForExit();
            if (ww2ogg.ExitCode != 0) return false;

            if (props.revorb_Use)
            {
                info = new ProcessStartInfo(props.revorb_Location, "\"" + input.Substring(0, input.LastIndexOf('.')) + ".ogg" + "\"");
                info.CreateNoWindow = true;
                info.WindowStyle = ProcessWindowStyle.Hidden;

                Process revorb = Process.Start(info);
                revorb.WaitForExit();
            }

            return true;
        }

        //converts many files, returns number of successfully converted files
        public static int ConvertRange(List<string> files, ConversionProperties props)
        {
            int converted = 0;
            Progress.Start_Converting(files.Count);

            foreach (string file in files)
            {
                if (ConvertOne(file, props))
                {
                    converted++;
                    Progress.Conversion_Update();
                }
            }

            return converted;
        }

        public static ConversionProperties AssessProperties(string file)
        {
            ConversionProperties props = null;

            string name = file.Substring(0, file.LastIndexOf('.')) + ".ogg";

            if (ConvertOne(file, ConversionProperties.ME3Props()))
            {
                props = ConversionProperties.ME3Props();
            }
            else if (ConvertOne(file, ConversionProperties.ME3PropsSfar()))
	        {
                props = ConversionProperties.ME3PropsSfar();
	        }
            else if (ConvertOne(file, ConversionProperties.ME2Props()))
            {
                props = ConversionProperties.ME2Props();
            }
            else if (ConvertOne(file, ConversionProperties.Debug_Inline()))
            {
                props = ConversionProperties.Debug_Inline();
            }
            
            if (File.Exists(name))
                File.Delete(name);

            return props;
        }
    }
}
