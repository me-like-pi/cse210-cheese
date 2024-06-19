    // Base class for all activities
    public abstract class Activity
    {
        protected int Duration;
        protected static List<string> activityLog = new List<string>();

        // Common start message for all activities
        public void StartMessage(string activityName, string description)
        {
            Console.WriteLine($"Starting {activityName}...");
            Console.WriteLine(description);
            Console.Write("Enter the duration in seconds: ");
            Duration = int.Parse(Console.ReadLine());
            Console.WriteLine("Prepare to begin...");
            ShowAnimation(3);
            activityLog.Add($"Started {activityName} at {DateTime.Now} for {Duration} seconds");
        }

        // Common end message for all activities
        public void EndMessage(string activityName)
        {
            Console.WriteLine($"Good job! You have completed the {activityName} activity for {Duration} seconds.");
            ShowAnimation(3);
            activityLog.Add($"Completed {activityName} at {DateTime.Now}");
        }

        // Show animation during pauses
        protected void ShowAnimation(int seconds)
        {
            for (int i = seconds; i > 0; i--)
            {
                Console.Write($"{i}...", flush: true);
                Thread.Sleep(1000); // Wait for 1 second
            }
            Console.WriteLine();
        }

        // Abstract method to start the activity, to be implemented by derived classes
        public abstract void Start();

        // Save activity log to a file
        public static void SaveLog()
        {
            File.WriteAllLines("activity_log.txt", activityLog);
        }

        // Load activity log from a file
        public static void LoadLog()
        {
            if (File.Exists("activity_log.txt"))
            {
                activityLog = File.ReadAllLines("activity_log.txt").ToList();
            }
        }
    }