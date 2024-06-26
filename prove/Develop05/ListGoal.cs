public class ListGoal : Goal
{
    private int _targetCount;
    private int _currentCount;
    private int _bonusPoints;

    public ListGoal(string name, int points, int targetCount, int bonusPoints) : base(name, points)
    {
        _targetCount = targetCount;
        _currentCount = 0;
        _bonusPoints = bonusPoints;
    }

    public override int RecordEvent()
    {
        if (_currentCount < _targetCount)
        {
            _currentCount++;
            if (_currentCount == _targetCount)
            {
                return _points + _bonusPoints;
            }
            return _points;
        }
        return 0;
    }

    public override bool IsComplete()
    {
        return _currentCount >= _targetCount;
    }

    public override string GetStatus()
    {
        return $"[{_currentCount}/{_targetCount}]";
    }

    public override string Serialize()
    {
        return $"ListGoal|{_name}|{_points}|{_targetCount}|{_currentCount}|{_bonusPoints}";
    }

    public override void Deserialize(string[] data)
    {
        _name = data[1];
        _points = int.Parse(data[2]);
        _targetCount = int.Parse(data[3]);
        _currentCount = int.Parse(data[4]);
        _bonusPoints = int.Parse(data[5]);
    }
}