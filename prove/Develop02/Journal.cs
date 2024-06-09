// Define the Journal class to manage journal entries
class Journal
{
    private List<Entry> entries;

    // Constructor
    public Journal()
    {
        entries = new List<Entry>();
    }

    // Method to add a new entry
    public void AddEntry(string prompt, string response, string date)
    {
        entries.Add(new Entry(prompt, response, date));
    }

    // Method to display all entries
    public void DisplayJournal()
    {
        foreach (var entry in entries)
        {
            entry.DisplayEntry();
        }
    }

    // Method to save journal to a file
    public void SaveToFile(string filename)
    {
        using (StreamWriter writer = new StreamWriter(filename))
        {
            foreach (var entry in entries)
            {
                writer.WriteLine($"{entry.Date}|{entry.Prompt}|{entry.Response}");
            }
        }
    }

    // Method to load journal from a file
    public void LoadFromFile(string filename)
    {
        entries.Clear(); // Clear existing entries before loading from file
        using (StreamReader reader = new StreamReader(filename))
        {
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                string[] parts = line.Split('|');
                if (parts.Length == 3)
                {
                    AddEntry(parts[1], parts[2], parts[0]);
                }
            }
        }
    }
}