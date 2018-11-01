using System;

namespace ConverterLib
{
    
    public class MytemperatureConverter 
    {
        public decimal CtoF(decimal c)
        {
            decimal f = (c * (9m/5m)) + 32;
            return f;
        }
        public decimal CtoK(decimal c)
        {
            decimal k = c + 273.15m;
            return k;
        }

//==========================================================
        public decimal FtoC(decimal f)
        {
            decimal c = (f -32) * (9m/5m);
            return c;
        }

        public decimal FtoK(decimal f)
        {
            decimal k =((f -32) * (9m/5m)) + 273.15m;
            return k;
        }
//==========================================================
        public decimal KtoC(decimal k)
        {
            decimal c = k - 273.15m;
            return c;
        }
        public decimal KtoF(decimal k)
        {
            decimal f =((k - 273.15m) * (9m/5m)) + 32;
            return f;
        }

    }
}


