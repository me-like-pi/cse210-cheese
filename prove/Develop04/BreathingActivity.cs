// Breathing activity class
    public class BreathingActivity : Activity
    {
        public override void Start()
        {
            StartMessage("Breathing Activity", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.");
            for (int i = 0; i < Duration / 6; i++)
            {
                Console.WriteLine("Breathe in...");
                ShowBreathingAnimation(3, true);
                Console.WriteLine("Breathe out...");
                ShowBreathingAnimation(3, false);
            }
            EndMessage("Breathing Activity");
        }

        // More meaningful breathing animation
        private void ShowBreathingAnimation(int seconds, bool isInhale)
        {
            int delay = 500; // milliseconds
            int steps = seconds * 1000 / delay;
            char arrow = isInhale ? '\u2191' : '\u2193'; // Up arrow for inhale, down arrow for exhale
            for (int i = 0; i < steps; i++)
            {
                Console.Write(arrow);
                Console.Out.Flush(); // Explicitly flush the console buffer
                Thread.Sleep(delay);
            }
            Console.WriteLine();
        }
    }