class ReflectionActivity : Activity
{
    // atributes
    private string[] _reflections;
    // constructor
    public ReflectionActivity():base()
    {
        Console.WriteLine($"Reflection Activity: title {_title}, desc {_desc}, duration {_duration}");
    }
}