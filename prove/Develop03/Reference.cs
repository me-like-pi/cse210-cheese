using System;

class Reference
{
    private string _scriptureCPD;
    private string _chapterCPD;

    public Reference()
    {
        _scriptureCPD = "Yea, and as often as my people repent will I forgive them thier trespasses against me.";
        _chapterCPD = "Mosiah 26:30";
    }

    public string GetScriptureCPD()
        {
            // Notice that this is not stored as a member variable.
            // Is is just a temporary, local variable that will be recomputed each time this is called.
            string textCPD = _scriptureCPD;
            return textCPD;
        }
    public string GetChapterCPD()
            {
                // Notice that this is not stored as a member variable.
                // Is is just a temporary, local variable that will be recomputed each time this is called.
                string chapCPD = _chapterCPD;
                return chapCPD;
            }
    public void Display()
    {
        Console.WriteLine($"{_chapterCPD}\n{_scriptureCPD}");
    }
}