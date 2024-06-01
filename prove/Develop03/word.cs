using System;

class Word
{
    private string _referenceCPD;
    private string _bodyCPD;
    private string[] _verseCPD;
    Reference newScriptureCPD = new Reference();
    public Word()
    {
        // Reference newScriptureCPD = new Reference();
        _bodyCPD = newScriptureCPD.GetScriptureCPD();
        _referenceCPD = newScriptureCPD.GetChapterCPD();
        _verseCPD = _bodyCPD.Split(' ');

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





//     string sentence = "Yea, and as often as my people repent will I forgive them their trespasses against me.";
// string[] words = sentence.Split(' ');

// foreach (string word in words)
// {
//     Console.WriteLine(word);
// }

}