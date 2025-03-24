using System;

public class WaterLevelEventArgs : EventArgs
{
    public int WaterLevel { get; }

    public WaterLevelEventArgs(int waterLevel)
    {
        WaterLevel = waterLevel;
    }
}

public class WaterTankSensor
{
    public event EventHandler<WaterLevelEventArgs> WaterLevelChanged;

    private int waterLevel;

    public int WaterLevel
    {
        get => waterLevel;
        set
        {
            waterLevel = value;
            OnWaterLevelChanged(new WaterLevelEventArgs(waterLevel));
        }
    }

    protected virtual void OnWaterLevelChanged(WaterLevelEventArgs e)
    {
        WaterLevelChanged?.Invoke(this, e);
    }
}

public class WaterMonitor
{
    private WaterTankSensor sensor;

    public WaterMonitor(WaterTankSensor sensor)
    {
        this.sensor = sensor;
        sensor.WaterLevelChanged += PumpController.OnWaterLevelChanged;
        sensor.WaterLevelChanged += WarningSystem.OnWaterLevelChanged;
    }
}

public class PumpController
{
    public static void OnWaterLevelChanged(object sender, WaterLevelEventArgs e)
    {
        if (e.WaterLevel < 20)
        {
            Console.WriteLine("Включение насоса. Уровень воды низкий.");
        }
        else if (e.WaterLevel > 80)
        {
            Console.WriteLine("Выключение насоса. Уровень воды высокий.");
        }
    }
}

public class WarningSystem
{
    public static void OnWaterLevelChanged(object sender, WaterLevelEventArgs e)
    {
        if (e.WaterLevel > 90)
        {
            Console.WriteLine("Предупреждение: Уровень воды превышает 90%!");
        }
    }
}

class Program
{
    static void Main()
    {
        WaterTankSensor waterTankSensor = new WaterTankSensor();
        WaterMonitor waterMonitor = new WaterMonitor(waterTankSensor);

        waterTankSensor.WaterLevel = 15; 
        waterTankSensor.WaterLevel = 85;  
        waterTankSensor.WaterLevel = 95; 
    }
}