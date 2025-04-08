namespace KGA_OOP_CONSOLE_PROJECT1.Scene;

public class TitleScene : BaseScene
{
    public override void Render()
    {
        Console.WriteLine("==============================================");
        Console.WriteLine("                    RPG                       ");
        Console.WriteLine("==============================================");
        Console.WriteLine("1. 게임시작");
        Console.WriteLine("2. 게임불러오기");
        Console.WriteLine("3. 게임설정");
        Console.WriteLine("4. 게임종료");
    }


    public override void Update()
    {
        switch (inputKey)
        {
            case ConsoleKey.D1:
                Console.WriteLine("게임을 시작합니다.");
                break;
            case ConsoleKey.D2:
                Console.WriteLine("게임을 불러옵니다.");
                break;
            case ConsoleKey.D3:
                Console.WriteLine("게임을 설정합니다.");
                break;
            case ConsoleKey.D4:
                Console.WriteLine("게임을 종료합니다.");
                break;
            default:
                Console.WriteLine("범위를 벗어났습니다.");
                break;
        }
    }

    public override void Result()
    {
        switch (inputKey)
        {
            case ConsoleKey.D1:
                Game.ChangeScene("Town");
                break;
            case ConsoleKey.D2:
                Console.WriteLine("준비중인 기능입니다.");
                break;
            case ConsoleKey.D3:
                Game.ChangeScene("Setting");
                break;
            case ConsoleKey.D4:
                Game.gameOver = true;
                break;
            default:
                Console.WriteLine("범위를 벗어났습니다.");
                break;
        }
    }
}