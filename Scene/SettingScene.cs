namespace KGA_OOP_CONSOLE_PROJECT1.Scene;

public class SettingScene : BaseScene
{
    public override void Render()
    {
        Console.WriteLine("========== 설정 ============");
        Console.WriteLine("1. 소리설정");
        Console.WriteLine("2. 그래픽 설정");
        Console.WriteLine("0. 타이틀로 돌아간다");
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
                Console.WriteLine("소리 설정 완료");
                break;
            case ConsoleKey.D2:
                Console.WriteLine("그래픽 설정 완료");
                break;
            case ConsoleKey.D0:
                Console.WriteLine("타이틀로 돌아간다");
                break;
        }
    }

    public override void Result()
    {
        switch (inputKey)
        {
            case ConsoleKey.D1:
                Console.ReadKey();
                break;
            case ConsoleKey.D2:
                Console.ReadKey();
                break;
            case ConsoleKey.D0:
                Game.ChangeScene("Title");
                break;
        }
    }
}