namespace KGA_OOP_CONSOLE_PROJECT1;

public static class Inventory
{
    public static List<string> inventory = new List<string>();
    public static void ItemPrintAll()
    {
        Console.WriteLine("========== 아이템 목록 ============");
        foreach (string s in inventory)
        {
            Console.WriteLine(s);
        }
        Console.WriteLine("===================================");
    }
}