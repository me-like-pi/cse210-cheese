public class SimpleGoal : Goal
{
    private bool _isComplete;

    public SimpleGoal(string name, int points) : base(name, points)
    {
        _isComplete = false;
    }

    public override int RecordEvent()
    {
        if (!_isComplete)
        {
            _isComplete = true;
            return Points;
        }
        return 0;
    }

    public override bool IsComplete()
    {
        return _isComplete;
    }

    public override string GetStatus()
    {
        return _isComplete ? "[X]" : "[ ]";
    }

    public override string Serialize()
    {
        return $"SimpleGoal|{Name}|{Points}|{_isComplete}";
    }

    public override void Deserialize(string[] data)
    {
        Name = data[1];
        Points = int.Parse(data[2]);
        _isComplete = bool.Parse(data[3]);
    }
}