namespace KGA_OOP_CONSOLE_PROJECT1.Scene;

public class HomeScene : BaseScene
{
    public override void Render()
    {
        Console.WriteLine("당신은 집에 왔습니다.");
        Console.WriteLine("1. 휴식 - HP를 회복한다.");
        Console.WriteLine("2. 광장가기 - 광장으로 이동합니다.");
        
        Inventory.ItemPrintAll();
    }


    public override void Update()
    {
        switch (inputKey)
        {
            case ConsoleKey.D1:
                Console.WriteLine("휴식합니다.");
                break;
            case ConsoleKey.D2:
                Console.WriteLine("광장으로 이동합니다.");
                break;
        }
    }

    public override void Result()
    {
        switch (inputKey)
        {
            case ConsoleKey.D1:
                Player.hp = 100;
                break;
            case ConsoleKey.D2:
                Game.ChangeScene("Town");
                break;
        }
    }
}