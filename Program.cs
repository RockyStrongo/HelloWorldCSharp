using System;
using System.Text.Json;
using System.ComponentModel;


public class Mainprogram
{
    public static void Main(string[] args)
    {
        Userinput userinput = new Userinput();
        GeolocAPIcall apicall = new GeolocAPIcall(userinput.inputstring);
        GeolocData mydata = JsonSerializer.Deserialize<GeolocData>(apicall.apiresponse);
        float longitude = mydata.data[0].longitude;
        float latitude = mydata.data[0].latitude;
        WeatherAPIcall meteocall = new WeatherAPIcall(longitude, latitude);
        Console.WriteLine(meteocall.apiresponse);
    }
}

