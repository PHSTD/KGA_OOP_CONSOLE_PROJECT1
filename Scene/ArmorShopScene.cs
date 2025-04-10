namespace KGA_OOP_CONSOLE_PROJECT1.Scene;

public class ArmorShopScene : BaseScene
{
    public override void Render()
    {
        Console.WriteLine("당신은 방어구 상점으로 들어왔습니다.");
        Console.WriteLine("1. 투구 - 방어력 10만큼 증가시킵니다.");
        Console.WriteLine("2. 글러브 - 부상 요소를 10만큼 감소시킵니다.");
        Console.WriteLine("3. 패딩 - 추위 내성 10만큼 증가시킵니다.");
        Console.WriteLine("4. 신발 - 속도 10만큼 증가시킵니다.");
        Console.WriteLine("0. 광장으로 이동.");
        
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
                Console.WriteLine("투구를 삽니다.");
                break;
            case ConsoleKey.D2:
                Console.WriteLine("글러브를 삽니다.");
                break;
            case ConsoleKey.D3:
                Console.WriteLine("패딩을 삽니다.");
                break;
            case ConsoleKey.D4:
                Console.WriteLine("신발을 삽니다.");
                break;
            case ConsoleKey.D0:
                Console.WriteLine("광장으로 돌아간다.");
                break;
        }
    }

    public override void Result()
    {
        switch (inputKey)
        {
            case ConsoleKey.D1:
                Inventory.inventory.Add("투구");
                break;
            case ConsoleKey.D2:
                Inventory.inventory.Add("글러브");
                break;
            case ConsoleKey.D3:
                Inventory.inventory.Add("패딩");
                break;
            case ConsoleKey.D4:
                Inventory.inventory.Add("신발");
                break;
            case ConsoleKey.D0:
                Game.ChangeScene("Town");
                break;
        }
    }
}