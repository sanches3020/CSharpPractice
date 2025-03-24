using System;

public delegate void LightControl(bool state); 

public class RoomLight
{
    public void TurnOn()
    {
        Console.WriteLine("Свет в комнате включен.");
    }

    public void TurnOff()
    {
        Console.WriteLine("Свет в комнате выключен.");
    }
}

public class StreetLight
{
    public void TurnOn()
    {
        Console.WriteLine("Уличный свет включен.");
    }

    public void TurnOff()
    {
        Console.WriteLine("Уличный свет выключен.");
    }
}

class Program
{
    static void Main()
    {
        RoomLight roomLight = new RoomLight();
        StreetLight streetLight = new StreetLight();

        LightControl roomLightControl = (state) => {
            if (state)
                roomLight.TurnOn();
            else
                roomLight.TurnOff();
        };

        LightControl streetLightControl = (state) => {
            if (state)
                streetLight.TurnOn();
            else
                streetLight.TurnOff();
        };

        roomLightControl(true); 
        streetLightControl(true); 

        roomLightControl(false); 
        streetLightControl(false); 
    }
}