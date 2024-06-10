class BreathingActivity : Activity
{
    // atributes
    private string[] _Breathings;
    // constructor
    public BreathingActivity():base()
    {
        Console.WriteLine($"Breathing Activity: title {_title}, desc {_desc}, duration {_duration}");
    }
}