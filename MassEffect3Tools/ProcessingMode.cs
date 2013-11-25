using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MassEffect3Tools
{
    public class ProcessingMode
    {
        public enum OutputMode
        {
            SameDirectory,
            SeparateDirectory,
            OriginalStructure
        }

        public OutputMode outputMode;
        public string rootPath;
        public string outputPath;

        public ProcessingMode(OutputMode mode, string root, string output)
        {
            outputMode = mode;
            rootPath = root;
            outputPath = output;
        }
    }
}
