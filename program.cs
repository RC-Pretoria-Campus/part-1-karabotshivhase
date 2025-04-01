        static string Logo()
        {
            return @"
     _______
    /       \
   /         \
  /____ ____ \
 |  _  |  _  ||
 | |_| | |_| ||
 |_____|_____||
  \_________/
   |___|___|
   |   |   |
   |   |   |
   |   |   |
   |___|___|
";
        }
        static void Greeting()
        {
            SpeechSynthesizer synth = new SpeechSynthesizer();
            synth.SetOutputToDefaultAudioDevice();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(Logo());
            synth.Speak("Hello am Cyberbot , Today I will be taking you through Cyber Security Awareness, feel free to ask me anything regarding Cyber Security.");
            synth.Speak("Remember to be respectful througout our adventure");
            string userName = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Red;
            
        }
        static void Introduction()
        {
            Console.WriteLine("Please enter your name");
            string userName = Console.ReadLine();            
        }
