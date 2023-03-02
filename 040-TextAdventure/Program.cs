string diracton;
bool wepon = false;
bool goulAlive = true;
string fleeOrFight;
bool deadEnd = false;
int roomCoordinatesWestEast = 0;
int roomCoordinatesNorthSauth = 0;
bool finished = false;
bool superWepon = false;



void WelcomingIntro()
{
    Console.Clear();
    System.Console.WriteLine("Welcome to the Adventure Game!");
    System.Console.WriteLine("==============================");
    System.Console.WriteLine("As an avid traveler, you have decided to visit the Catacombs of Paris.However, during your exploration, you find yourself lost. You can choose to walk in multiple directions to find a way out.");
    System.Console.WriteLine("Lets start with your name: ");
    string name = Console.ReadLine()!;
    System.Console.WriteLine($"Good Luck {name}");
    System.Console.WriteLine("");
}

void IntroScene()
{
    System.Console.WriteLine("You are at a crossroads, and you can choose to go down any of the four hallways. Where would you like to go?");
    System.Console.WriteLine("Options: north/east/south/west");
    diracton = Console.ReadLine()!;
    System.Console.WriteLine("");
    if (diracton == "north")
    {
        System.Console.WriteLine("Sorry dead end  you have to turn back");
        deadEnd = true;
    }
}

void ShowShadowFigure()
{
    do
    {
        System.Console.WriteLine("You see a wall of skeletons as you walk into the room. Someone is watching you. Where would you like to go?");
        System.Console.WriteLine("Options: north/south/west");
        diracton = Console.ReadLine()!;
        System.Console.WriteLine("");
        if (diracton == "south")
        {
            System.Console.WriteLine("Sorry dead end  you have to turn back");
            deadEnd = true;
        }
    } while (deadEnd);
}

void CameraScene()
{
    System.Console.WriteLine("You see a camera that has been dropped on the ground. Someone has been here recently. Where would you like to go?");
    System.Console.WriteLine("Options: north/south");
    diracton = Console.ReadLine()!;
    System.Console.WriteLine("");
}

void HauntedRoom()
{
    System.Console.WriteLine("You hear strange voices. You think you have awoken some of the dead. Where would you like to go?");
    System.Console.WriteLine("Options: north/east/west");
    diracton = Console.ReadLine()!;
    System.Console.WriteLine("");
}

void ShowSkeletons()
{
    System.Console.WriteLine("You see a wall of skeletons as you walk into the room. Someone is watching you. Where would you like to go?");
    System.Console.WriteLine("Options: north/east/west");
    diracton = Console.ReadLine()!;
    System.Console.WriteLine("");
    if (diracton == "north")
    {
        System.Console.WriteLine("Sorry dead end  you have to turn back");
        deadEnd = true;
        wepon = true;
    }
}

void StrangeCreature()
{
    if (goulAlive)
    {
        System.Console.WriteLine("A strange Goul-like creature has appeared. You can either run or fight it. What would you like to do?");
        System.Console.WriteLine("Options: flee/fight");
        fleeOrFight = Console.ReadLine()!;
        if (fleeOrFight == "flee")
        {
            System.Console.WriteLine("Options: south/west");
            diracton = Console.ReadLine()!;
            System.Console.WriteLine("");
        }
        else if (fleeOrFight == "fight")
        {
            if (wepon)
            {
                System.Console.WriteLine("You kill the goul with the knife you found earlier");
                System.Console.WriteLine("Options: south/west");
                diracton = Console.ReadLine()!;
                System.Console.WriteLine("");

            }
            else
            {
                System.Console.WriteLine("Oh no the goul killed you,because you had no knife.");
                finished = true;
            }
        }

    }
    else if (!goulAlive)
    {
        System.Console.WriteLine("You see #the Goul-like creature that you killed earlier. What a relief! Where would you like to go?");
        System.Console.WriteLine("Options: south/west");
        diracton = Console.ReadLine()!;
        System.Console.WriteLine("");
    }
}

void DeadRoom()
{
    if (!superWepon)
    {
        System.Console.WriteLine("Multiple Goul-like creatures start emerging as you enter the room. You are killed.");
        finished = true;
    }
    else
    {
        System.Console.WriteLine("You survived the dead room, Now you can go on");
        System.Console.WriteLine("Options: south/west");
        diracton = Console.ReadLine()!;
        System.Console.WriteLine("");
    }

}

void ExitRoom()
{
    System.Console.WriteLine("Yaaay!!! You found the exit!!!! ");
    finished = true;
}

void Treasury()
{
    System.Console.WriteLine("You found the treasury and there you find a superWepon");
    superWepon = true;
}

WelcomingIntro();
do
{
    if (roomCoordinatesNorthSauth == 0 && roomCoordinatesWestEast == 0) { IntroScene(); }
    else if (roomCoordinatesNorthSauth == 0 && roomCoordinatesWestEast == 1) { ShowSkeletons(); }
    else if (roomCoordinatesNorthSauth == 0 && roomCoordinatesWestEast == 2) { StrangeCreature(); }
    else if (roomCoordinatesNorthSauth == 0 && roomCoordinatesWestEast == -1) { ShowShadowFigure(); }
    else if (roomCoordinatesNorthSauth == 1 && roomCoordinatesWestEast == -1) { CameraScene(); }
    else if (roomCoordinatesNorthSauth == 1 && roomCoordinatesWestEast == 2) { Treasury(); }
    else if (roomCoordinatesNorthSauth == 2 && roomCoordinatesWestEast == -1) { ExitRoom(); }
    else if (roomCoordinatesNorthSauth == -1 && roomCoordinatesWestEast == -1) { DeadRoom(); }
    else if (roomCoordinatesNorthSauth == -1 && roomCoordinatesWestEast == 0) { HauntedRoom(); }
    else if (roomCoordinatesNorthSauth == -1 && roomCoordinatesWestEast == 1) { ExitRoom(); }
    else if (roomCoordinatesNorthSauth == -1 && roomCoordinatesWestEast == 2) { ExitRoom(); }
} while (!finished);
