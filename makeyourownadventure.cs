using System;

namespace ChooseYourOwnAdventure {
    class makeyourownadventure {
        static void Main(string[] args) {
            /* THE MYSTERIOUS NOISE */

            // Start by asking for the user's name:
            Console.Write("What is your name?: ");
            string name = Console.ReadLine();
            Console.WriteLine($"Hello, {name}! Welcome to our story.");
            Console.WriteLine("It begins on a cold rainy night. You're sitting in your room and hear a noise coming from down the hall. Do you go investigate?");
            Console.Write("Type YES or NO: ");
            string noiseChoice = Console.ReadLine();
            string playerChoice = noiseChoice.ToUpper();
            if (playerChoice == "YES") {
                Console.WriteLine("You walk into the hallway and see a light coming from under a door down the hall.");
                Console.WriteLine("You Walk towards it. Do you open it or knock?");
            }
            else if (playerChoice == "NO") {

                Console.WriteLine("Not much of an adventure if we don't leave our room!");
                Console.WriteLine("THE END.");
            }
            Console.Write("Type OPEN or KNOCK: ");
            string choice = Console.ReadLine();
            string doorChoice = choice.ToUpper();
            if (doorChoice == "KNOCK") {
                Console.WriteLine("A voice behind the door speaks. It says, \"Answer this riddle: Poor people have it. Rich people need it. If you eat it you die. What is it?\"");
                Console.Write("Type your answer: ");
            }
            string riddle = Console.ReadLine();
            string riddleAnswer = riddle.ToUpper();
            if (riddleAnswer == "NOTHING") {
                Console.Write("The door opens and NOTHING is there.");

                Console.WriteLine("You turn off the light and run back to your room and lock the door.");
                Console.Write("THE END.");

            }
            if (riddleAnswer == "FUCK") {
                Console.WriteLine("\"Don't swear!\", the man behind the door says.");
                Console.WriteLine("You open the door and you find no one.");
                Console.WriteLine("THE END.");
            }
            else if (doorChoice == "OPEN") {
                Console.WriteLine("The door is locked! See if one of your three keys will open it.");
                Console.Write("Enter a number (1-3)");

            }
            else {
                Console.WriteLine("You answered incorrectly. The door doesn't open.");
                Console.Write("THE END.");
            }
            string key = Console.ReadLine();
            string keyChoice = key.ToUpper();
            switch (keyChoice) {
                case "1":
                    Console.WriteLine("You choose the first key. Lucky choice!");
                    Console.WriteLine("The door opens and NOTHING is there. Strange...");
                    Console.WriteLine("THE END.");
                    break;
                case "2":
                    Console.WriteLine("You choose the second key. The door doesn't open.");
                    Console.WriteLine("THE END.");
                    break;
                case "3":
                    Console.WriteLine("You choose the third key. The door doesn't open.");
                    Console.WriteLine("THE END.");
                    break;
            }
        }
    }
}