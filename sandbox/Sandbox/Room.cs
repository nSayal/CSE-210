using System;
using System.Collections.Generic;


public class Room
{
    public string Name { get; set; }
    public List<SmartDevice> Devices { get; set; }

    public Room(string name)
    {
        Name = name;
        Devices = new List<SmartDevice>();
    }


    public void TurnOnAllDevices()
    {
        foreach (var device in Devices)
        {
            device.TurnOn();
        }
    }


    public void TurnOffAllDevices()
    {
        foreach (var device in Devices)
        {
            device.TurnOff();
        }
    }


    public void ReportAllItems()
    {
        Console.WriteLine($"Items in Room '{Name}':");
        foreach (var device in Devices)
        {
            Console.WriteLine($"- {device.Name}: {device.GetStatus()}");
        }
    }


    public void ReportItemsOn()
    {
        Console.WriteLine($"Items that are on in Room '{Name}':");
        foreach (var device in Devices)
        {
            if (device.IsOn)
            {
                Console.WriteLine($"- {device.Name}");
            }
        }
    }

   
    public void ReportLongestOn()
    {
        TimeSpan longestTime = TimeSpan.Zero;
        SmartDevice longestDevice = null;

        foreach (var device in Devices)
        {
            if (device.TimeOn > longestTime)
            {
                longestTime = device.TimeOn;
                longestDevice = device;
            }
        }

        if (longestDevice != null)
        {
            Console.WriteLine($"Item that has been on the longest in Room '{Name}':");
            Console.WriteLine($"- {longestDevice.Name} ({longestDevice.TimeOn})");
        }
        else
        {
            Console.WriteLine("No devices are currently on in this room.");
        }
    }
}
