using System;

class Word
{
    private string _referenceCPD;
    private string _bodyCPD;
    private string[] _verseCPD;
    
    Reference newScriptureCPD = new Reference();
    Random randCPD = new Random();
    public Word()
    {
        _bodyCPD = newScriptureCPD.GetScriptureCPD();
        _referenceCPD = newScriptureCPD.GetChapterCPD();
        _verseCPD = _bodyCPD.Split(' ');

        // Generate a random integer between 0 and the length of the list.
        // int randomNumberCPD = randCPD.Next(0, _verseCPD.Length);
        // // Console.WriteLine(randomNumberCPD);
        // _verseCPD[randomNumberCPD] = _dashesCPD;
        
    }
    public string GetReferenceCPD()
        {
            // Notice that this is not stored as a member variable.
            // Is is just a temporary, local variable that will be recomputed each time this is called.
            string textCPD = _referenceCPD;
            return textCPD;
        }
    public string[] GetBodyCPD()
    {
        // Notice that this is not stored as a member variable.
        // Is is just a temporary, local variable that will be recomputed each time this is called.
        string[] textCPD = _verseCPD;
        return textCPD;
    }
}