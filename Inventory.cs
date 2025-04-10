
namespace KGA_OOP_CONSOLE_PROJECT1;

public class Inventory
{
    public static List<string> inventory = new List<string>();
    private int selectIndex;

    public static void ItemPrintAll()
    {
        Console.WriteLine("========== 아이템 목록 ============");
        int i = 0;
        foreach (string s in inventory)
        {
            Console.WriteLine($"{i} : {s}");
            ++i;
        }
    }
}