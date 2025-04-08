namespace KGA_OOP_CONSOLE_PROJECT1.Scene;

public class PotionScene : BaseScene
{
    public override void Render()
    {
        Console.WriteLine("당신은 포션 상점으로 들어왔습니다.");
        Console.WriteLine("1. 빨간포션 - HP를 10만큼 회복한다.");
        Console.WriteLine("2. 파란포션 - MP를 10만큼 화복한다.");
        Console.WriteLine("3. 주황포션 - HP를 40만큼 회복한다.");
        Console.WriteLine("4. 보라포션 - MP를 40만큼 회복한다.");
        Console.WriteLine("5. 나간다.");
        
        Inventory.ItemPrintAll();
    }


    public override void Update()
    {
        switch (inputKey)
        {
            case ConsoleKey.D1:
                Console.WriteLine("빨간포션을 삽니다.");
                break;
            case ConsoleKey.D2:
                Console.WriteLine("파란포션을 삽니다.");
                break;
            case ConsoleKey.D3:
                Console.WriteLine("주황포션을 삽니다.");
                break;
            case ConsoleKey.D4:
                Console.WriteLine("보라포션을 삽니다.");
                break;
            case ConsoleKey.D5:
                Console.WriteLine("광장으로 돌아간다.");
                break;
        }
    }

    public override void Result()
    {
        switch (inputKey)
        {
            case ConsoleKey.D1:
                Inventory.inventory.Add("빨간포션");
                break;
            case ConsoleKey.D2:
                Inventory.inventory.Add("파란포션");
                break;
            case ConsoleKey.D3:
                Inventory.inventory.Add("주황포션");
                break;
            case ConsoleKey.D4:
                Inventory.inventory.Add("보라포션");
                break;
            case ConsoleKey.D5:
                Game.ChangeScene("Town");
                break;
        }
        
    }
}