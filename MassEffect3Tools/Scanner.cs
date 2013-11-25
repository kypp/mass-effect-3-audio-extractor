using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace MassEffect3Tools
{
    public class Scanner
    {
        public static List<long[]> Scan(string filename)
        {
            Progress.Start_Scanning(filename.Substring(filename.LastIndexOf('\\')+1));
            var waves = new List<long[]>();
            FileStream file = new FileStream(filename, FileMode.Open, FileAccess.Read);
            BinaryReader r = new BinaryReader(file);

            file.Position = 0;
            long length = 0;
            int n = -1;
            byte[] bytes = new byte[4] { 0, 0, 0, 0 };

            long perc = (long)((float)file.Length / 100);
            if (perc == 0) perc++;

            while (file.Position < file.Length)
            {
                n = (n + 1) % 4;
                bytes[n] = r.ReadByte();

                if (file.Position % perc == 0) Progress.Scan_Update((int)((float)file.Position / (float)file.Length * 100), false);

                if (bytes[n] == 70 && bytes[(n + 1) % 4] == 82 && bytes[(n + 2) % 4] == 73 && bytes[(n + 3) % 4] == 70) //RIFF header detection
                {
                    length = r.ReadInt32() + 8;

                    if (r.ReadByte() == 87 && r.ReadByte() == 65 && r.ReadByte() == 86 && r.ReadByte() == 69) //WAVE detection for random RIFF protection
                    {
                        waves.Add(new long[2] { file.Position - 12, length });

                        file.Position += length - 12;

                        Progress.Scan_Update((int)((float)file.Position / (float)file.Length * 100), true);
                    }
                }
            }

            r.Close();
            return waves;
        }
    }
}
