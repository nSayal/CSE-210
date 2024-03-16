class SimpleGoal : Goal
{
    private bool isCompleted;

    public SimpleGoal(string name, string description, int points, bool isCompleted)
        : base(name, description, points)
    {
        this.isCompleted = isCompleted;
    }

    public override void DisplayDetails(int index)
    {
        string status = isCompleted ? "[X]" : "[ ]";
        Console.WriteLine($"{index}. {status} {GetName()} ({GetDescription()})");
    }

    public override string GetSaveString()
    {
        return $"SimpleGoal,{GetName()},{GetDescription()},{GetPoints()},{isCompleted}";
    }
}
