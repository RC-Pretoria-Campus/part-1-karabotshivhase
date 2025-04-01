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
static void Conversation()
{
    while (true)
    {
        Console.WriteLine("Please enter your question");
        Console.ForegroundColor = ConsoleColor.Green;
        string question = Console.ReadLine().ToLower();
        string answer;
        switch (question)
        {
            case "how are you":
                answer = "I am doing great. Thank you for asking, how about you?.";
                break;
            case "am doing good":
                answer = "That's great to hear. How can I help you today?";
                break;
            case "am not doing good":
                answer = "I am sorry to hear that. How can I help you today?";
                break;
            case "what is cyber security":
                answer = "Cyber security is the practice of defending computers, servers, mobile devices, electronic systems, networks," +
                    " and data from malicious attacks." +
                    " It's also known as information technology security or electronic information security.";
                break;
            case "why is cyber security important":
                answer = "Cyber security is important because it encompasses everything that pertains to protecting our sensitive data, personally identifiable information (PII), protected health information (PHI), intellectual property, data, and governmental and industry information systems from theft and damage attempted by criminals and adversaries.";
                break;
            case "what are the types of cyber security threats":
                answer = "There are several types of cyber security threats, some of them include; Malware, Phishing, Ransomware,etc .";
                break;
            case "what is malware":
                answer = "Malware is a term used to describe malicious software, including spyware, ransomware, viruses, and worms. Malware is designed to cause damage to a computer or network.";
                break;
            case "what is phishing":
                answer = "Phishing is a type of social engineering attack often used to steal user data, including login credentials and credit card numbers. It occurs when an attacker, masquerading as a trusted entity, dupes a victim, into opening an email, instant message, or text message.";
                break;
            case "what is ransomware":
                answer = "Ransomware is a type of malware that encrypts a victim's files. The attacker then demands a ransom from the victim to restore access to the data upon payment.";
                break;
            case "what is a firewall":
                answer = "A firewall is a network security device that monitors incoming and outgoing network traffic and decides whether to allow or block specific traffic based on a defined set of security rules.";
                break;
            case "what is a VPN":
                answer = "A VPN, or Virtual Private Network, allows you to create a secure connection to another network over the Internet. VPNs can be used to access region-restricted websites, shield your browsing activity from prying eyes on public Wi-Fi, and more.";
                break;
            case "what is encryption":
                answer = "Encryption is the process of converting information or data into a code, especially to prevent unauthorized access.";
                break;
            case "How to avoid cyber security threats":
                answer = "To avoid cyber security threats, you should always keep your software up to date, use strong passwords, be cautious of suspicious emails, and use a VPN when connecting to public Wi-Fi.";
                break;
            case "How to avoid phishing attacks":
                answer = "To avoid phishing attacks, you should be cautious of suspicious emails, avoid clicking on links or downloading attachments from unknown sources, and verify the legitimacy of the sender before providing any personal information.";
                break;
            case "How to avoid malware attacks":
                answer = "To avoid malware attacks, you should keep your software up to date, use antivirus software, be cautious of suspicious websites, and avoid downloading files from unknown sources.";
                break;
            case "How to avoid ransomware attacks":
                answer = "To avoid ransomware attacks, you should be cautious of suspicious emails, avoid clicking on links or downloading attachments from unknown sources, and regularly back up your data.";
                break;
            case "How to protect your data":
                answer = "To protect your data, you should use strong passwords, enable two-factor authentication, encrypt sensitive information, and regularly back up your data.";
                break;
            case "exit":
                answer = "Thank you for chatting with me. Have a great day!";
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(answer);
                return;
            default:
                answer = "I am sorry, I do not have an answer to that question. Please ask me another question.";
                break;
        }
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine(answer);

        
    }
   
}
static void Main(string[] args)
{
    Greeting();
    Introduction();
    Conversation();
}
