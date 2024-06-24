public abstract class Goal
{
    public string Name;
    public int Points;

    public Goal(string name, int points)
    {
        Name = name;
        Points = points;
    }

    public abstract int RecordEvent();
    public abstract bool IsComplete();
    public abstract string GetStatus();
    public abstract string Serialize();
    public abstract void Deserialize(string[] data);
}
