namespace KGA_OOP_CONSOLE_PROJECT1.Scene;

public class HomeScene : BaseScene
{
    public override void Render()
    {
        Console.WriteLine("당신은 집에 왔습니다.");
        Console.WriteLine("1. 휴식 - HP와 MP를 회복한다.");
        Console.WriteLine("2. 아이템 사용");
        Console.WriteLine("3. 아이템 버리기");
        Console.WriteLine("4. 광장가기 - 광장으로 이동합니다.");
        Console.WriteLine("5. 타이틀로 이동");
        Console.WriteLine("0. 게임 끝내기");
        
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
                Console.WriteLine("휴식합니다.");
                break;
            case ConsoleKey.D2:
                Console.WriteLine("번호를 입력해주세요.");
                int useNum = int.Parse(Console.ReadLine());
                Player.PlayerUseItem(useNum);
                break;
            case ConsoleKey.D3:
                Console.WriteLine("번호를 입력해주세요.");
                int removeNum = int.Parse(Console.ReadLine());
                Console.WriteLine($"{Player.PlayerGetItem(removeNum)} 를 삭제하시겠습니까? [y/n]");
                ConsoleKey key = Console.ReadKey(true).Key;
                if (key == (ConsoleKey)'Y')
                {
                    Player.PlayerRemoveItem(int.Parse(removeNum.ToString()));   
                }
                break;
            case ConsoleKey.D4:
                Console.WriteLine("광장으로 이동합니다.");
                break;
            case ConsoleKey.D5:
                Console.WriteLine("타이틀로 이동합니다.");
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
                Player.hp = 100;
                break;
            case ConsoleKey.D3:
                break;
            case ConsoleKey.D4:
                Game.ChangeScene("Town");
                break;
            case ConsoleKey.D5:
                Game.ChangeScene("Title");
                break;
            case ConsoleKey.D0:
                Game.gameOver = true;
                break;
        }
    }
}