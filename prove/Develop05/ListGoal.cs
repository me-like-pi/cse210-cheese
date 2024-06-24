public class ListGoal : Goal
{
    public int TargetCount { get; set; }
    public int CurrentCount { get; set; }
    public int BonusPoints { get; set; }

    public ListGoal(string name, int points, int targetCount, int bonusPoints)
        : base(name, points)
    {
        TargetCount = targetCount;
        CurrentCount = 0;
        BonusPoints = bonusPoints;
    }

    public override int RecordEvent()
    {
        if (CurrentCount < TargetCount)
        {
            CurrentCount++;
            if (CurrentCount == TargetCount)
            {
                return Points + BonusPoints;
            }
            return Points;
        }
        return 0;
    }

    public override bool IsComplete()
    {
        return CurrentCount >= TargetCount;
    }

    public override string GetStatus()
    {
        return $"[{CurrentCount}/{TargetCount}]";
    }

    public override string Serialize()
    {
        return $"ListGoal|{Name}|{Points}|{TargetCount}|{CurrentCount}|{BonusPoints}";
    }

    public override void Deserialize(string[] data)
    {
        Name = data[1];
        Points = int.Parse(data[2]);
        TargetCount = int.Parse(data[3]);
        CurrentCount = int.Parse(data[4]);
        BonusPoints = int.Parse(data[5]);
    }
}