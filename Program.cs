using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotPrototype
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create original Service Robot
            ServiceRobot serviceRobot =
                new ServiceRobot(
                    "SR-100",
                    10,
                    "v1.0",
                    "Patient Assistance"
                );

            Console.WriteLine("Original Service Robot");
            serviceRobot.DisplayInfo();

            Console.WriteLine();

            // Clone Service Robot
            ServiceRobot clonedServiceRobot =
                (ServiceRobot)serviceRobot.Clone();

            // Customize cloned robot
            clonedServiceRobot.BatteryCapacity = 15;
            clonedServiceRobot.SoftwareVersion = "v2.0";

            Console.WriteLine("Cloned Service Robot");
            clonedServiceRobot.DisplayInfo();

            Console.WriteLine("--------------------------------");

            // Create original Industrial Robot
            IndustrialRobot industrialRobot =
                new IndustrialRobot(
                    "IR-200",
                    20,
                    "v1.5",
                    "Welding"
                );

            Console.WriteLine("Original Industrial Robot");
            industrialRobot.DisplayInfo();

            Console.WriteLine();

            // Clone Industrial Robot
            IndustrialRobot clonedIndustrialRobot =
                (IndustrialRobot)industrialRobot.Clone();

            // Customize cloned robot
            clonedIndustrialRobot.BatteryCapacity = 25;
            clonedIndustrialRobot.SoftwareVersion = "v2.0";

            Console.WriteLine("Cloned Industrial Robot");
            clonedIndustrialRobot.DisplayInfo();

            Console.WriteLine("--------------------------------");

            // Create original Entertainment Robot
            EntertainmentRobot entertainmentRobot =
                new EntertainmentRobot(
                    "ER-300",
                    8,
                    "v1.2",
                    "Dancing and Singing"
                );

            Console.WriteLine("Original Entertainment Robot");
            entertainmentRobot.DisplayInfo();

            Console.WriteLine();

            // Clone Entertainment Robot
            EntertainmentRobot clonedEntertainmentRobot =
                (EntertainmentRobot)entertainmentRobot.Clone();

            // Customize cloned robot
            clonedEntertainmentRobot.BatteryCapacity = 12;
            clonedEntertainmentRobot.SoftwareVersion = "v2.1";

            Console.WriteLine("Cloned Entertainment Robot");
            clonedEntertainmentRobot.DisplayInfo();

            Console.ReadLine();
        }
    }
}
