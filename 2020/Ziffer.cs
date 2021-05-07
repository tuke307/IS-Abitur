using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISVORABI
{
    public class Ziffer
    {
        private bool sa;
        private bool sb;
        private bool sc; 
        private bool sd; 
        private bool se;
        private bool sf;
        private bool sg; 
        private byte wert; 

        public void setWert(int stellenindex, int zahl)
        {
            string komplett = zahl.ToString();
            
            if(komplett.Length == 1)
            {
                setWert(Convert.ToByte(komplett));
                return;
            }

            string value = komplett.Substring(stellenindex-1, 1);

            wert = Convert.ToByte(value);
            setWert(Convert.ToByte(wert));
        }
        public void setWert(byte ziffer)
        {
            wert = ziffer;

            switch (wert)
            {
                case 0:
                    sa = true;
                    sb = true;
                    sc = true;
                    sd = true;
                    se = true;
                    sf = true;
                    sg = true;
                    break;
                case 1:
                    sa = false;
                    sb = true;
                    sc = true;
                    sd = false;
                    se = false;
                    sf = false;
                    sg = false;
                    break;
                case 2:
                    sa = true;
                    sb = true;
                    sc = false;
                    sd = true;
                    se = true;
                    sf = false;
                    sg = true;
                    break;
                case 3:
                    sa = true;
                    sb = true;
                    sc = true;
                    sd = true;
                    se = false;
                    sf = false;
                    sg = true;
                    break;
                case 4:
                    sa = false;
                    sb = false;
                    sc = true;
                    sd = false;
                    se = false;
                    sf = true;
                    sg = true;
                    break;
                case 5:
                    sa = true;
                    sb = false;
                    sc = true;
                    sd = true;
                    se = false;
                    sf = true;
                    sg = true;
                    break;
                case 6:
                    sa = true;
                    sb = false;
                    sc = true;
                    sd = true;
                    se = true;
                    sf = true;
                    sg = true;
                    break;
                case 7:
                    sa = true;
                    sb = true;
                    sc = true;
                    sd = false;
                    se = false;
                    sf = false;
                    sg = false;
                    break;
                case 8:
                    sa = true;
                    sb = true;
                    sc = true;
                    sd = true;
                    se = true;
                    sf = true;
                    sg = true;
                    break;
                case 9:
                    sa = true;
                    sb = true;
                    sc = true;
                    sd = true;
                    se = false;
                    sf = true;
                    sg = true;
                    break;
            }
        }

        public bool getSegment(char segment)
        {
            switch (segment)
            {
                case 'a':
                    return sa;
                case 'b':
                    return sb;
                case 'c':
                    return sc;
                case 'd':
                    return sd;
                case 'e':
                    return se;
                case 'f':
                    return sf;
                case 'g':
                    return sg;
                default:
                    return false;
            }
        }
    }
}
