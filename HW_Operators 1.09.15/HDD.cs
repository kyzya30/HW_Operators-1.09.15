
using System;

namespace HW_Operators_1._09._15
{
    class HDD: ICloneable
    {
        public string Vendor { get; set; }
        public int Value { get; set; }

        public HDD(string vendor, int value)
        {
            Vendor = vendor;
            Value = value;
        }
        public static HDD operator +(HDD HDD1, HDD HDD2)
        {
            if (HDD1.Vendor == HDD2.Vendor)
            {
                return new HDD(HDD1.Vendor, HDD1.Value + HDD2.Value);
            }

            if (HDD1.Vendor != HDD2.Vendor && HDD1.Value < HDD2.Value)
            {
                return new HDD(HDD2.Vendor, HDD2.Value);
            }
            return new HDD(HDD1.Vendor, HDD1.Value);
        }
        public object Clone()
        {
            
            return new HDD(Vendor, Value);
        }
    }
}
