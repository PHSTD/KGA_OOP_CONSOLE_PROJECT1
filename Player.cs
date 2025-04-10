using KGA_OOP_CONSOLE_PROJECT1.Scene;

namespace KGA_OOP_CONSOLE_PROJECT1;

public class Player
{
    public static int hp = 100;
    public static int mp = 100;
    public static Vector2 position;
    
    private Inventory inventory;
    public Inventory Inventory { get { return inventory; } }

    public Player()
    {
        inventory = new Inventory();
    }

    public static void PlayerSet(int level)
    {
        switch (level)
        {
            case 1:
            case 2:
            case 3:
            case 4:
            case 5:
                position.x = 1;
                position.y = 1;
                break;
        }
    }
    
    public static void PlayerPrint()
    {
        Console.SetCursorPosition(position.x,position.y);
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write('P');
        Console.ResetColor();
    }
    
    public static void PlayerMove(ConsoleKey input)
    {
        Vector2 targetPos = position;
        
        switch (input)
        {
            case ConsoleKey.UpArrow:
            case ConsoleKey.W:
                targetPos.y--;
                break;
            case ConsoleKey.DownArrow:
            case ConsoleKey.S:
                targetPos.y++;
                break;
            case ConsoleKey.LeftArrow:
            case ConsoleKey.A:
                targetPos.x--;
                break;
            case ConsoleKey.RightArrow:
            case ConsoleKey.D:
                targetPos.x++;
                break;
            case ConsoleKey.D0:
                DungeonScene.exitDungeon = true;
                break;
        }
        
        if (Map.tiles[targetPos.y, targetPos.x] == true)
        {
            position = targetPos;
        }
    }
    
    public static void PlayerPrintAll()
    {
        Console.WriteLine("============== 상태 ===============");
        Console.WriteLine($"체력 : {hp} 마력 : {mp}");
    }
    
    public static string PlayerGeteItem(int num)
    {
        return Inventory.inventory[num];
    }

    public static void PlayerRemoveItem(int num)
    {
        Inventory.inventory.RemoveAt(num);
    }
    
}
