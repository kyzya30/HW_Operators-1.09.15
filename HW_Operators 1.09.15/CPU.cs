using System;

namespace HW_Operators_1._09._15
{
    class CPU: ICloneable
    {
        public string Vendor { get; set; }
        public int Value { get; set; }

        public CPU(string vendor, int value)
        {
            Vendor = vendor;
            Value = value;
        }
        public static CPU operator +(CPU CPU1, CPU CPU2)
        {
            if (CPU1.Value < CPU2.Value &&  CPU1.Vendor != CPU2.Vendor)
            {
                return new CPU(CPU2.Vendor, CPU2.Value);
            }
            if (CPU1.Vendor == CPU2.Vendor)
            {
                return new CPU(CPU1.Vendor, CPU1.Value + CPU2.Value);
            }
            return new CPU(CPU2.Vendor, CPU2.Value);
        }
        public object Clone()
        {
            return new CPU(Vendor, Value);
        }
    }
}
