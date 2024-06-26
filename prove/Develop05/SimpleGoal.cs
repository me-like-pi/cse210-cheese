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
            return _points;
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
        return $"SimpleGoal|{_name}|{_points}|{_isComplete}";
    }

    public override void Deserialize(string[] data)
    {
        _name = data[1];
        _points = int.Parse(data[2]);
        _isComplete = bool.Parse(data[3]);
    }
}
