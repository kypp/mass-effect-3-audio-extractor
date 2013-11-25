using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace MassEffect3Tools
{
    public class Extractor
    {
        public static List<string> Extract(string filename, string destination, List<long[]> waves) 
        {
            Progress.Start_Extracting(waves.Count);
            var files = new List<string>();
            FileStream file = new FileStream(filename, FileMode.Open, FileAccess.Read);
            BinaryReader r = new BinaryReader(file);
            int currentfile = 0;

            foreach (long[] wave in waves)
            {
                currentfile++;
                string outputname = destination +"\\" + filename.Substring(filename.LastIndexOf('\\')+1, filename.LastIndexOf('.')-filename.LastIndexOf('\\'));
                for (int i = 0; i < waves.Count.ToString().Length-currentfile.ToString().Length; i++)
                {
                    outputname += "0";
                }

                outputname += currentfile.ToString() + ".wav";

                file.Position = wave[0];

                byte[] buffer = new byte[wave[1]];
                r.Read(buffer, 0, (int)wave[1]);

                FileStream outputfile = new FileStream(outputname, FileMode.Create, FileAccess.Write);
                BinaryWriter w = new BinaryWriter(outputfile);

                w.Write(buffer);
                w.Close();

                Progress.Extraction_Update();
                files.Add(outputname);
            }
            r.Close();            
            return files;
        }
    }
}
