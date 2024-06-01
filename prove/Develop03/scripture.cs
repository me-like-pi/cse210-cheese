using System;

class Scripture
{
    private string _referenceCPD;
    private string[] _bodyCPD;

    public Scripture()
    {
        Word newScriptureCPD = new Word();
        _bodyCPD = newScriptureCPD.GetBodyCPD();
        _referenceCPD = newScriptureCPD.GetReferenceCPD();

    }


    public void Display()
    {
        // Console.WriteLine($"{_referenceCPD}\n{_bodyCPD}" );
        Console.WriteLine(_referenceCPD);
        foreach (string word in _bodyCPD)
        {
            Console.Write(word + " ");
        }
        Console.WriteLine(); // To add a newline at the end
    }
}