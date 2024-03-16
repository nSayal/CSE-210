class Goal
{
    // Fields
    protected bool isCompleted = false;
    private string name;
    private string description;
    private int points;

    // Constructor
    public Goal(string name, string description, int points)
    {
        this.name = name;
        this.points = points;
        this.description = description;
    }

    // Getter methods
    public string GetName()
    {
        return name;
    }

    public string GetDescription()
    {
        return description;
    }

    public int GetPoints()
    {
        return points;
    }

    public bool IsCompleted()
    {
        return isCompleted;
    }

    // Virtual methods
    public virtual void DisplayDetails(int index)
    {
    }

    public virtual string GetSaveString()
    {
        return "";
    }

    public virtual int Complete()
    {
        if (!isCompleted)
        {
            isCompleted = true;
            return points;
        }
        else
        {
            return 0;
        }
    }
}
