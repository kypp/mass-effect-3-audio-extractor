using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MassEffect3Tools;

namespace ConsoleTester
{
    class Program
    {
        static void Main(string[] args)
        {
            //DateTime starttime = DateTime.Now;

            //Processor.ProcessOne("C:\\Users\\Kyp\\Desktop\\assemble\\outpuut\\unpacked\\BioD_Nor_100CabinConv_LOC_INT.pcc", "C:\\Users\\Kyp\\Desktop\\assemble\\outpuut\\unpacked\\", ConversionProperties.ME3Props());
            string outdir = args[0].Substring(0, args[0].LastIndexOf('\\')+1);
            Processor.ProcessOne(args[0], outdir, ConversionProperties.ME3Props());
            

            //DateTime stoptime = DateTime.Now;

            //TimeSpan span = stoptime - starttime;

            

            //Console.WriteLine(span.Milliseconds);
        }
    }
}
