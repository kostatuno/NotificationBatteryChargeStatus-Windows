using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace ConsoleApp2
{
    internal class Notification
    {
        private NotifyIcon notify;
        public BatteryChargeStatus Status;
        event Action ChangedChargeStatus;

        public Notification()
        {
            Status = SystemInformation.PowerStatus.BatteryChargeStatus;
            notify = new NotifyIcon();
        }

        public void Execute()
        {
            for (int i = 1; ;)
            {
                Status = SystemInformation.PowerStatus.BatteryChargeStatus;
                if (Status.HasFlag(BatteryChargeStatus.Charging) && i == 1)
                {
                    i--;
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Clear();
                    Console.WriteLine($"Charging is true");

                }
                else if (!Status.HasFlag(BatteryChargeStatus.Charging) && i == 0)
                {
                    i++;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Clear();
                    Console.WriteLine($"Charging is false");
                }
                var status = SystemInformation.PowerStatus.BatteryChargeStatus;
            }
        }
    }
}
