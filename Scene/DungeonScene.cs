namespace KGA_OOP_CONSOLE_PROJECT1.Scene;

public class DungeonScene : BaseScene
{
    public static bool exitDungeon = false;
    public override void Render()
    {
        Console.WriteLine("========== 던전 ============");
        Console.WriteLine("1. 레벨 1");
        Console.WriteLine("2. 레벨 2");
        Console.WriteLine("3. 레벨 3");
        Console.WriteLine("4. 레벨 4");
        Console.WriteLine("5. 레벨 5");
        Console.WriteLine("6. 광장으로가기");
        
        Player.PlayerPrintAll();
        Inventory.ItemPrintAll();
    }

    public override void Input()
    {
        inputKey = Console.ReadKey(true).Key;
    } 
    
    
    public override void Update()
    {
        switch (inputKey)
        {
            case ConsoleKey.D1:
                Map.MapSet(1);
                Player.PlayerSet(1);
                break;        
            case ConsoleKey.D2:
                Map.MapSet(2);
                Player.PlayerSet(2);
                break;        
            case ConsoleKey.D3:
                Map.MapSet(3);
                Player.PlayerSet(3);
                break;        
            case ConsoleKey.D4:
                Map.MapSet(4);
                Player.PlayerSet(4);
                break;        
            case ConsoleKey.D5:
                Map.MapSet(5);
                Player.PlayerSet(5);
                break;        
            case ConsoleKey.D6:
                Game.ChangeScene("Town");
                break;        
        }
        
    }

    public override void Result()
    {
        exitDungeon = false;
        while (exitDungeon == false)
        {
            Map.MapPrint();
            Player.PlayerPrint();
            Player.PlayerMove(Console.ReadKey(true).Key);
        }
    }
    
}