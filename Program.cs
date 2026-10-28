using System;
class Program
{
    static void Main(string[] args)
    {
        var ikebukuro = new Station
        {
            Name = "池袋",
            Latitude = 35.7295,
            Longitude = 139.7109
        };

        var otsuka = new Station
        {
            Name = "大塚",
            Latitude = 35.7314,
            Longitude = 139.7285
        };

        double distance = DistanceCalculator.GetDistanceKm(
            ikebukuro.Latitude, ikebukuro.Longitude,
            otsuka.Latitude, otsuka.Longitude
        );

        double time = DistanceCalculator.GetWalkingTimeMinutes(distance);

        Console.WriteLine($"{ikebukuro.Name} → {otsuka.Name}");
        Console.WriteLine($"距離: {distance:F2} km");
        Console.WriteLine($"徒歩時間: 約{time:F1} 分");
    }
}
