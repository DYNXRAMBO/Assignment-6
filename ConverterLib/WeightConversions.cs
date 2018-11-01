using System;

namespace ConverterLib
{
    
    public class MyWeightConverter 
    {
        public decimal OtoP(decimal o)
        {
            decimal p = o * 0.0625m;
            return p;
        }
        public decimal OtoG(decimal o)
        {
            decimal g = o * 28.3495m;
            return g;
        }
        public decimal OtoK(decimal o)
        {
            decimal k = o * 0.0283495m;
            return k;
        }

//==========================================================
        public decimal PtoO(decimal p)
        {
            decimal o = p * 16;
            return o;
        }

        public decimal PtoG(decimal p)
        {
            decimal g = p * 453.592m;
            return g;
        }
        public decimal PtoK(decimal p)
        {
            decimal k = p * 0.453592m;
            return k;
        }
//==========================================================
        public decimal GtoP(decimal g)
        {
            decimal p = g * 0.00220462m;
            return p;
        }public decimal GtoK(decimal g)
        {
            decimal k = g * 0.001m;
            return k;
        }
        public decimal GtoO(decimal g)
        {
            decimal o = g * 0.035274m;
            return o;
        }
        //==========================================================
        public decimal KtoG(decimal k)
        {
            decimal g = k * 1000;
            return g;
        }public decimal KtoP(decimal k)
        {
            decimal p = k * 2.20462m;
            return p;
        }
        public decimal KtoO(decimal k)
        {
            decimal o = k * 35.274m;
            return o;
        }

    }
}