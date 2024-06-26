public abstract class Goal
{
    public string _name;
    protected int _points;

    public Goal(string name, int points)
    {
        _name = name;
        _points = points;
    }

    public abstract int RecordEvent();
    public abstract bool IsComplete();
    public abstract string GetStatus();
    public abstract string Serialize();
    public abstract void Deserialize(string[] data);
}
