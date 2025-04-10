using KGA_OOP_CONSOLE_PROJECT1.Scene;

namespace KGA_OOP_CONSOLE_PROJECT1;

public class Player : Inventory
{
    public static int maxInt = 100;
    public static int hp = 100;
    public static int mp = 100;
    public static int speed = 0;
    public static int cold = 0;
    public static int demege = 0;
    public static int power= 0;
    public static int armor = 0;
    public static Vector2 position;
    
    public static void ArmorPlus(int amount)
    {
        armor = armor + amount;
    }
    
    public static void SpeedPlus(int amount)
    {
        speed = speed + amount;
    }
    
    public static void DemegePlus(int amount)
    {
        demege = demege + amount;
    }
    
    public static void ColdPlus(int amount)
    {
        cold = cold + amount;
    }
    
    public static void PlayerSet(int level)
    {
        switch (level)
        {
            case 1:
            case 2:
            case 3:
            case 4:
            case 5:
                position.x = 1;
                position.y = 1;
                break;
        }
    }

    public static void HpPlus(int amount)
    {
        hp += amount;
        if (hp > 100)
        {
            hp = maxInt;
        }
    }
        
    public static void MpPlus(int amount)
    {
        mp += amount;
        if (mp > 100)
        {
            mp = maxInt;
        }
    }
    
    public static void PowerPlus(int amount)
    {
        power = power + amount;
    }
    
    public static void PlayerPrint()
    {
        Console.SetCursorPosition(position.x,position.y);
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write('P');
        Console.ResetColor();
    }
    
    public static void PlayerMove(ConsoleKey input)
    {
        Vector2 targetPos = position;
        
        switch (input)
        {
            case ConsoleKey.UpArrow:
            case ConsoleKey.W:
                targetPos.y--;
                break;
            case ConsoleKey.DownArrow:
            case ConsoleKey.S:
                targetPos.y++;
                break;
            case ConsoleKey.LeftArrow:
            case ConsoleKey.A:
                targetPos.x--;
                break;
            case ConsoleKey.RightArrow:
            case ConsoleKey.D:
                targetPos.x++;
                break;
            case ConsoleKey.D0:
                DungeonScene.exitDungeon = true;
                break;
        }
        
        if (Map.tiles[targetPos.y, targetPos.x] == true)
        {
            position = targetPos;
        }
    }
    
    public static void PlayerPrintAll()
    {
        Console.WriteLine("============================= 상태 ===============================");
        Console.WriteLine($"체력 : {hp}, 마력 : {mp}, 속도 : {speed}, 추위 : {cold}, 부상 : {demege}");
        Console.WriteLine($"공격력 : {power}, 방어력 : {armor}");
    }
    
    public static string PlayerGetItem(int num)
    {
        return inventory[num];
    }

    public static void PlayerRemoveItem(int num)
    {
        inventory.RemoveAt(num);
    }

    public static void PlayerUseItem(int num)
    {
        string item = PlayerGetItem(num);
        Console.WriteLine($"{item}를 사용 하시겠습니까? [y/n]");
        ConsoleKey key = Console.ReadKey(true).Key;
        if (key == (ConsoleKey)'Y')
        {
            PlayerRemoveItem(int.Parse(num.ToString()));

            switch (item)
            {
                case "빨간포션":
                    HpPlus(10);
                    break;
                case "주황포션":
                    HpPlus(40);
                    break;
                case "파란포션":
                    MpPlus(10);
                    break;
                case "보라포션":
                    MpPlus(40);
                    break;
                case "장검":
                    PowerPlus(50);
                    break;
                case "단검":
                    PowerPlus(30);
                    break;
                case "너클":
                    PowerPlus(60);
                    break;
                case "표창":
                    PowerPlus(10);
                    break;
                case "투구":
                    ArmorPlus(10);
                    break;
                case "글러브":
                    DemegePlus(10);
                    break;
                case "패딩":
                    ColdPlus(10);
                    break;
                case "신발":
                    SpeedPlus(10);
                    break;
            }
        }
    }
    
}
