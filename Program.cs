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
        static Boolean hasBearhead = false;
        
        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to world of Noah\nCommands:\n- Enter use (item) to use items\n- Enter i to open inventory\n- Enter n, e ,s or w to move that direction ");

            while (!quit) { 
                display();

                String v = readInput();
                if (v == "n" || v == "s" || v == "e" || v == "w") {
                    move(v);
                } else if (v == "quit"|| v == "q") {
                    quit = true;
                } else if (v == "p" || v == "use sword" || v == "t" || v == "c") { 
                    actions(v);
                } else {
                    otherCrap(v);
                }
            }
        }

        static String readInput() {
                return Console.ReadLine();
        }

        static void otherCrap(String v) {
            if (v == "i") {
                Console.Clear();
                Console.WriteLine("Your inventory: ");
                if (hasSword) 
                    Console.WriteLine("Sword");

                if (hasBearPoo)
                    Console.WriteLine("grape");

                if (hasBearhead)
                    Console.WriteLine("Bear Head");
            }    
            else {
                Console.Clear();
                Console.WriteLine("That doesnt work"); 
            }        
        }
            static void display() {
            // display of ground levels
            //Console.WriteLine("You are at {0}, {1} ", x, y);
            if (x==0 && y==0 && z == 0) {
                Console.WriteLine("You are in a clearing. ");
            } else if (x==0 && y==1 && z == 0) {                
                Console.WriteLine("You reach a small meadow. ");
            } else if (x==0 && y==2 && z == 0 && !bearDead) {                
                Console.WriteLine("You see a huge BEAR! Run! "); // tidy up
            } else if (x == 0 && y==2 && z == 0 && bearDead) {
                Console.WriteLine("You have slain the bear");    
            }else if (x==1 && y==1 && z == 0) {                
                Console.WriteLine("There is a beanstalk. A guard blocks the way.\nEnter t to talk");
            }else if (x==1 && y==2 && z == 0) {
                Console.WriteLine("You reach the edge of a dark forest. There are bear tracks leading west. ");
            }else if (x==2 && y==1 && z == 0) {                
                Console.WriteLine("Climbing up a slope you reach a cliff edge facing east. ");
            }else if (x==2 && y==2 && z == 0) {                
                Console.WriteLine("Abandoned village");
            }else if (x==1 && y==0 && z == 0) {               
                Console.WriteLine("You reach a road going east. ");
            }else if (x==2 && y==0 && z == 0) {                
                Console.WriteLine("You are at a moat. A large castle looms before you but it seems un-accesible.");
                if (!hasSword)
                    Console.WriteLine("As you search the area you see a sword\nEnter p to take it!");         

            // display of cloud levels below        
            }else if (x==0 && y==0 && z == 1) {               
                Console.WriteLine("You see a sphinx sitting in a hottub"); // add talk
            }else if (x==0 && y==1 && z == 1) {               
                Console.WriteLine("There is a well. On closer inspection it leads to ground level far below. You wouldnt want to fall down.");
            }else if (x==0 && y==2 && z == 1) {               
                Console.WriteLine("Theres a BEAR AGAIN! This time its made of clouds."); // not important . add stabbing featur that doesnt work
            }else if (x==1 && y==1 && z == 1) {               
                Console.WriteLine("This is the top of the bean stalk. All around you is a world on top of clouds.\nEnter c to climb down the bean stalk. ");
            }else if (x==1 && y==2 && z == 1) {               
                Console.WriteLine("fart ");
            }else if (x==2 && y==1 && z == 1) {               
                Console.WriteLine("You see a shack with an old man sitting on a pool doughnut. Maybe you can talk to him"); // add talk feature
            }else if (x==2 && y==2 && z == 1) {               
                Console.WriteLine("neasa smells bad ");
            }else if (x==1 && y==0 && z == 1) {               
                Console.WriteLine("The clouds here make the shape of a stairs so you ascend them. Looking around you are now able to make out something moving to the west.");
            }else if (x==2 && y==0 && z == 1) {               
                Console.WriteLine("There is a parking lot. A man is sitting on the ground. He gares at you as you walk by so you dont bother talking to him but you do hear him muttering about the sword he lost.");
            }
        }

        static void move(String v)
        { //quit
            if (v == "e") {
                Console.Clear();
                x += 1;
            } else if (v == "w") { 
                Console.Clear();
                x -= 1;
            } else if (v == "n") {
                Console.Clear();
                y += 1;
            } else if (v == "s") {
                Console.Clear();
                y -= 1;
            }


            if (x > 2) {                                    //block crossing edge
                x -=1;
                Console.Clear();
                Console.WriteLine("That way is blocked"); 
            }
            if (y > 2) {
                y -=1;
                Console.Clear();
                Console.WriteLine("That way is blocked");
            }
            if (x < 0) {
                x +=1;
                Console.Clear();
                Console.WriteLine("That way is blocked");
            }
            if (y < 0) {
                y +=1;
                Console.Clear();
                Console.WriteLine("That way is blocked");  //block crossing edge
            }
       }
        static void actions(String v) {
            if (v == "p" && x == 2 && y == 0 && z == 0) { 
                Console.Clear();
                if (!hasSword) {
                    Console.WriteLine("You got sword");
                    hasSword = true;
                }
            } else if (v == "p" && x == 1 && y == 2 && z == 0) { 
                Console.Clear();
                if (!hasBearPoo) {
                    Console.WriteLine("You haz Poo");
                    hasBearPoo = true;
                }
            } else if (v == "t" && x == 1 && y == 1 && z == 0) { 
                Console.Clear();
                if (!bearDead) {
                    Console.WriteLine("Guard: You can only pass if you have proven yourself in combat");
                }
                if (bearDead && hasBearhead) {
                    Console.WriteLine("You give the guard the bears head.\nGuard:Wow you have proven yourself. You may now climb the beanstalk. press c to climb");
                    climbBean = true;
                    hasBearhead = false;
                }
                else {
                     Console.WriteLine("Guard: You may now climb the beanstalk. press c to climb");
                    climbBean = true;
                }      
            } else if (v == "use sword" && x == 0 && y == 2 && z == 0 && !bearDead) { 
                Console.Clear();
                if (hasSword) {
                    Console.WriteLine("You attack the bear with the sword. You take its head to prove you are worthy.");
                    bearDead = true;
                    hasBearhead = true;
                }
            } else if (v == "c" && x == 1 && y == 1 && z == 0 && climbBean) {
                Console.Clear(); {
                Console.WriteLine("You climb up the bean stalk carefully. As you climb you realise you have reached cloud land. ");
                z += 1;
                }
            } else if (v == "c" && x == 1 && y == 1 && z == 1 && climbBean) {
                Console.Clear(); {
                Console.WriteLine("You climb down the bean stalk carefully, returning to ground level.");
                z -= 1;}
            }
            else {
                Console.Clear();
                Console.WriteLine("That doesnt work"); 
            }        
        }
    }
}
