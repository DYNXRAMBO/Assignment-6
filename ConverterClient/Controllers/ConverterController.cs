using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ConverterClient.Models;
using ConverterLib;

namespace ConverterClient.Controllers
{
    public class ConverterController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public string FtoC(decimal x)
        {
            MytemperatureConverter convert = new MytemperatureConverter();
            decimal result = convert.CtoF(x);
            return $"{result}";
        }
        public string FtoK(decimal x)
        {
            MytemperatureConverter convert = new MytemperatureConverter();
            decimal result = convert.FtoK(x);
            return $"{result}";
        }
        public string CtoF(decimal x)
        {
            MytemperatureConverter convert = new MytemperatureConverter();
            decimal result = convert.CtoF(x);
            return $"{result}";
        }
        public string CtoK(decimal x)
        {
            MytemperatureConverter convert = new MytemperatureConverter();
            decimal result = convert.CtoK(x);
            return $"{result}";
        }
        public string KtoF(decimal x)
        {
            MytemperatureConverter convert = new MytemperatureConverter();
            decimal result = convert.KtoF(x);
            return $"{result}";
        }
        public string KtoC(decimal x)
        {
            MytemperatureConverter convert = new MytemperatureConverter();
            decimal result = convert.KtoC(x);
            return $"{result}";
        }
        //=================Measurements=========================
        public string MtoF(decimal x)
        {
            MyMeasurementConverter convert = new MyMeasurementConverter();
            decimal result = convert.MtoF(x);
            return $"{result}";
        }
        public string MtoY(decimal x)
        {
            MyMeasurementConverter convert = new MyMeasurementConverter();
            decimal result = convert.MtoY(x);
            return $"{result}";
        }        
        public string FtoM(decimal x)
        {
            MyMeasurementConverter convert = new MyMeasurementConverter();
            decimal result = convert.FtoM(x);
            return $"{result}";
        }
        public string FtoY(decimal x)
        {
            MyMeasurementConverter convert = new MyMeasurementConverter();
            decimal result = convert.FtoY(x);
            return $"{result}";
        }
        public string YtoM(decimal x)
        {
            MyMeasurementConverter convert = new MyMeasurementConverter();
            decimal result = convert.YtoM(x);
            return $"{result}";
        }
        public string YtoF(decimal x)
        {
            MyMeasurementConverter convert = new MyMeasurementConverter();
            decimal result = convert.YtoF(x);
            return $"{result}";
        }
        //===================Weight========================
        static string OtoP(decimal x)
        {
            MyWeightConverter convert = new MyWeightConverter();
            decimal result = convert.OtoP(x);
            return $"{result}";
        }
        static string OtoG(decimal x)
        {
            MyWeightConverter convert = new MyWeightConverter();
            decimal result = convert.OtoG(x);
            return $"{result}";
        }
        static string OtoK(decimal x)
        {
            MyWeightConverter convert = new MyWeightConverter();
            decimal result = convert.OtoK(x);
            return $"{result}";
        }

        static string PtoO(decimal x)
        {
            MyWeightConverter convert = new MyWeightConverter();
            decimal result = convert.PtoO(x);
            return $"{result}";
        }

        static string PtoG(decimal x)
        {
            MyWeightConverter convert = new MyWeightConverter();
            decimal result = convert.PtoG(x);
            return $"{result}";
        }
        static string PtoK(decimal x)
        {
            MyWeightConverter convert = new MyWeightConverter();
            decimal result = convert.PtoK(x);
            return $"{result}";
        }
        static string GtoP(decimal x)
        {
            MyWeightConverter convert = new MyWeightConverter();
            decimal result = convert.GtoP(x);
            return $"{result}";
        }static string GtoK(decimal x)
        {
            MyWeightConverter convert = new MyWeightConverter();
            decimal result = convert.GtoK(x);
            return $"{result}";
        }
        static string GtoO(decimal x)
        {
            MyWeightConverter convert = new MyWeightConverter();
            decimal result = convert.GtoO(x);
            return $"{result}";
        }
        static string KtoG(decimal x)
        {
            MyWeightConverter convert = new MyWeightConverter();
            decimal result = convert.KtoG(x);
            return $"{result}";
        }static string KtoP(decimal x)
        {
            MyWeightConverter convert = new MyWeightConverter();
            decimal result = convert.KtoP(x);
            return $"{result}";
        }
        static string KtoO(decimal x)
        {
            MyWeightConverter convert = new MyWeightConverter();
            decimal result = convert.KtoO(x);
            return $"{result}";
        }



    }
}
