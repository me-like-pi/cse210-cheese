// Define the Entry class to represent a journal entry
class Entry
{
    // atributes
    public string _prompt { get; set; }
    public string _response { get; set; }
    public string _date { get; set; }

    // Constructor
    public Entry(string prompt, string response, string date)
    {
        _prompt = prompt;
        _response = response;
        _date = date;
    }

    // Method to display an entry
    public void DisplayEntry()
    {
        Console.WriteLine($"Date: {_date}");
        Console.WriteLine($"Prompt: {_prompt}");
        Console.WriteLine($"Response: {_response}");
        Console.WriteLine();
    }
}