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
        string namefound = mydata.data[0].name;
        WeatherAPIcall meteocall = new WeatherAPIcall(longitude, latitude);
        WeatherAPIdata meteo = JsonSerializer.Deserialize<WeatherAPIdata>(meteocall.apiresponse);
        float temp_actuelle = meteo.current_weather.temperature;
        Console.Write("La température actuelle à "+namefound+" est : "+temp_actuelle+"°C");
    }
}

