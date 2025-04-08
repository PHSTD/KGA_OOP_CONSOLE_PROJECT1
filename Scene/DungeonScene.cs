namespace KGA_OOP_CONSOLE_PROJECT1.Scene;

public class DungeonScene : BaseScene
{
    public override void Render()
    {
        Console.WriteLine("========== 설정 ============");
        Console.WriteLine("1. 소리설정");
        Console.WriteLine("2. 그래픽 설정");
        Console.WriteLine("3. 타이틀로");
    }


    public override void Update()
    {
        switch (inputKey)
        {
            
        }
    }

    public override void Result()
    {
        switch (inputKey)
        {
            
        }
    }
}