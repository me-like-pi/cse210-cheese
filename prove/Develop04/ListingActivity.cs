// Listing activity class
    public class ListingActivity : Activity
    {
        public override void Start()
        {
            var prompts = new List<string>
            {
                "Who are people that you appreciate?",
                "What are personal strengths of yours?",
                "Who are people that you have helped this week?",
                "When have you felt the Holy Ghost this month?",
                "Who are some of your personal heroes?"
            };

            StartMessage("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
            
            // Shuffle prompts to avoid repetition
            prompts = prompts.OrderBy(x => Guid.NewGuid()).ToList();
            var prompt = prompts.First();
            Console.WriteLine(prompt);

            Console.WriteLine("You have a few seconds to think...");
            ShowAnimation(5);

            var startTime = DateTime.Now;
            int count = 0;
            while ((DateTime.Now - startTime).TotalSeconds < Duration)
            {
                Console.Write("Enter item: ");
                Console.ReadLine();
                count++;
            }
            Console.WriteLine($"You listed {count} items.");
            EndMessage("Listing Activity");
        }
    }
