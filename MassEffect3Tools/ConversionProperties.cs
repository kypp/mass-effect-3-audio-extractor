using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MassEffect3Tools
{
    public class ConversionProperties
    {
        public string   ww2ogg_Location;
        public string   ww2ogg_Parameters;
        public bool     revorb_Use; 
        public string   revorb_Location;

        private ConversionProperties(string l, string p, bool b, string r)
        {
            ww2ogg_Location = l;
            ww2ogg_Parameters = p;
            revorb_Use = b;
            revorb_Location = r;
        }

        public static ConversionProperties ME2Props()
        {
            return new ConversionProperties("data\\ww2ogg.exe", "--full-setup", false, "data\\revorb.exe");
        }

        public static ConversionProperties ME3Props()
        {
            return new ConversionProperties("data\\ww2ogg.exe", "--pcb data\\packed_codebooks.bin", true, "data\\revorb.exe");
        }

        public static ConversionProperties ME3PropsSfar()
        {
            return new ConversionProperties("data\\ww2ogg.exe", "", true, "data\\revorb.exe");
        }

        public static ConversionProperties Debug_Inline()
        {
            return new ConversionProperties("data\\ww2ogg.exe", "--inline-codebooks --full-setup", true, "data\\revorb.exe");
        }
    }
}
