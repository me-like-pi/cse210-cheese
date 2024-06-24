public class EternalGoal : Goal
{
    public EternalGoal(string name, int points) : base(name, points) { }

    public override int RecordEvent()
    {
        return Points;
    }

    public override bool IsComplete()
    {
        return false; // Eternal goals are never complete
    }

    public override string GetStatus()
    {
        return "[∞]";
    }

    public override string Serialize()
    {
        return $"EternalGoal|{Name}|{Points}";
    }

    public override void Deserialize(string[] data)
    {
        Name = data[1];
        Points = int.Parse(data[2]);
    }
}
