using System;

public class Goal
{
    private string _shortName;
    private string _description;

    public Goal() { }

    public Goal(string goalName, string goalDescription)
    {
        _shortName = goalName;
        _description = goalDescription;
    }

    public string GetGoalName()
    {
        return _shortName;
    }

    public void SetGoalName(string goalName)
    {
        _shortName = goalName;
    }

    public string GetGoalDescription()
    {
        return _description;
    }

    public void SetGoalDescription(string goalDescription)
    {
        _description = goalDescription;
    }

    public virtual void DisplayGoalPoints()
    {
        // Implementation can be provided in derived classes
    }

    public virtual int GetGoalPoints()
    {
        return 0;
    }

    public virtual bool GetGoalStatus()
    {
        return false;
    }

    public virtual string ToCSVRecord()
    {
        return "";
    }

    public virtual void RecordEvent()
    {
        // Implementation can be provided in derived classes
    }

    public string DisplayGoalName()
    {
        Console.Write("What is the name of your goal? ");
        _shortName = Console.ReadLine();
        return _shortName;
    }

    public string DisplayGoalDescription()
    {
        Console.Write("What is the description of your goal? ");
        _description = Console.ReadLine();
        return _description;
    }
}
