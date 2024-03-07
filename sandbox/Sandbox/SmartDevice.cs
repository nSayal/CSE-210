using System;

public abstract class SmartDevice
{
    public string Name { get; set; }
    public bool IsOn { get; set; }
    public TimeSpan TimeOn { get; set; }


    public virtual void TurnOn()
    {
        IsOn = true;
        TimeOn = TimeSpan.Zero;
    }


    public virtual void TurnOff()
    {
        IsOn = false;
    }

    public virtual string GetStatus()
    {
        return IsOn ? "On" : "Off";
    }

  
    public virtual void UpdateTimeOn(TimeSpan timeElapsed)
    {
        if (IsOn)
        {
            TimeOn = TimeOn.Add(timeElapsed);
        }
    }
}
