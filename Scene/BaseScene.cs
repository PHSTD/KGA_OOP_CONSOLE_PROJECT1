namespace KGA_OOP_CONSOLE_PROJECT1.Scene;

public abstract class BaseScene
{
    public static string name;
    protected static ConsoleKey inputKey;

    public abstract void Render();
    public void Input()
    {
        inputKey = Console.ReadKey(true).Key;
    }
    public abstract void Update();
    public abstract void Result();

}