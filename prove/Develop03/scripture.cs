using System;

class Scripture
{
    private string _referenceCPD;
    private string _bodyCPD;

    public Scripture()
    {
        Reference newScriptureCPD = new Reference();
        _bodyCPD = newScriptureCPD.GetScriptureCPD();
        _referenceCPD = newScriptureCPD.GetScriptureCPD();

    }


    public void Display()
    {
        Console.WriteLine($"{_bodyCPD}, {_referenceCPD}" );
    }
}