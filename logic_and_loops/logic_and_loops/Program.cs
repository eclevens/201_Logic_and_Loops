namespace logic_and_loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //variables
            string playerName = "adventurer";
            string userChoice = "NONE";

            //program start
            Console.Write("Welcome to the jungle\nWe got fun and games\nWe got everything you want\nHoney, we know the names\n\n");
            Console.WriteLine("Wait... I don't actually know your name.");
            Console.WriteLine("What is your name?");
            Console.WriteLine("[Please enter your name, then press 'ENTER' on the keyboard]");

            //Grab some user input
            playerName = Console.ReadLine();
            Console.WriteLine("\nWelcome to the jungle " + playerName + "!");

            // continue
            Console.WriteLine("" +
                "We approach a clearing in the jungle\n" +
                "There seems to be a trail to the left...\n" +
                "And a cave entrance to the right.\n"
                );
            //cont
            Console.WriteLine("Which path do you chose?");
            Console.WriteLine("Type 'left' to choose the path and go left or type 'right' to choose the cave and go right.");
            //input 2
            userChoice = Console.ReadLine();
            Console.WriteLine("\nYou chose: " + userChoice + "\n");

            //Select our path
            if (userChoice == "left")
            {
                //Go to the left
                Console.WriteLine("You chose to go to the left and follow the path. At the end there is a pot of gold, and you're free!");

            }
            else if (userChoice == "right")
            {
                //Go to the right
                Console.WriteLine("You go to the right and end up in the cave. You get lost in the dark and never escape!");
            }
            else
            {
                //Oh no! the user typed in something else.
                userChoice = "NONE";
                while (userChoice != "left" && userChoice != "right" && userChoice != "up")
                {
                    Console.WriteLine("Please enter either 'left', 'right', or our now super secret answer of 'up'.");
                    userChoice = Console.ReadLine();
                    Console.WriteLine("\nYou chose: " + userChoice + "\n");
                }
                if (userChoice == "left")
                {
                    //Go to the left
                    Console.WriteLine("You chose to go to the left and follow the path. At the end there is a pot of gold, and you're free!");
                }
                else if (userChoice == "right")
                {
                    //Go to the right
                    Console.WriteLine("You go to the right and end up in the cave. You get lost in the dark and never escape!");
                }
                else if (userChoice == "up")
                {
                    //Easter Egg
                    Console.WriteLine("'up' seriously? 'up'!? How can we go up? UP YOURS! |_(O_O)_/ **Flips keyboard** CLOSE THE PROGRAM!");
                }
                else
                {
                    Console.WriteLine("I honestly don't know how you got here. Congrats.");
                }
            }
        }
    }
}
