class EternalGoal : Goal
{

    public EternalGoal(string name, string description, int points) : base(name, description, points)
    {

    }

    
    public override void DisplayDetails(int index)
    {
        Console.WriteLine($"{index}. [ ] {GetName()} ({GetDescription()})");
    }


    public override int Complete()
    {
        return GetPoints();
        
    }

    public override string GetSaveString()
    {
        return $"EternalGoal,{GetName()},{GetDescription()},{GetPoints()},{IsCompleted()}";
        
    }
}
