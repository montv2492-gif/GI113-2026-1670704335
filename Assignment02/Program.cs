/*
 * Student ID :1670704335
 * Name       :thamakrit preyapanarakui
 * Section    :129A
 * No.        :-
 * Course     : GI113 Computer Programming (GI)
 */
using System.Globalization;

const string MaterialName = "Iron";
const double SmeltRate = 0.25;
const double SalvageRate = 0.3;
const double MaxBatch = 500.0;

Console.WriteLine("-----------------------------------");
Console.WriteLine("--Welcome to the Forge--");
Console.WriteLine("-----------------------------------");
Console.WriteLine(FormattableString.Invariant($"=> {MaterialName} Smelting {SmeltRate:F4} / Salvage {SalvageRate:F4}"));
Console.WriteLine($"=> Key 'S' for Smelt (Ore -> Ingot)");
Console.WriteLine($"=> Key 'B' for Breakdown (Ingot -> Ore)");

Console.Write("=> Choose Menu:");
string menuInput = Console.ReadLine() ?? string.Empty;
bool menuWasParsed = char.TryParse(menuInput, out char menu);

Console.Write("=> How much would you like:");
string amountInput = Console.ReadLine() ?? string.Empty;
bool amountIsValid =
    double.TryParse(amountInput, NumberStyles.Float, CultureInfo.InvariantCulture, out double amount)
    && amount > 0
    && amount <= MaxBatch;

if (amountIsValid)
{
    if (menuWasParsed && (menu == 'S' || menu == 's'))
    {
        double ingot = amount * SmeltRate;
        Console.WriteLine(FormattableString.Invariant($"=>{amount:F2}{MaterialName}Ore ={ingot:F2}{MaterialName}Ingot"));
    }
    else if (menuWasParsed && (menu == 'B' || menu == 'b'))
    {
        double ore = amount / SalvageRate;
        Console.WriteLine(FormattableString.Invariant($"=> {amount:F2}{MaterialName} Ingot = {ore:F2}{MaterialName} Ore"));
    }
    else
    {
        Console.WriteLine("Error: Invalid menu. Choose S or B.");
    }
}
else
{
    Console.WriteLine($"Error: Invalid amount. Enter a number greater than 0 and no more than{MaxBatch:F0}.");
}
