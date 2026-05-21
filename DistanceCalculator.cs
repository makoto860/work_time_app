public static class DistanceCalculator
{
    public static double ToRad(double deg)
    {
        return deg * Math.PI / 180;
    }

    public static double GetDistanceKm(double lat1, double lon1, double lat2, double lon2)
    {
        double R = 6371;

        double dLat = ToRad(lat2 - lat1);
        double dLon = ToRad(lon2 - lon1);

        double a =
            Math.Sin(dLat / 2) * Math.Sin(dLat / 2) +
            Math.Cos(ToRad(lat1)) * Math.Cos(ToRad(lat2)) *
            Math.Sin(dLon / 2) * Math.Sin(dLon / 2);

        double c = 2 * Math.Atan2(Math.Sqrt(a), Math.Sqrt(1 - a));

        return R * c;
    }

    public static double GetWalkingTimeMinutes(double distanceKm, double speedKmH = 4.8)
    {
        return (distanceKm / speedKmH) * 60;
    }
}
