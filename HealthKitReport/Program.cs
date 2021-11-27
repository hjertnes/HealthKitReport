using HealthKitReport;

if (args.Length == 0)
{
    Console.WriteLine("You need to specify where the Apple HealthKit XML export is in the first argument");
    return 1;
}
Console.WriteLine();
var data = Parser.Parse(args.First());
var reports = new Reports(data);
reports.All();
Console.WriteLine();
reports.Year();
Console.WriteLine();
reports.Month();
Console.WriteLine();
reports.Day();
return 0;