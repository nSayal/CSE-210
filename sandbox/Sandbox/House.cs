
using System;
using System.Collections.Generic;

// Class representing a House
public class House
{
    public List<Room> Rooms { get; set; }

    public House()
    {
        Rooms = new List<Room>();
    }

    // Method to turn on/off all lights in the house
    public void TurnOnOffAllLights(bool turnOn)
    {
        foreach (var room in Rooms)
        {
            foreach (var device in room.Devices)
            {
                if (device is SmartLight)
                {
                    if (turnOn)
                        device.TurnOn();
                    else
                        device.TurnOff();
                }
            }
        }
    }
}
