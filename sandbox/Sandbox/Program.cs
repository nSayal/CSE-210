using System;

class Program
{
    static void Main(string[] args)
    {

        House house = new House();


        Room livingRoom = new Room("Living Room");
        Room bedroom = new Room("Bedroom");


        SmartLight livingRoomLight = new SmartLight("Living Room Light");
        SmartLight bedroomLight = new SmartLight("Bedroom Light");
        SmartTV livingRoomTV = new SmartTV("Living Room TV");
        SmartHeater bedroomHeater = new SmartHeater("Bedroom Heater");


        livingRoom.Devices.Add(livingRoomLight);
        livingRoom.Devices.Add(livingRoomTV);
        bedroom.Devices.Add(bedroomLight);
        bedroom.Devices.Add(bedroomHeater);


        house.Rooms.Add(livingRoom);
        house.Rooms.Add(bedroom);


        livingRoom.TurnOnAllDevices();


        livingRoom.ReportAllItems();


        house.TurnOnOffAllLights(false);


        livingRoom.ReportAllItems();


        bedroom.ReportItemsOn();


        livingRoom.ReportLongestOn();
    }
}
