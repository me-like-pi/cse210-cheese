public class EternalGoal : Goal
{
    public EternalGoal(string name, int points) : base(name, points) { }

    public override int RecordEvent()
    {
        return _points;
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
        return $"EternalGoal|{_name}|{_points}";
    }

    public override void Deserialize(string[] data)
    {
        _name = data[1];
        _points = int.Parse(data[2]);
    }
}
