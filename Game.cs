using KGA_OOP_CONSOLE_PROJECT1.Scene;

namespace KGA_OOP_CONSOLE_PROJECT1;

public class Game
{
    private static Dictionary<string, BaseScene> sinDic;
    private static BaseScene curScene;
    
    public static bool gameOver = false;

    public static void Start()
    {
        Console.CursorVisible = false;
            
        sinDic = new Dictionary<string, BaseScene>();
        sinDic.Add("Title", new TitleScene());
        sinDic.Add("Town", new TownScene());
        sinDic.Add("Potion", new PotionScene());
        sinDic.Add("Dungeon", new DungeonScene());
        sinDic.Add("Home", new HomeScene());
        sinDic.Add("WeaponShop", new WeaponShopScene());
        sinDic.Add("ArmorShop", new ArmorShopScene());
        sinDic.Add("Setting", new SettingScene());

        curScene = sinDic["Title"];
        
    }
    
    public static void End()
    {
        Console.WriteLine("게임종료");
    }
    
    public static void Run()
    {
        Start();
        while (gameOver == false)
        {
            Console.Clear();
            curScene.Render();
            curScene.Input();
            Console.WriteLine();
            curScene.Update();
            Console.WriteLine();
            curScene.Result();
        }
        End();
    }

    public static void ChangeScene(string sceneName)
    {
        Console.Clear();
        curScene = sinDic[sceneName];
    }
}