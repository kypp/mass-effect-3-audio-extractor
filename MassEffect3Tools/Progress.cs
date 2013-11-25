using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MassEffect3Tools
{
    public static class Progress
    {
        public static int overall_percentage() {
            return filecount==0?0:((int)((float)files_processed / (float)filecount * 100));
            } 
        public static int files_processed { get; private set; }
        public static int current_percentage { get; private set; }
        public static int filecount { get; private set; }
        public static int wavecount { get; private set; }
        public static int current_filecount { get; private set; }
        public static int current_filenumber { get; private set; }
        public static string current_state { get; private set; }
        public static string current_file { get; private set; }

        public static void Reset(int all)
        {
            files_processed = 0;
            wavecount = 0;
            current_percentage = 0;
            current_filenumber = 0;
            filecount = all;
            current_filecount = 0;
            current_state = "idle";
        }

        internal static void Start_Scanning(string filename)
        {
            current_percentage = 0;
            current_filecount = 0;
            current_state = "scanning";
            current_file = filename;
        }

        internal static void Scan_Update(int prog, bool b)
        {
            current_percentage = prog>100?100:prog;
            if (b) current_filecount++;
        }

        internal static void Start_Extracting(int count)
        {
            current_percentage = 0;
            current_filecount = count;
            current_filenumber = 0;
            current_state = "extracting";
        }

        internal static void Extraction_Update()
        {
            current_filenumber++;
            current_percentage = (int)(((float)current_filenumber / (float)current_filecount) * 100);
        }

        internal static void Start_Converting(int count)
        {
            current_percentage = 0;
            current_filecount = count;
            current_filenumber = 0;
            current_state = "converting";
        }

        internal static void Conversion_Update()
        {
            current_filenumber++;
            wavecount++;
            current_percentage = (int)(((float)current_filenumber / (float)current_filecount) * 100);
        }

        internal static void File_Complete()
        {
            files_processed++;
            current_state = "idle";
        }
    }
}
