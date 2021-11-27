namespace HealthKitReport;

public class Reports
{
    private readonly List<WeightItem> _data;

    public Reports(List<WeightItem> data)
    {
        _data = data;
    }

    public void All()
    {
        Console.WriteLine("All");
        Console.WriteLine("Year\tMin\tMax\tAverage");
        var elems = _data.ToList();

        var min = elems.Select(x => x.Value).Min();
        var max = elems.Select(x => x.Value).Max();
        var average = elems.Select(x => x.Value).Average();
        
        Console.WriteLine($"all\t{min}\t{max}\t{average}");
    }
    public void Year()
    {
        Console.WriteLine("Year");
        Console.WriteLine("Year\tMin\tMax\tAverage");
        var years = _data.Select(x => x.Timestamp.ToString("yyyy")).Distinct().OrderBy(x => x).ToList();
        foreach (var year in years)
        {
            var elems = _data.Where(x => x.Timestamp.ToString("yyyy") == year).ToList();

            var min = elems.Select(x => x.Value).Min();
            var max = elems.Select(x => x.Value).Max();
            var average = elems.Select(x => x.Value).Average();
            
            Console.WriteLine($"{year}\t{min}\t{max}\t{average}");
        }
    }
    
    public void Month()
    {
        Console.WriteLine("Month");
        Console.WriteLine("Year-Month\tMin\tMax\tAverage");
        var years = _data.Select(x => x.Timestamp.ToString("yyyy-MM")).Distinct().OrderBy(x => x).ToList();
        foreach (var year in years)
        {
            var elems =  _data.Where(x => x.Timestamp.ToString("yyyy-MM") == $"{year}").ToList();
                
            var min = elems.Select(x => x.Value).Min();
            var max = elems.Select(x => x.Value).Max();
            var average = elems.Select(x => x.Value).Average();
        
            Console.WriteLine($"{year}\t{min}\t{max}\t{average}");
        }
    }
    
    public void Day()
    {
        Console.WriteLine("Day");
        Console.WriteLine("Year-Month-Day\tMin\tMax\tAverage");
        var years = _data.Select(x => x.Timestamp.ToString("yyyy-MM-dd")).Distinct().OrderBy(x => x).ToList();
        foreach (var year in years)
        {
            var elems =  _data.Where(x => x.Timestamp.ToString("yyyy-MM-dd") == $"{year}").ToList();
                
            var min = elems.Select(x => x.Value).Min();
            var max = elems.Select(x => x.Value).Max();
            var average = elems.Select(x => x.Value).Average();
        
            Console.WriteLine($"{year}\t{min}\t{max}\t{average}");
        }
    }
}