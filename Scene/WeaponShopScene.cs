namespace KGA_OOP_CONSOLE_PROJECT1.Scene;

public class WeaponShopScene : BaseScene
{
    public override void Render()
    {
        Console.WriteLine("당신은 무기 상점으로 들어왔습니다.");
        Console.WriteLine("1. 장검 - 공격력 50 증가");
        Console.WriteLine("2. 단검 - 공격력 30 증가");
        Console.WriteLine("3. 너클 - 공격력 60 증가");
        Console.WriteLine("4. 표창 - 공격력 10 증가");
        Console.WriteLine("5. 나간다.");
        
        Inventory.ItemPrintAll();
    }

    public override void Update()
    {
        switch (inputKey)
        {
            case ConsoleKey.D1:
                Console.WriteLine("장검을 삽니다.");
                break;
            case ConsoleKey.D2:
                Console.WriteLine("단검을 삽니다.");
                break;
            case ConsoleKey.D3:
                Console.WriteLine("너클을 삽니다.");
                break;
            case ConsoleKey.D4:
                Console.WriteLine("표창을 삽니다.");
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
                Inventory.inventory.Add("장검");
                break;
            case ConsoleKey.D2:
                Inventory.inventory.Add("단검");
                break;
            case ConsoleKey.D3:
                Inventory.inventory.Add("너클");
                break;
            case ConsoleKey.D4:
                Inventory.inventory.Add("표창");
                break;
            case ConsoleKey.D5:
                Game.ChangeScene("Town");
                break;
        }
    }
}