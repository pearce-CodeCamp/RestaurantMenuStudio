using System;

namespace RestaurantMenu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Menu menu = new Menu("Studio Menu");
            Console.WriteLine(menu.Title);
            Console.WriteLine(menu.Items);
            Console.WriteLine(menu.Items.Count);
            Console.WriteLine(menu.LastUpdated);

            MenuItem soup = new MenuItem(7.50, "Butternut Squash Soup", "appetizer");
            Console.WriteLine(soup.Price);
            Console.WriteLine(soup.Description);
            Console.WriteLine(soup.Category);
            
        }
    }
}
