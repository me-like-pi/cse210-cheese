public class ListGoal : Goal
{
    public int TargetCount;
    public int CurrentCount;
    public int BonusPoints;
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
}