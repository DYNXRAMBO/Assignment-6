using System;

namespace ConverterLib
{
    
    public class MyMeasurementConverter 
    {
        public decimal MtoF(decimal m)
        {
            decimal f = m * 3.28084m;
            return f;
        }
        public decimal MtoY(decimal m)
        {
            decimal y = m * 1.09361m;
            return y;
        }
        //==========================================================
        public decimal FtoM(decimal f)
        {
            decimal m = f * 0.3048m;
            return m;
        }
        public decimal FtoY(decimal f)
        {
            decimal y = f * 0.333333m;
            return y;
        }
        //==========================================================
        public decimal YtoM(decimal y)
        {
            decimal m = y * 0.9144m;
            return m;
        }
        public decimal YtoF(decimal y)
        {
            decimal f = y * 3m;
            return f;
        }
    }
}