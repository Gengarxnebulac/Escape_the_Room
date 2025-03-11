namespace Escape_the_Room;

class Program
{
    static void Main(string[] args)
    {
        int exitCode = 0;
        while (true)
        {
            Console.Clear();
            printtitle();
            int option = showMenu();
            if (option == 18)
            {
                createmap();
            }
            else if (option == 22)
            {
                 exitCode = EXIT();
                if (exitCode == 75)
                {
                    break;
                }
            }
            else if (option == 20)
            {
                devinfo();
            }
        }
    }

    static void printtitle()
    {
        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.SetCursorPosition(16, 3);
        Console.WriteLine(" ________                                                     __     __                     _______                                 ");
        Console.SetCursorPosition(16, 4);
        Console.WriteLine("|        \\                                                   |  \\   |  \\                   |       \\                                ");
        Console.SetCursorPosition(16, 5);
        Console.WriteLine("| \u2593\u2593\u2593\u2593\u2593\u2593\u2593\u2593 _______  _______  ______   ______   ______       _| \u2593\u2593_  | \u2593\u2593____   ______      | \u2593\u2593\u2593\u2593\u2593\u2593\u2593\\ ______   ______  ______ ____  ");
        Console.SetCursorPosition(16, 6);
        Console.WriteLine("| \u2593\u2593__    /       \\/       \\|      \\ /      \\ /      \\     |   \u2593\u2593 \\ | \u2593\u2593    \\ /      \\     | \u2593\u2593__| \u2593\u2593/      \\ /      \\|      \\    \\ ");
        Console.SetCursorPosition(16, 7);
        Console.WriteLine("| \u2593\u2593  \\  |  \u2593\u2593\u2593\u2593\u2593\u2593\u2593  \u2593\u2593\u2593\u2593\u2593\u2593\u2593 \\\u2593\u2593\u2593\u2593\u2593\u2593\\  \u2593\u2593\u2593\u2593\u2593\u2593\\  \u2593\u2593\u2593\u2593\u2593\u2593\\     \\\u2593\u2593\u2593\u2593\u2593\u2593 | \u2593\u2593\u2593\u2593\u2593\u2593\u2593\\  \u2593\u2593\u2593\u2593\u2593\u2593\\    | \u2593\u2593    \u2593\u2593  \u2593\u2593\u2593\u2593\u2593\u2593\\  \u2593\u2593\u2593\u2593\u2593\u2593\\ \u2593\u2593\u2593\u2593\u2593\u2593\\\u2593\u2593\u2593\u2593\\");
        Console.SetCursorPosition(16, 8);
        Console.WriteLine("| \u2593\u2593\u2593\u2593\u2593   \\\u2593\u2593    \\| \u2593\u2593      /      \u2593\u2593 \u2593\u2593  | \u2593\u2593 \u2593\u2593    \u2593\u2593      | \u2593\u2593 __| \u2593\u2593  | \u2593\u2593 \u2593\u2593    \u2593\u2593    | \u2593\u2593\u2593\u2593\u2593\u2593\u2593\\ \u2593\u2593  | \u2593\u2593 \u2593\u2593  | \u2593\u2593 \u2593\u2593 | \u2593\u2593 | \u2593\u2593");
        Console.SetCursorPosition(16, 9);
        Console.WriteLine("| \u2593\u2593_____ _\\\u2593\u2593\u2593\u2593\u2593\u2593\\ \u2593\u2593_____|  \u2593\u2593\u2593\u2593\u2593\u2593\u2593 \u2593\u2593__/ \u2593\u2593 \u2593\u2593\u2593\u2593\u2593\u2593\u2593\u2593      | \u2593\u2593|  \\ \u2593\u2593  | \u2593\u2593 \u2593\u2593\u2593\u2593\u2593\u2593\u2593\u2593    | \u2593\u2593  | \u2593\u2593 \u2593\u2593__/ \u2593\u2593 \u2593\u2593__/ \u2593\u2593 \u2593\u2593 | \u2593\u2593 | \u2593\u2593");
        Console.SetCursorPosition(16, 10);
        Console.WriteLine("| \u2593\u2593     \\       \u2593\u2593\\\u2593\u2593     \\\\\u2593\u2593    \u2593\u2593 \u2593\u2593    \u2593\u2593\\\u2593\u2593     \\       \\\u2593\u2593  \u2593\u2593 \u2593\u2593  | \u2593\u2593\\\u2593\u2593     \\    | \u2593\u2593  | \u2593\u2593\\\u2593\u2593    \u2593\u2593\\\u2593\u2593    \u2593\u2593 \u2593\u2593 | \u2593\u2593 | \u2593\u2593");
        Console.SetCursorPosition(16, 11);
        Console.WriteLine(" \\\u2593\u2593\u2593\u2593\u2593\u2593\u2593\u2593\\\u2593\u2593\u2593\u2593\u2593\u2593\u2593  \\\u2593\u2593\u2593\u2593\u2593\u2593\u2593 \\\u2593\u2593\u2593\u2593\u2593\u2593\u2593 \u2593\u2593\u2593\u2593\u2593\u2593\u2593  \\\u2593\u2593\u2593\u2593\u2593\u2593\u2593        \\\u2593\u2593\u2593\u2593 \\\u2593\u2593   \\\u2593\u2593 \\\u2593\u2593\u2593\u2593\u2593\u2593\u2593     \\\u2593\u2593   \\\u2593\u2593 \\\u2593\u2593\u2593\u2593\u2593\u2593  \\\u2593\u2593\u2593\u2593\u2593\u2593 \\\u2593\u2593  \\\u2593\u2593  \\\u2593\u2593");
        Console.SetCursorPosition(16, 12);
        Console.WriteLine("                                    | \u2593\u2593                                                                                            ");
        Console.SetCursorPosition(16, 13);
        Console.WriteLine("                                    | \u2593\u2593                                                                                            ");
        Console.SetCursorPosition(16, 14);
        Console.WriteLine("                                     \\\u2593\u2593                                                                                            \n");
    }

    static int showMenu()
    {
        Console.ForegroundColor = ConsoleColor.White;
        ConsoleKey keyPressed;
        int cursorX = 18;
        Console.SetCursorPosition(70, 18);
        Console.WriteLine("[ ] START THE GAME");
        Console.SetCursorPosition(70, 20);
        Console.WriteLine("[ ] Dev Information");
        Console.SetCursorPosition(70, 22);
        Console.WriteLine("[ ] EXIT THE GAME");
        Console.SetCursorPosition(71, 18);
        while (true)
        {
            try
            {
                Console.SetCursorPosition(71, cursorX);
                keyPressed = Console.ReadKey(true).Key;
                if (keyPressed == ConsoleKey.DownArrow && cursorX < 22)
                {
                    cursorX += 2;
                }
                else if (keyPressed == ConsoleKey.UpArrow && cursorX > 18)
                {
                    cursorX -= 2;
                }
                else if (keyPressed == ConsoleKey.Enter)
                {
                    return cursorX;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
            
        }
        return 0;
    }

    static void createmap()
    {
        string space = String.Concat(Enumerable.Repeat(" ", 152));
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.SetCursorPosition(9,2);
        Console.WriteLine("\u250f");
        for (int i = 0; i < space.Length; i++)
        {
            Console.SetCursorPosition(i + 10,2);
            Console.Write("\u2501");
        }
        Console.WriteLine("\u2513");
        for (int i = 3; i < 23; i++)
        {
            Console.SetCursorPosition(9, i);
            Console.WriteLine("\u2503" + space + "\u2503");
        }
        Console.SetCursorPosition(9, 23);
        Console.WriteLine("\u2517");
        for (int i = 0; i < space.Length; i++)
        {
            Console.SetCursorPosition(i + 10,23);
            Console.Write("\u2501");
        }
        Console.WriteLine("\u251b");
        int[] bombcord = bombs();
        play(bombcord);
    }

    static int play(int[] bombcord)
    {
        int x = 10;
        int y = 3;
        Console.SetCursorPosition(x, y);
        Console.Write('P');
        Console.SetCursorPosition(x, y);
        while (true)
        {
            ConsoleKey keyPressed = Console.ReadKey(true).Key;
            if (keyPressed == ConsoleKey.UpArrow && 3 < y)
            {
                y--;
            }
            else if (keyPressed == ConsoleKey.DownArrow && 22 > y)
            {
                y++;
            }
            else if (keyPressed == ConsoleKey.LeftArrow && 10 < x)
            {
                x--;
            }
            else if (keyPressed == ConsoleKey.RightArrow && 161 > x)
            {
                x++;
            }
            Console.Write(' ');
            Console.SetCursorPosition(x, y);
            Console.Write('P');
            Console.SetCursorPosition(x, y);
            if (y == bombcord[x - 10])
            {
                explosion(x,y);
                break;
            }
            else if (x == 160)
            {
                winning();
                break;
            }
        }
        return 0;
    }

    static int[] bombs()
    {
        int[] bombcor = new int[159];
        int cord;
        for (int i = 0; i < 152; i++)
        {
            cord = new Random().Next(3, 23);
            bombcor[i] = cord;
            Console.SetCursorPosition(i + 10, cord);
            Console.Write('X');
        }
        return bombcor;
    }

    static void explosion(int x, int y)
    {
        Console.ForegroundColor = ConsoleColor.White;
        Console.SetCursorPosition(11, 25);
        Console.WriteLine("You stepped on a Bomb :("); 
        Thread.Sleep(1000);
        Console.SetCursorPosition(11, 27);
        Console.WriteLine("Press any key to continue...");
        Console.SetCursorPosition(39, 27);
        Console.ReadKey(true);
    }

    static void winning()
    {
        Console.ForegroundColor = ConsoleColor.White;
        Console.SetCursorPosition(11, 25);
        Console.WriteLine("YOU WON CONGRATS :)"); 
        Thread.Sleep(1000);
        Console.SetCursorPosition(11, 27);
        Console.WriteLine("Press any key to continue...");
        Console.SetCursorPosition(39, 27);
        Console.ReadKey(true);
    }

    static int EXIT()
    {
        Console.Clear();
        printtitle();
        Console.ForegroundColor = ConsoleColor.White;
        Console.SetCursorPosition(70,20);
        Console.WriteLine("PLEASE DON'T LEAVE ME!");
        Console.SetCursorPosition(70,22);
        Console.WriteLine("Are you sure you want to do this to me?");
        Console.SetCursorPosition(74,24);
        Console.WriteLine("[ ] YES        [ ] NO");
        Console.SetCursorPosition(90,24);
        int y = 90;
        while (true)
        {
            ConsoleKey keyPressed = Console.ReadKey(true).Key;
            if (keyPressed == ConsoleKey.Enter)
            {
                return y;
            }
            else if(keyPressed == ConsoleKey.LeftArrow)
            {
                y = 75;
            }
            else if(keyPressed == ConsoleKey.RightArrow)
            {
                y = 90;
            }
            Console.SetCursorPosition(y,24);
        }
    }

    static void devinfo()
    {
        Console.Clear();
        printtitle();
        Console.ForegroundColor = ConsoleColor.White;
        Console.SetCursorPosition(70, 18);
        Console.WriteLine("DEVELOPER GITHUB: GengarXNebulac");
        Console.SetCursorPosition(70, 20);
        Console.WriteLine("Programming Language: C#");
        Console.SetCursorPosition(70, 22);
        Console.WriteLine("Creatiation Date: 10.3.2025");
        Console.SetCursorPosition(70, 24);
        Console.Write("Please click any key to continue...");
        Console.SetCursorPosition(105, 24);
        Console.ReadKey(true);
    }
}