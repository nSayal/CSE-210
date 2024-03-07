using System;

class Program
{
    static void Main(string[] args)
    {
        // Create a house
        House house = new House();

        // Create rooms
        Room livingRoom = new Room("Living Room");
        Room bedroom = new Room("Bedroom");

        // Create devices
        SmartLight livingRoomLight = new SmartLight("Living Room Light");
        SmartLight bedroomLight = new SmartLight("Bedroom Light");
        SmartTV livingRoomTV = new SmartTV("Living Room TV");
        SmartHeater bedroomHeater = new SmartHeater("Bedroom Heater");

        // Add devices to rooms
        livingRoom.Devices.Add(livingRoomLight);
        livingRoom.Devices.Add(livingRoomTV);
        bedroom.Devices.Add(bedroomLight);
        bedroom.Devices.Add(bedroomHeater);

        // Add rooms to the house
        house.Rooms.Add(livingRoom);
        house.Rooms.Add(bedroom);

        // Turn on all lights in the living room
        livingRoom.TurnOnAllDevices();

        // Report all items in the living room
        livingRoom.ReportAllItems();

        // Turn off all lights in the house
        house.TurnOnOffAllLights(false);

        // Report all items in the living room
        livingRoom.ReportAllItems();

        // Report items that are on in the bedroom
        bedroom.ReportItemsOn();

        // Report item that has been on the longest in the living room
        livingRoom.ReportLongestOn();
    }
}
