using System;
using System.Collections.Generic;

// Class representing a Room
public class Room
{
    public string Name { get; set; }
    public List<SmartDevice> Devices { get; set; }

    public Room(string name)
    {
        Name = name;
        Devices = new List<SmartDevice>();
    }

    // Method to turn on all devices in the room
    public void TurnOnAllDevices()
    {
        foreach (var device in Devices)
        {
            device.TurnOn();
        }
    }

    // Method to turn off all devices in the room
    public void TurnOffAllDevices()
    {
        foreach (var device in Devices)
        {
            device.TurnOff();
        }
    }

    // Method to report all items in the room and their status
    public void ReportAllItems()
    {
        Console.WriteLine($"Items in Room '{Name}':");
        foreach (var device in Devices)
        {
            Console.WriteLine($"- {device.Name}: {device.GetStatus()}");
        }
    }

    // Method to report all items that are on
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

    // Method to report item that has been on the longest
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
