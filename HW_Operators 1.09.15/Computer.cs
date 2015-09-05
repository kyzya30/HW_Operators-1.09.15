namespace HW_Operators_1._09._15
{
    internal class Computer 
    {
        public string HostName { get; set; }
        public string Description { get; set; }
        public CPU Cpu { get; set; }
        public RAM Ram { get; set; }
        public HDD Hdd { get; set; }
        public Computer(string hostName, string description, CPU cpu, RAM ram, HDD hdd)
        {
            HostName = hostName;
            Description = description;
            this.Cpu =cpu;
            this.Ram = ram;
            this.Hdd = hdd;
        }
        public object Clone()
        {
            return this;
        }
        public static Computer MadeBetterComputer(Computer firstPc, Computer secondPc)
        {
            string hostName = "Pool of Computers";
            string description = "Pool for GRID calculations";
            return new Computer(hostName, description, firstPc.Cpu + secondPc.Cpu, firstPc.Ram + secondPc.Ram, firstPc.Hdd + secondPc.Hdd);
        }
        public override string ToString()
        {
            return string.Format($"Host Name: {HostName} Description: {Description} \nCPU: {Cpu.Vendor} {Cpu.Value}\nHDD: {Hdd.Vendor} {Hdd.Value}\nRAM: {Ram.Vendor} {Ram.Value}");
        }
        public Computer DeepClone()
        {
            Computer other = (Computer) this.MemberwiseClone();
            HostName = other.HostName;
            Description = other.Description;
            Cpu = other.Cpu.Clone() as CPU;
            Ram = other.Ram.Clone() as RAM;
            Hdd = other.Hdd.Clone() as HDD;
            return other;
        }
    }
}
