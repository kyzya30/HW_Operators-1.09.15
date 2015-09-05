using System;

namespace HW_Operators_1._09._15
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            RAM RAM1 = new RAM("GoodRam", 4096);
            CPU CPU1 = new CPU("Intel", 2);
            HDD HDD1 = new HDD("Seagate", 2000);
            Computer Сomputer0 = new Computer("FirstPC", "PC", CPU1, RAM1, HDD1);
            Computer Сomputer1 = Сomputer0.DeepClone();
            Console.WriteLine("Param of Computer0");
            Console.WriteLine(Сomputer0);
            Console.WriteLine("---------------------");
            Console.WriteLine("Computer.Deep Clone ");
            Console.WriteLine(Сomputer1);
            Console.WriteLine("Change some params int comp1");
            Сomputer1.Hdd.Vendor = "WesternDigital";
            Сomputer1.Cpu.Vendor = "AMD";
            Console.WriteLine("---------------------");
            Console.WriteLine("Computer.Deep Clone ");
            Console.WriteLine(Сomputer1);
            Console.WriteLine("---------------------");
            Computer Сomputer2 = Сomputer0.Clone() as Computer;
            Console.WriteLine("Computer2 clone computer0. Clone ");
            Console.WriteLine(Сomputer2);
            Console.WriteLine("---------------------");
            Console.WriteLine("Change some params in computer2");
            Сomputer2.Hdd.Vendor = "WesternDigital";
            Сomputer2.Cpu.Vendor = "AMD";
            Console.WriteLine("Show computer0");
            Console.WriteLine(Сomputer0);
            Console.WriteLine("---------------------");
            Console.WriteLine("Show computer2. Clone");
            Console.WriteLine(Сomputer2);
            Console.WriteLine("Create pool of 2 computers");
            Console.WriteLine(Computer.MadeBetterComputer(Сomputer0, Сomputer1));

           
        }
    }
}

  
