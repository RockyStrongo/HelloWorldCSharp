using System;
using System.Net;
using System.IO;

public class GeolocAPIcall
{
    const string apikey = "e60b1044fe11bb35a448ae3154347cb1";
    const string baseurl = "http://api.positionstack.com/v1/forward?";

    public string apicallurl;
    public string userinput;
    public string apiresponse;




    public GeolocAPIcall(string input)
    {
        this.userinput = input;
        this.apicallurl = generateURL(this.userinput);
        this.apiresponse = getCoordinates(this.apicallurl);
    }

    public static string generateURL(string input)
    {
        string apiurl = baseurl + "access_key=" + apikey + "&query=" + input;
        return apiurl;

    }

    public static string getCoordinates(string url)
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

}



//http://api.positionstack.com/v1/forward?access_key=e60b1044fe11bb35a448ae3154347cb1&query=Lyon