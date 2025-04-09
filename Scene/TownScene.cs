namespace KGA_OOP_CONSOLE_PROJECT1.Scene;

public class TownScene : BaseScene
{
    public override void Render()
    {
        Console.WriteLine("당신은 광장으로 들어왔습니다.");
        Console.WriteLine("1. 포션 상점으로 간다");
        Console.WriteLine("2. 방어구 상점으로 간다");
        Console.WriteLine("3. 무기 상점으로 간다");
        Console.WriteLine("4. 던전으로 간다");
        Console.WriteLine("5. 집으로 간다.");
        
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
                Console.WriteLine("포션 상점으로 향한다");
                break;
            case ConsoleKey.D2:
                Console.WriteLine("방어구 상점으로 향한다");
                break;
            case ConsoleKey.D3:
                Console.WriteLine("무기 상점으로 향한다");
                break;
            case ConsoleKey.D4:
                Console.WriteLine("던전으로 향한다");
                break;
            case ConsoleKey.D5:
                Console.WriteLine("집으로 간다");
                break;
        }
    }

    public override void Result()
    {
        switch (inputKey)
        {
            case ConsoleKey.D1:
                Game.ChangeScene("Potion");
                break;
            case ConsoleKey.D2:
                Game.ChangeScene("ArmorShop");
                break;
            case ConsoleKey.D3:
                Game.ChangeScene("WeaponShop");
                break;
            case ConsoleKey.D4:
                Game.ChangeScene("Dungeon");
                break;
            case ConsoleKey.D5:
                Game.ChangeScene("Home");
                break;
        }
    }
}