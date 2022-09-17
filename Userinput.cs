using System;

public class Userinput
{
       public string inputstring;
       public Userinput()
       {
            this.inputstring = askcity();

       }
       
       private static string askcity()
        {
            Console.WriteLine("Entrez votre ville : ");
            string inputstring = Console.ReadLine();
            Console.WriteLine("Vous avez saisi : " + inputstring);
            return inputstring;
        }

    }