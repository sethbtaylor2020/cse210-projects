using System;
using System.ComponentModel.DataAnnotations;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("123 wagon lane", "USA ");
        Address address2 = new Address("456 candy road", "Canada ");
        Address address3 = new Address("456 ocean road", "Canada ");
        Lecture lecture1 = new Lecture("Lecture", "this will be a lecture", "3/14", 5, address1, "Dana White", 500);
        Reception reception1 = new Reception("Reception", "this is a reception", "3/14", 5, address2, "canada@gmail.com");
        OutdoorGathering outdoorgathering1 = new OutdoorGathering("Outdoor Gathering", "this is an outdoor gathering", "3/14", 5, address3, "rain");
        Console.WriteLine("\n--- Lecture Details ---");
        Console.WriteLine(lecture1.GetLectureDetails());

        Console.WriteLine("\n--- Reception Details ---");
        Console.WriteLine(reception1.GetReceptionDetails());

        Console.WriteLine("\n--- Outdoor Gathering Details ---");
        Console.WriteLine(outdoorgathering1.GetWeatherDetails());
    }
}