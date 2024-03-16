class GoalSaver
{
    public GoalSaver()
    {
        
    }

    public void SaveGoalsToFile(List<Goal> goals)
    {
        // Ask user for the filename
        Console.Write("Enter the filename to save goals: ");
        string filename = Console.ReadLine();

        using (StreamWriter writer = new StreamWriter(filename))
        {
            foreach (Goal goal in goals)
            {
                writer.WriteLine(goal.GetSaveString());
            }
        }
    }
}