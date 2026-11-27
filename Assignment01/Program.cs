/*
 * Student ID :1670704335
 * Name       :thamakrit preyapanarakui
 * Section    :129A
 * No.        :6
 * Course     : GI113 Computer Programming (GI)
 */

using System;

namespace Assignment01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string GameTitle = "DeltaQuick";

            var runnerName = "Aero";
            var rankBadge = 'S';
            int boostCharges = 3;
            float dashCooldownSeconds = 2.5f;
            double energyReserve = 73.7;
            bool isTrackReady = true;

            Console.WriteLine(" ╔══════════════════════════════════════╗");
            Console.WriteLine($"║       {GameTitle} | RUNNER CARD      ║");
            Console.WriteLine(" ╠══════════════════════════════════════╣");
            Console.WriteLine($"║ Runner:{runnerName}.                 ║");
            Console.WriteLine($"║ Rank:{rankBadge}.                    ║");
            Console.WriteLine($"║ Dash cooldown: {dashCooldownSeconds}sec");
            Console.WriteLine($"║ Energy: {energyReserve}.             ║");
            Console.WriteLine($"║ Track ready: {isTrackReady}.         ║");
            Console.WriteLine(" ╠══════════════════════════════════════╣");
            double boostChargesAsDouble = boostCharges;
            Console.WriteLine($"║Boosts as double(implicit):{boostChargesAsDouble}");
            int energyTruncated = (int)energyReserve;
            int energyRounded = Convert.ToInt32(energyReserve);
            Console.WriteLine($"║ Energy cast(truncated):{energyTruncated}");
            Console.WriteLine($"║ Energy Convert(rounded):{energyRounded}");
            Console.WriteLine("╚══════════════════════════════════════╝");
        }
    }
}
