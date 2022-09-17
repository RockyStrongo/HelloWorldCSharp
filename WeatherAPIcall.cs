using System;
using System.Net;
using System.IO;
using System.Globalization;



public class WeatherAPIcall
{
    const string baseurl = "https://api.open-meteo.com/v1/forecast?";

    public string apicallurl;
    public float latitude;
    public float longitude;
    public string apiresponse;




    public WeatherAPIcall(float latitude, float longitude)
    {
        this.latitude = latitude;
        this.longitude = longitude;
        this.apicallurl = generateURL(this.latitude, this.longitude);
        this.apiresponse = getCurrentTemperature(this.apicallurl);
    }

    public static string generateURL(float latitude, float longitude)
    {

        //https://api.open-meteo.com/v1/forecast?latitude=52.52&longitude=13.41&current_weather=true
        string apiurl = baseurl + "latitude=" + converttodotdecimal(latitude) + "&longitude=" + converttodotdecimal(longitude) + "&current_weather=true";
        return apiurl;

    }

    public static string getCurrentTemperature(string url)
    {

        string content = "";

        try
        {
            using (WebClient client = new WebClient())
            {
                content = client.DownloadString(url);
            }
        }
        catch (WebException e)
        {
            Console.WriteLine("Cannot establish connection - " + e.ToString());
        }

        return content;
    }

    public static string converttodotdecimal(float a){
        string b = Convert.ToString(a, new CultureInfo("en-US"));
        return b;
    }

}



//http://api.positionstack.com/v1/forward?access_key=e60b1044fe11bb35a448ae3154347cb1&query=Lyon