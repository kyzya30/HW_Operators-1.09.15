using System;

namespace HW_Operators_1._09._15
{
    class RAM : ICloneable
    {
        public string Vendor { get; set; }
        public int Value { get; set; }

        public RAM(string vendor, int value)
        {
            Vendor = vendor;
            Value = value;
        }
        public static RAM operator +(RAM RAM1, RAM RAM2)
        {
            if (RAM1.Value < RAM2.Value && RAM1.Vendor != RAM2.Vendor)
            {
                return new RAM(RAM2.Vendor, RAM2.Value);
            }
            if (RAM1.Vendor == RAM2.Vendor)
            {
                return new RAM(RAM1.Vendor, RAM1.Value + RAM2.Value);
            }
            return new RAM(RAM1.Vendor, RAM1.Value);
        }
        public object Clone()
        {
            return new RAM(Vendor, Value);
        }
    }
}
