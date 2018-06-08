using System;
using System.Collections.Generic;

namespace tallyho.Models
{
    class Tally
    {
        public double Length { get; set; }
        public string Time { get; set; }
    }

    class MetaData
    {
        public string RunType { get; set; }
        public int StringPosition { get; set; }
        public DateTime DateMeasured { get; set; }
        public string MeasuredBy { get; set; }
    }

    class StringData
    {
        public MetaData MetaData { get; set; }
        public string CasingType { get; set; }
        public double Size { get; set; }
        public double Weight { get; set; }
        public IList<Tally> Tally { get; set; }
    }

    class WellData
    {
        public string CompanyName { get; set; }
        public string Lsd { get; set; }
        public string WellName { get; set; }
        public string Afe { get; set; }
        public string RigContractor { get; set; }
        public int RigNumber { get; set; }
        public string ServiceProvider { get; set; }
    }

    class CasingString
    {
        public WellData WellData { get; set; }
        public IList<StringData> StringData { get; set; }
    }
}
