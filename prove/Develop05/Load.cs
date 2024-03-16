class GoalLoader
{
    public GoalLoader()
    {
    }

    public void LoadGoalsFromFile(List<Goal> goals)
    {
        Console.WriteLine("Enter the filename to load goals from: ");
        string filename = Console.ReadLine();

        using (StreamReader reader = new StreamReader(filename))
        {
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                string[] parts = line.Split(',');

                if (parts.Length == 5)
                {
                    string goalType = parts[0];
                    string name = parts[1];
                    string description = parts[2];
                    int points = int.Parse(parts[3]);
                    bool isCompleted = bool.Parse(parts[4]);

                    if (goalType == "SimpleGoal")
                    {
                        SimpleGoal simpleGoal = new SimpleGoal(name, description, points, isCompleted);
                        goals.Add(simpleGoal);
                    }
                    else if (goalType == "EternalGoal")
                    {
                        EternalGoal eternalGoal = new EternalGoal(name, description, points);
                        goals.Add(eternalGoal);
                    }
                }
                else if (parts.Length == 8)
                {
                    string name = parts[1];
                    string description = parts[2];
                    int points = int.Parse(parts[3]);
                    bool isCompleted = bool.Parse(parts[4]);
                    int currentGoal = int.Parse(parts[5]);
                    int bonusPoints = int.Parse(parts[6]);
                    int bonus = int.Parse(parts[7]);

                    CheckListGoal checklistGoal = new CheckListGoal(name, description, points, bonus, bonusPoints);
                    goals.Add(checklistGoal);
                }
            }
        }
    }
}
