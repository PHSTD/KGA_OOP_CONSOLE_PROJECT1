namespace KGA_OOP_CONSOLE_PROJECT1.Scene;

public class HomeScene : BaseScene
{
    public override void Render()
    {
        Console.WriteLine("당신은 집에 왔습니다.");
        Console.WriteLine("1. 휴식 - HP를 회복한다.");
        Console.WriteLine("2. 광장가기 - 광장으로 이동합니다.");
        Console.WriteLine("5. 나간다.");
        
        Inventory.ItemPrintAll();
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
                Game.ChangeScene("Potion");
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
}