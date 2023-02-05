using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Management;
using System.Windows.Forms;

namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var status = SystemInformation.PowerStatus.BatteryChargeStatus;

            for (int i = 1;;)
            {
                status = SystemInformation.PowerStatus.BatteryChargeStatus;
                if (status.HasFlag(BatteryChargeStatus.Charging) && i == 1)
                {
                    i--;
                    Console.Clear();
                    Console.WriteLine($"Charging is true");
                }
                else if (!status.HasFlag(BatteryChargeStatus.Charging) && i == 0)
                {
                    i++;
                    Console.Clear();
                    Console.WriteLine($"Charging is false");
                }
            }
        }
    }
}
