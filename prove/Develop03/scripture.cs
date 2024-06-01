using System;
using System.Security.Cryptography.X509Certificates;

class Scripture
{
    private string _referenceCPD;
    private string _inputCPD;
    private string _dashesCPD;
    private int _randomNumberCPD;
    private string[] _bodyCPD;

    Word newScriptureCPD = new Word();
    Random randCPD = new Random();
    public Scripture()
    {
        
        _bodyCPD = newScriptureCPD.GetBodyCPD();
        _referenceCPD = newScriptureCPD.GetReferenceCPD();
        _dashesCPD = "____";

    }
    public void Display()
    {
        while (true)
        {
            _inputCPD = Console.ReadLine();
            

            if (_inputCPD.ToLower() == "quit")
            {
                break;
            }
            Console.Clear(); //Clear the console
            _randomNumberCPD = randCPD.Next(0, _bodyCPD.Length); //Pick a random number
            // Console.WriteLine(_randomNumberCPD); // debug:check the number
            _bodyCPD[_randomNumberCPD] = _dashesCPD; //select a random word
            Console.WriteLine(_referenceCPD);  // Console.WriteLine($"{_referenceCPD}\n{_bodyCPD}" );
            foreach (string word in _bodyCPD)
            {
                Console.Write(word + " ");
            }
            Console.WriteLine(); // To add a newline at the end
            Console.WriteLine("Press Enter to Continue or type 'quit' to exit.");
        }
    }
}