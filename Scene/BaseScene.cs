namespace KGA_OOP_CONSOLE_PROJECT1.Scene;

public abstract class BaseScene
{
    protected string name;
    protected ConsoleKey inputKey;
    
    public abstract void Render();
    public abstract void Input();
    public abstract void Update();
    public abstract void Result();

}