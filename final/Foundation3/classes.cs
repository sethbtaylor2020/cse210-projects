using System;
using System.Collections.Concurrent;
using System.IO.Compression;
using System.Security.Cryptography.X509Certificates;

class Address 
{
    public string Useraddress;
    public string Country;

    public Address(string useraddress, string country)
    {
        Useraddress = useraddress;
        Country = country;
    }

    public string GetAddress()
    {
        return $"{Useraddress},{Country}";
    }
}

class Event
{
    public string Eventtype;
    public string Description;
    public string Date;
    public int Time;
    public Address EventAddress;

    public Event(string eventtype, string description, string date, int time, Address address)
    {
        Eventtype = eventtype;
        Description = description;
        Date = date;
        Time = time;
        EventAddress = address;
    }

    public string GetEventDetails()
{
    return $"This is a {Eventtype}, desc: {Description},Date: {Date}, Time: {Time}, Address: {EventAddress.GetAddress()}";
}
}
class Lecture : Event
{
    public string speaker;
    public int capacity;

    public Lecture(string eventtype, string description, string date, int time, Address address, string Speaker, int Capacity)
    : base(eventtype, description, date, time, address)
    {
        speaker = Speaker;
        capacity = Capacity;
    }
    public string GetLectureDetails()
    {
        return GetEventDetails() + $"{speaker}, {capacity}";
    }
}

class Reception : Event
{
    public string rsvpEmail;

    public Reception(string eventtype, string description, string date, int time, Address address, string rsvpemail)
    : base(eventtype, description, date, time, address)
    {
        rsvpemail = rsvpEmail;
    }

    public string GetReceptionDetails()
    {
        return GetEventDetails() + $"{rsvpEmail}";
    }
}

class OutdoorGathering : Event
{
    public string weatherForecast;

    public OutdoorGathering(string eventtype, string description, string date, int time, Address address, string weatherforecast)
        : base(eventtype, description, date, time, address)
    {
        weatherForecast = weatherforecast;
    }

    public string GetWeatherDetails()
    {
        return GetEventDetails() + $", Weather Forecast: {weatherForecast}";
    }

    public string GetWeather()
    {
        return weatherForecast;
    }

    
}

