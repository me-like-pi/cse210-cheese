// Reflection activity class
    public class ReflectionActivity : Activity
    {
        public override void Start()
        {
            var prompts = new List<string>
            {
                "Think of a time when you stood up for someone else.",
                "Think of a time when you did something really difficult.",
                "Think of a time when you helped someone in need.",
                "Think of a time when you did something truly selfless."
            };
            var questions = new List<string>
            {
                "Why was this experience meaningful to you?",
                "Have you ever done anything like this before?",
                "How did you get started?",
                "How did you feel when it was complete?",
                "What made this time different than other times when you were not as successful?",
                "What is your favorite thing about this experience?",
                "What could you learn from this experience that applies to other situations?",
                "What did you learn about yourself through this experience?",
                "How can you keep this experience in mind in the future?"
            };

            StartMessage("Reflection Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
            
            // Shuffle prompts to avoid repetition
            prompts = prompts.OrderBy(x => Guid.NewGuid()).ToList();
            Console.WriteLine(prompts.First());

            var startTime = DateTime.Now;
            while ((DateTime.Now - startTime).TotalSeconds < Duration)
            {
                Console.WriteLine(questions[new Random().Next(questions.Count)]);
                ShowAnimation(5);
            }
            EndMessage("Reflection Activity");
        }
    }
