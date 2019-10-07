using System;

namespace hello
{
    class Program
    {
        static int x = 0;
        static int y = 0;
        static int z = 0;
        static Boolean hasSword = false;
        static Boolean hasBearPoo = false;
        static Boolean quit = false;
        static Boolean bearDead = false;
        static Boolean climbBean = false;
        static Boolean hasBearHead = false;

        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to Noah's World");
            Console.WriteLine();
            Console.WriteLine("Commands:");
            Console.WriteLine("Enter `use (item)` to use items.");
            Console.WriteLine("Enter i to open inventory.");
            Console.WriteLine("Enter m to show the map.");
            Console.WriteLine("Enter n, e ,s or w to move in that direction.");

            while (!quit)
            {
                display();

                String userInput = readInput();
                if (userInput == "n" || userInput == "s" || userInput == "e" || userInput == "w")
                {
                    move(userInput);
                }
                else if (userInput == "quit" || userInput == "q")
                {
                    quit = true;
                }
                else if (userInput == "p" || userInput == "use sword" || userInput == "t" || userInput == "c")
                {
                    actions(userInput);
                }
                else
                {
                    otherCrap(userInput);
                }
            }
        }

        static String readInput()
        {
            return Console.ReadLine();
        }

        static void otherCrap(String v)
        {
            if (v == "i")
            {
                Console.Clear();
                Console.WriteLine("Your inventory: ");
                if (hasSword)
                    Console.WriteLine("Sword");

                if (hasBearPoo)
                    Console.WriteLine("grape");

                if (hasBearHead)
                    Console.WriteLine("Bear Head");
            }
            else if (v.Equals("m"))
            {
                map();
            }
            else
            {
                Console.Clear();
                Console.WriteLine("That doesnt work");
            }
        }
        static void display()
        {
            // display of ground levels
            // Console.WriteLine("You are at {0}, {1} ", x, y);
            if (x == 0 && y == 0 && z == 0)
            {
                Console.WriteLine("You are in a clearing. ");
            }
            else if (x == 0 && y == 1 && z == 0)
            {
                Console.WriteLine("You reach a small meadow. ");
            }
            else if (x == 0 && y == 2 && z == 0 && !bearDead)
            {
                Console.WriteLine("You see a huge BEAR! Run! "); // tidy up
            }
            else if (x == 0 && y == 2 && z == 0 && bearDead)
            {
                Console.WriteLine("You have slain the bear");
            }
            else if (x == 1 && y == 1 && z == 0)
            {
                Console.WriteLine("There is a beanstalk. A guard blocks the way.\nEnter t to talk");
            }
            else if (x == 1 && y == 2 && z == 0)
            {
                Console.WriteLine("You reach the edge of a dark forest. There are bear tracks leading west. ");
            }
            else if (x == 2 && y == 1 && z == 0)
            {
                Console.WriteLine("Climbing up a slope you reach a cliff edge facing east. ");
            }
            else if (x == 2 && y == 2 && z == 0)
            {
                Console.WriteLine("Abandoned village");
            }
            else if (x == 1 && y == 0 && z == 0)
            {
                Console.WriteLine("You reach a road going east. ");
            }
            else if (x == 2 && y == 0 && z == 0)
            {
                Console.WriteLine("You are at a moat. A large castle looms before you but it seems un-accesible.");
                if (!hasSword)
                    Console.WriteLine("As you search the area you see a sword\nEnter p to take it!");

                // display of cloud levels below        
            }
            else if (x == 0 && y == 0 && z == 1)
            {
                Console.WriteLine("You see a sphinx sitting in a hottub"); // add talk
            }
            else if (x == 0 && y == 1 && z == 1)
            {
                Console.WriteLine("There is a well. On closer inspection it leads to ground level far below. You wouldnt want to fall down.");
            }
            else if (x == 0 && y == 2 && z == 1)
            {
                Console.WriteLine("Theres a BEAR AGAIN! This time it looks like a ghost.");
            }
            else if (x == 1 && y == 1 && z == 1)
            {
                Console.WriteLine("This is the top of the bean stalk. All around you is a world on top of clouds.\nEnter c to climb down the bean stalk. ");
            }
            else if (x == 1 && y == 2 && z == 1)
            {
                Console.WriteLine("placeholder 2 ");
            }
            else if (x == 2 && y == 1 && z == 1)
            {
                Console.WriteLine("You see a shack with an old man sitting on a pool doughnut. Maybe you can talk to him"); // add talk feature
            }
            else if (x == 2 && y == 2 && z == 1)
            {
                Console.WriteLine("placeholder ");
            }
            else if (x == 1 && y == 0 && z == 1)
            {
                Console.WriteLine("The clouds here make the shape of a stairs so you ascend them. Looking around you are now able to make out something moving to the west.");
            }
            else if (x == 2 && y == 0 && z == 1)
            {
                Console.WriteLine("There is a parking lot. A man is sitting on the ground. He gares at you as you walk by so you dont bother talking to him but you do hear him muttering about the sword he lost.");
            }
        }

        static void move(String direction)
        { //quit
            if (direction == "e")
            {
                Console.Clear();
                x += 1;
            }
            else if (direction == "w")
            {
                Console.Clear();
                x -= 1;
            }
            else if (direction == "n")
            {
                Console.Clear();
                y += 1;
            }
            else if (direction == "s")
            {
                Console.Clear();
                y -= 1;
            }


            if (x > 2)
            {                                    //block crossing edge
                x -= 1;
                Console.Clear();
                Console.WriteLine("That way is blocked");
            }
            if (y > 2)
            {
                y -= 1;
                Console.Clear();
                Console.WriteLine("That way is blocked");
            }
            if (x < 0)
            {
                x += 1;
                Console.Clear();
                Console.WriteLine("That way is blocked");
            }
            if (y < 0)
            {
                y += 1;
                Console.Clear();
                Console.WriteLine("That way is blocked");  //block crossing edge
            }
        }
        static void actions(String v)
        {
            if (v == "p" && x == 2 && y == 0 && z == 0)
            {
                Console.Clear();
                if (!hasSword)
                {
                    Console.WriteLine("You got sword");
                    hasSword = true;
                }
            }
            else if (v == "p" && x == 1 && y == 2 && z == 0)
            {
                Console.Clear();
                if (!hasBearPoo)
                {
                    Console.WriteLine("You has grape");
                    hasBearPoo = true;
                }
            }
            else if (v == "t" && x == 1 && y == 1 && z == 0)
            {
                Console.Clear();
                if (!bearDead && !climbBean)
                {
                    Console.WriteLine("Guard: You can only pass if you have proven yourself in combat");
                }
                if (bearDead && hasBearHead)
                {
                    Console.WriteLine("You give the guard the bears head.\nGuard: Wow you have proven yourself. ");
                    climbBean = true;
                    hasBearHead = false;
                    bearDead = false;
                }
                if (!bearDead && climbBean)
                {
                    Console.WriteLine("Guard: You may now climb the beanstalk. press c to climb");
                    climbBean = true;
                }
            }
            else if (v == "use sword" && x == 0 && y == 2 && z == 0 && !bearDead)
            {
                Console.Clear();
                if (hasSword)
                {
                    Console.WriteLine("You attack the bear with the sword. You take its head to prove you are worthy.");
                    bearDead = true;
                    hasBearHead = true;
                }
            }
            else if (v == "use sword" && x == 0 && y == 2 && z == 1)
            {
                Console.Clear();
                Console.WriteLine("You attack the bear with the sword. However this time, the sword goes thoruh it and does nothing. You should probably run now.");
            }
            else if (v == "t" && x == 2 && y == 1 && z == 1)
            {
                Console.Clear();
                Console.WriteLine("Old Man: Hey there Jerry, havent seen you around these parts in years!");
                Console.WriteLine("You: Umm im not Jerry.");
                Console.WriteLine("Old Man: Anyway Jerry yesterday I went fishing and caught a flying fish! It was a rare brown one as well which coincidentally is my favourite colour.");
                Console.WriteLine("Old Man: So I was going to cook him when suddenly a bear runs over and takes it from me... And thats why I dont celebrate easter when I'm hungry.");
                Console.WriteLine("You: (thinking) What a wierd man.");

            }
            else if (v == "c" && x == 1 && y == 1 && z == 0 && climbBean)
            {
                Console.Clear();
                {
                    Console.WriteLine("You climb up the bean stalk carefully. As you climb you realise you have reached some sort of new world on top of the clouds. ");
                    z += 1;
                }
            }
            else if (v == "c" && x == 1 && y == 1 && z == 1 && climbBean)
            {
                Console.Clear();
                {
                    Console.WriteLine("You climb down the bean stalk carefully, returning to ground level.");
                    z -= 1;
                }
            }
            else
            {
                Console.Clear();
                Console.WriteLine("That doesnt work");
            }
        }
        static void map()
        {
            String mapLine = "\"\"\"";

            if (z == 1)
            {
                mapLine = "~~~";
            }

            if (y == 0)
            {
                Console.Clear();
                Console.WriteLine(mapLine);
                Console.WriteLine(mapLine);
                printMe(mapLine);

            }
            else if (y == 1)
            {
                Console.Clear();
                Console.WriteLine(mapLine);
                printMe(mapLine);
                Console.WriteLine(mapLine);
            }
            else if (y == 2)
            {
                Console.Clear();
                printMe(mapLine);
                Console.WriteLine(mapLine);
                Console.WriteLine(mapLine);
            }
        }

        static void printMe(String mapLine)
        {
            char[] line = mapLine.ToCharArray();
            line[x] = 'X';

            Console.WriteLine(line);
        }
    }
}
