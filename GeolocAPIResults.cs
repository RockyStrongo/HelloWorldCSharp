public class GeolocData
{
    public GeolocDataResult[]? data { get; set; }

}

public class GeolocDataResult
{
    public float latitude { get; set; }
    public float longitude { get; set; }
    public decimal confidence { get; set; }
    public string name { get; set; }

}
