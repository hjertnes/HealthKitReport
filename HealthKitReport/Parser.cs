using System.Xml;

namespace HealthKitReport;

public static class Parser
{
    public static List<WeightItem> Parse(string filename)
    {
        var data = new List<WeightItem>();
        
        XmlReaderSettings settings = new XmlReaderSettings();
        settings.DtdProcessing = DtdProcessing.Parse;

        using XmlReader reader = XmlReader.Create(filename, settings);
        while (reader.Read())
        {
            if (reader.Name == "Record" && reader.GetAttribute("type") == "HKQuantityTypeIdentifierBodyMass")
            {
                var timestamp = reader.GetAttribute("startDate");
                var value = reader.GetAttribute("value");
            
                data.Add(new WeightItem
                {
                    Timestamp = DateTime.Parse(timestamp ?? throw new NullReferenceException("Timestamp")),
                    Value = Double.Parse(value ?? throw new NullReferenceException("Value"))
                });
            }
        }

        return data;
    }
}