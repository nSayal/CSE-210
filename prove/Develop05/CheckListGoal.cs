class CheckListGoal : Goal
{

    private int currentGoalCount;
    private int bonusCount;
    private int bonusPoints;

    // Constructor
    public CheckListGoal(string name, string description, int points, int bonusCount, int bonusPoints) : base(name, description, points)
    {

        this.bonusCount = bonusCount;
        this.bonusPoints = bonusPoints;
    }


    public override void DisplayDetails(int index)
    {
        if (IsCompleted())
        {
            Console.WriteLine($"{index}. [X] {GetName()} ({GetDescription()}) -- Currently Completed: {currentGoalCount}/{bonusCount}");
        }
        else
        {
            Console.WriteLine($"{index}. [ ] {GetName()} ({GetDescription()}) -- Currently Completed: {currentGoalCount}/{bonusCount}");
        }
    }


    public override int Complete()
    {
        if (!IsCompleted())
        {
            currentGoalCount += 1;
            if (currentGoalCount == bonusCount)
            {
                isCompleted = true;
                return GetPoints() + bonusPoints;
            }
            else
            {
                return GetPoints();
            }
        }
        else
        {
            return 0;
        }
    }

    public override string GetSaveString()
    {
        return $"CheckListGoal,{GetName()},{GetDescription()},{GetPoints()},{IsCompleted()}, {currentGoalCount}, {bonusPoints}, {bonusCount}";
    }
}
