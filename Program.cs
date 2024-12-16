namespace day19homework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player();
            Weapon weapon = new Weapon();
            weapon.Name = "발뭉";
            weapon.atk = 0;
            UsableItem usableItem = new UsableItem();
            usableItem.Name = "체력포션";
            usableItem.Price = 0;
            usableItem.Quantity = 50;
            UsableItem usableItem2 = new UsableItem();
            usableItem2.Name = "마나포션";
            usableItem2.Price = 2;
            usableItem2.Quantity = 50;

            player.AddItem(usableItem2);
            player.AddItem(usableItem);
            player.AddItem(weapon);
            player.ShowInven();
            player.UseMyItem();
        }
    }
}
